/*
 *  Author: Troy Davis
 *  Project: Module07 - Understanding Events and Event-Driven Programming - WinForm Example - GUI
 *  Class: IN 2017 (Advanced C#)
 *  Date: Mar 07, 2017 
 *  Revision: Original
 */

using System;
using System.Windows.Forms;

namespace WinForm_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_MyOtherClick;
        }

        private void button1_MyOtherClick(object sender, EventArgs e)
        {
            myOtherLabel.Text = "Hello again from myOther WinForm Label!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myLabel.Text = "Hello WinForm World!";
        }
    }
}
