using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Suporte
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        void RunProcess(int port)
        {
            Process.Start("vncviewer.exe", $"-listen {port}");
            Application.Exit();
        }

        private void comboSuporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int port = 5000;
            ComboBox combo = sender as ComboBox;
            if (combo.SelectedIndex >= 0)
            {
                RunProcess(port + combo.SelectedIndex);
            }
        }
    }
}