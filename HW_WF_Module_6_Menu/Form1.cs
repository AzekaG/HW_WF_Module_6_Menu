using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW_WF_Module_6_Menu
{
    public partial class Form1 : Form
    {
        string path = "My File";
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt | Azeka Notepad File(*.tnf)|*.tnf";
            this.Text = path;
            


        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            path = saveFileDialog1.FileName;
            this.Text = path;
            File.WriteAllText(path, richTextBox1.Text);
            MessageBox.Show("Файл сохранён!");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            this.Text = path;
            string fileText = File.ReadAllText(path);
            richTextBox1.Text = fileText;
            MessageBox.Show("Файл открыт!");

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(path, richTextBox1.Text);
            MessageBox.Show("Файл сохранен в bin/debug.");
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength>0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) 
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void выделитьВсёToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void создатьНовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.DimGray;
            richTextBox1.BackColor = Color.White;
            menuStrip1.BackColor = Color.SeaShell;
        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.DimGray;
            menuStrip1.BackColor = Color.Gray;
        }
    }
}
