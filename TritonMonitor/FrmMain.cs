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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Form frm = new FrmConfiguracion();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // valida base de datos
            Conect database = new Conect();
            DataRow row = database.Row("SELECT count(*) nrows FROM sqlite_master WHERE type ='table' AND name NOT LIKE 'sqlite_%' ");
            if (row != null) {
                if (row["nrows"].ToString() != "")
                {
                    MessageBox.Show("Hay elementos");
                }
                else
                {
                    MessageBox.Show("No hay elementos");
                }
            }
            else
            {
                MessageBox.Show("Problemas al crear estrutura local");
            }
        }
    }
}
