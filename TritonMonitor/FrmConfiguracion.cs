using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TritonMonitor
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(printDocument.pr);
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters) {
                //MessageBox.Show(printer); 
                cmbPrinter.Items.Add(printer);
            }
        }
    }
}
