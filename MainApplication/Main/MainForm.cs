using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using circle;
using BresenHam;
using ellipse;
using Geometric_Transformation;


namespace MainApplication.Main
{
    public partial class MainForm : Form
    {
        //private Button openCircleButton;
        //private Button openBresenhamButton;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openCircleButton_Click(object sender, EventArgs e)
        {
            CircleForm otherForm = new CircleForm();
            otherForm.Show();
        }

        private void openBresenhamButton_Click(object sender, EventArgs e)
        {
            BresenhamForm otherForm = new BresenhamForm();
            otherForm.Show();
        }

        private void openElipseButton_Click(object sender, EventArgs e)
        {
            ElipseForm otherForm = new ElipseForm();
            otherForm.Show();
        }

        private void openTransformationButton_Click(object sender, EventArgs e)
        {
            FormOf2d otherForm = new FormOf2d();
            otherForm.Show();
        }


    }
}
