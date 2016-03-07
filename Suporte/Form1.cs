using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Suporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Suporte 01");
            comboBox1.Items.Add("Suporte 02");
            comboBox1.Items.Add("Suporte 03");
            comboBox1.Items.Add("Suporte 04");
            comboBox1.Items.Add("Suporte 05");
            comboBox1.Items.Add("Suporte 06");
            comboBox1.Items.Add("Suporte 07");
            comboBox1.Items.Add("Suporte 08");
            comboBox1.Items.Add("Suporte 09");
            comboBox1.Items.Add("Suporte 10");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Suporte 01")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen");
                p.Start();
                Application.Exit();
            }
            
            if (comboBox1.SelectedItem == "Suporte 02")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5501");
                p.Start();
                Application.Exit();
            }
            if (comboBox1.SelectedItem == "Suporte 03")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5502");
                p.Start();
                Application.Exit();
            }

            if (comboBox1.SelectedItem == "Suporte 04")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5503");
                p.Start();
                Application.Exit();
            }
            if (comboBox1.SelectedItem == "Suporte 05")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5504");
                p.Start();
                Application.Exit();
            }

            if (comboBox1.SelectedItem == "Suporte 06")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5505");
                p.Start();
                Application.Exit();
            }
            if (comboBox1.SelectedItem == "Suporte 07")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5506");
                p.Start();
                Application.Exit();
            }

            if (comboBox1.SelectedItem == "Suporte 08")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5507");
                p.Start();
                Application.Exit();
            }
            if (comboBox1.SelectedItem == "Suporte 09")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5508");
                p.Start();
                Application.Exit();
            }

            if (comboBox1.SelectedItem == "Suporte 10")
            {
                Process p = new Process();
                p.StartInfo.FileName = "vncviewer.exe";
                p.StartInfo.Arguments = string.Format("-listen 5509");
                p.Start();
                Application.Exit();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}