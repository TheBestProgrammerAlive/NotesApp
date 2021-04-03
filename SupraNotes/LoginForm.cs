using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SupraNotes
{
    public partial class LoginForm : Form
    {
        Thread mainWindowThread;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindowThread = new Thread(openMainWindow);
            mainWindowThread.SetApartmentState(ApartmentState.STA);
            mainWindowThread.Start();
            
          
           
        }

        private void openMainWindow()
        {
           Application.Run(new MainWindowForm());
        }
    }
}
