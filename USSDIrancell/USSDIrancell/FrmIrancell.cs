using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace USSDIrancell
{
    public partial class FrmIrancell : Form
    {
        public FrmIrancell()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            while (true)
            {
                rtbStatus.AppendText("Start USSD for IranCell");
             
               
                //Console.WriteLine("What page?");
                string URI = "http://localhost:39923/irancell.asmx/Sum";
                rtbStatus.AppendText("sendparameter");
                //Console.WriteLine("Vars? (ENTER for none)");
        

                switch (3)
                {
                    //case 1: Manager. start_get(URI, parameter); break;
              
                    case 3: Manager.Post(URI, "2", "2"); break;

                }
            }
        }
 
         
    }
}
