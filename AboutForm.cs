using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitwise_app
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }


        private void AboutForm_Load(object sender, EventArgs e)
        {

           label_description.Text = "Bitwise - Character Conversion Application\n\n" +
                                  "Developer: İhsan Melih DEMİRER , GitHub:cyber-mel90\n" +
                                  "Version: v1.0\n" +
                                  "Date: 2025\n\n" +
                                  "This application is entered by the user" +
                                  "characters, numbers or text in different formats\n" +
                                  "was developed to transform. \n\n" +
                                  "Supported conversions:\n" +
                                  "- ASCII (American Standard Code for Information Interchange)\n" +
                                  "- Binary \n" +
                                  "- Hexadecimal \n" +
                                  "- Unicode \n" +
                                  "Bitwise app can work with any type of data " +
                                  "and shows conversion results quickly.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Go To Main Form
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();

            // This Form Close
            this.Close();
        }
    }
}
