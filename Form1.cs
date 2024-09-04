using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Bus_Route
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("https://www.google.com/maps/dir///@13.8168689,100.6495809,13z/data=!4m4!4m3!2m1!5e0!3e3?entry=ttu");
        }
    }
}
