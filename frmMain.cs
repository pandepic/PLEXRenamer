using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLEXRenamer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            txtFolderPath.Text = "D:\\PLEX Media";
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            if (txtFolderPath.Text.Length > 0)
            {
                dlgOpenFolder.SelectedPath = txtFolderPath.Text;
            }

            var result = dlgOpenFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolderPath.Text = dlgOpenFolder.SelectedPath;
            }
        }
    }
}
