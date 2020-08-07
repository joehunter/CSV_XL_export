using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_XL_export
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


		private void button1_Click(object sender, EventArgs e)
		{



            //
            //  Use this for SQL connection references
            //

            // https://www.microsoft.com/en-us/sql-server/developer-get-started/csharp/win/step/2.html



            // Checks the value of the text.

            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "You did not enter a server name. Cancel this operation?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                       

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }
            

        }
	}
}
