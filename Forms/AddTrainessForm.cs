using Biblioteka2.Classes;
using Biblioteka2.Classes.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka2.Forms
{
    public partial class AddTrainessForm : Form
    {
        public AddTrainessForm()
        {
            InitializeComponent();
        }

        private void Ok_AddTrainess_Click(object sender, EventArgs e)
        {
            if (cb_noMiddle.Checked)
            {
                DbModel.init().Trainesses.Add(new TrainessClass { classTrainess = (int)nud_AddTrainess_class.Value, family_name = tb_AddTrainess_fam.Text, first_name = tb_AddTrainess_name.Text});
                DbModel.init().SaveChanges();
            }
            else 
            {
                DbModel.init().Trainesses.Add(new TrainessClass { classTrainess = (int)nud_AddTrainess_class.Value, family_name = tb_AddTrainess_fam.Text, first_name = tb_AddTrainess_name.Text, middle_name = tb_AddTrainess_middle.Text });
                DbModel.init().SaveChanges();
            }
        }
    }
}
