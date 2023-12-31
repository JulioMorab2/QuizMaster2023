﻿using FormulariosQuizMaster;
using QuizMaster.UI.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster.UI.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioIngresoPreguntasRespuestas());
            Application.Run(new FormularioCrearCuestionarios());
            Application.Run(new FormInstrucciones());
            Application.Run(new FormQuimestres());
            Application.Run(new FormMaterias());
        }
    }
}
