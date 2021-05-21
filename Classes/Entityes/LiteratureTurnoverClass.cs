using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2.Classes.Entityes
{
    public class LiteratureTurnoverClass
    {
        public enum e_literature_state:sbyte{ 
            storage,
            issuance,
            remove
        };

        [Key]
        public int idTurnover { get; set; }
        [Required, Index(IsUnique = true), MaxLength(32)]
        public string InventiryNum { get; set; }
        [Required]
        public Int16 year { get; set; }
        [Required]
        public virtual BookClass book { get; set; }
        [Required]
        public virtual PurchaseAccountingClass purchaseAccounting { get; set; }
        [Required]
        public e_literature_state status { get; set; }
        public override string ToString()
        {
            return book.ToString();
        }

        public static List<LiteratureTurnoverClass> addNewLitherature(BookClass book, int count) {
            List<LiteratureTurnoverClass> literatures = new List<LiteratureTurnoverClass>();
            int add_discriptor = 0;
            //перебор количества книг
            for (int i = 1; i <= count; i++)
            {
                //заполнение таблицы учетной книги данными про книгу и ее статус (при закупке она получает статус на полке)
                LiteratureTurnoverClass literature = new LiteratureTurnoverClass
                {
                    book = book,
                    status = LiteratureTurnoverClass.e_literature_state.storage
                };
                //расчет года списания (какой сейчас год + 5 лет)
                literature.year = Convert.ToInt16(DateTime.Now.Year + 5);
                bool isUnique = false;
                //пока номер уникальный....
                while (!isUnique)
                {
                    //инвентарный номер (уникальный ключ) = год побликации + "-" + 
                    literature.InventiryNum = book.publishing_year.ToString() + "_" + (i + add_discriptor).ToString();
                    //если уже есть книга с данным индивидуальным номером в базе или в списке на добавление, то цикл идёт дальше до тех пор, пока номер новой книги не переберет все неуникальные номера
                    if (literatures.Any(l => l.InventiryNum == literature.InventiryNum) || literature.book.literatureTurnovers.Any(l => l.InventiryNum == literature.InventiryNum))
                    {
                        add_discriptor++;
                    }
                    else
                    {
                        isUnique = true;
                    }

                }
                literatures.Add(literature);
            }
            
            return literatures;
        }
    }
}
