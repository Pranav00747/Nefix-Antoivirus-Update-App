using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace netfixupd
{
    public partial class netfixupdate : Form
    {
        #region netfixupd code

        public netfixupdate()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            (sender as Button).Parent.Dispose();
        }

        #endregion


    }
}
