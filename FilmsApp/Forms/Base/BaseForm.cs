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

        protected DialogResult ShowNextForm(BaseForm nextForm,bool isClose=false)
        {
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;
            DialogResult result;

            if (isClose)
            {
                result= nextForm.ShowDialog();
                this.Show();
                return result;
            }
            else
            {
                
                this.Hide();
                result=nextForm.ShowDialog();
                this.Show();
                return result;
            }
           
        }
    }
}
