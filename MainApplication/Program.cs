using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MainApplication.Main;
using BresenHam;
using circle;
using ellipse;
using Geometric_Transformation;

namespace MainApplication
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
            MainForm main = new MainForm();
            BresenhamForm bresenhamForm = new BresenhamForm();
            CircleForm circleForm = new CircleForm();
            ElipseForm elipse = new ElipseForm();
            FormOf2d formOf2D = new FormOf2d();
            Application.Run(new MainForm());
        }
    }
}
