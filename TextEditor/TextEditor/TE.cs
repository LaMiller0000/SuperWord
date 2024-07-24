using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TE : Form
    {

        private double width = 10; // the width of the page
        private double height = 450; // the height of the page
        private double ratio = 0.77; // 8.5 / 11 = .77 * 300 height pixels = 231 width pixel
        private int tabLength = 5;



        private RichTextBox TextPanel;
        public double findRatio(double x, double y)
        {
            ratio = y / x;
            return ratio;
        }

        public void setCoor(double h)
        {
            width = ratio * h;
        }

        public TE()
        {
            InitializeComponent();
            CustomInitializeComponent();
        }

        private void CustomInitializeComponent()
        {
            height = ClientSize.Height;
            int s = ClientSize.Width;
            setCoor(height);
            richTextBox1.Size = new Size((int)width, (int)height);
            s -= (int)width;
            s /= 2;
            richTextBox1.Location = new Point(s, 0);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TE_Resize(object sender, EventArgs e)
        {
            //InitializeComponent();
            CustomInitializeComponent();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
