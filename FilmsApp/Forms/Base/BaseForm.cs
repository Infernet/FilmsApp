using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsApp.Forms.Base
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void ShowNextForm(BaseForm nextForm,bool isClose=false)
        {
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;


            if (isClose)
            {
                Application.Run(nextForm);
                this.Close();
            }
            else
            {
                
                this.Hide();
                nextForm.ShowDialog();
                this.Show();
            }
           
        }
    }
}
