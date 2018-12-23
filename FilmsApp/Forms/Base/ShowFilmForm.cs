using FilmsApp.Classes.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsApp.Forms.Base
{
    public partial class ShowFilmForm : BaseForm
    {
        public ShowFilmForm(ref MovieDBDataSetTableAdapters.vMoviesTableAdapter adapter)
        {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            string cmd = "ID=" + SqlManipul.GetInstance().CurrentFilmId.ToString();
            textBox1.Text = adapter.GetData().Select(cmd)[0].ToString();
        }

    }
}
