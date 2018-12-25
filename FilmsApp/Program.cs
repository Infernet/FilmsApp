﻿using FilmsApp.Forms.Admin;
using FilmsApp.Forms.Base;
using FilmsApp.Forms.SelectedFilmForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SignInForm());
            Application.Run(new SelectedFilmForm());
        }
    }
}
