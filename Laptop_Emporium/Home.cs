using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Emporium
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            reg.MdiParent = this;
        }

        private void logInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            log.MdiParent = this;
        }

        private void entryWithTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction frm = new Transaction();
            frm.Show();
            frm.MdiParent = this;
        }

        private void detailsEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            laptop_Info LInfo = new laptop_Info();
            LInfo.Show();
            LInfo.MdiParent = this;
        }

        private void updateDeleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Update_Delete upDel = new Update_Delete();
            upDel.Show();
            upDel.MdiParent = this;
        }

        private void viewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            laptop_view view = new laptop_view();
            view.Show();
            view.MdiParent = this;
        }

        private void processorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            processor pros = new processor();
            pros.Show();
            pros.MdiParent = this;
        }

        private void basicLaptopReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport fr = new frmReport();
            fr.Show();
            fr.MdiParent = this;
        }
    }
}
