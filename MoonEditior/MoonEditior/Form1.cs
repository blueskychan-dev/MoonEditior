using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MoonEditior
{
    public partial class Form1 : Form
    {
        public string path;
        public string path2;
        public string path3;
        public string path4;
        public string path5;
        public string path6;
        public string path7;
        public string path8;
        public string tabnow = "1";
        public string backup;
        public string backup2;
        public string backup3;
        public string backup4;
        public string backup5;
        public string backup6;
        public string backup7;
        public string backup8;
        public Form1()
        {
            InitializeComponent();
            this.groupBox1.Visible = false;
            this.button2.Text = "Tab 1 *";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void sizeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var asksize = Interaction.InputBox("New font Size", "Change Fonts Size", richTextBox1.Font.Size.ToString());
            if (asksize == "")
            {

            }
            else
            {
                try
                {
                    this.richTextBox1.Font = new Font("Arial", int.Parse(asksize));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabnow == "1")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
            else if (tabnow == "2")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path2 = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
            else if (tabnow == "3")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path3 = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
            else if (tabnow == "4")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path4 = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
            else if (tabnow == "5")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path5 = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
            else if (tabnow == "6")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path6 = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
            else if (tabnow == "7")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path7 = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
            else if (tabnow == "8")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All Files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path8 = openFileDialog.FileName;
                            string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                            this.richTextBox1.Text = text;
                            var nopath = Path.GetFileName(openFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR: " + ex.ToString());
                        }
                    }
                }
            }
        }

        private void runDebugTerminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabnow == "1")
            {


                if (path == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "2")
            {


                if (path2 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "3")
            {


                if (path3 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "4")
            {


                if (path4 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "5")
            {


                if (path5 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "6")
            {


                if (path6 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "7")
            {


                if (path7 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "8")
            {


                if (path8 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            this.groupBox1.Visible = true;
            this.richTextBox2.Text = null;
            if (tabnow == "1")
            {
                File.WriteAllText(path, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "2")
            {
                File.WriteAllText(path2, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path2 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "3")
            {
                File.WriteAllText(path3, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path3 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "4")
            {
                File.WriteAllText(path4, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path4 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "5")
            {
                File.WriteAllText(path5, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path5 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "6")
            {
                File.WriteAllText(path6, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path6 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "7")
            {
                File.WriteAllText(path7, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path7 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "8")
            {
                File.WriteAllText(path8, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K node " + path8 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabnow == "1")
                {
                    if (path == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
                else if (tabnow == "2")
                {
                    if (path2 == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path2 = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path2);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
                else if (tabnow == "3")
                {
                    if (path3 == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path3 = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path3);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
                else if (tabnow == "4")
                {
                    if (path4 == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path4 = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path4);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
                else if (tabnow == "5")
                {
                    if (path5 == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path5 = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path5);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
                else if (tabnow == "6")
                {
                    if (path6 == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path6 = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path6);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
                else if (tabnow == "7")
                {
                    if (path7 == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path7 = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path7);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
                else if (tabnow == "8")
                {
                    if (path8 == null)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "All files (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {

                                myStream.Close();
                                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                                path8 = saveFileDialog1.FileName;
                                var nopath = Path.GetFileName(path8);
                            }
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    myStream.Close();
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    path = saveFileDialog1.FileName;
                    var nopath = Path.GetFileName(path);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
        }

        private void aboutMoonEditiorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MoonEditior Version 1.1.0 Alpha\nDeveloper: fusedevgithub\nDonate: https://github.com/fusedevgithub/MoonEditior#Donate");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabnow = "2";
            this.richTextBox1.Text = backup2;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button3.Text = "Tab 2 *";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabnow = "1";
            this.richTextBox1.Text = backup;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button2.Text = "Tab 1 *";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabnow = "3";
            this.richTextBox1.Text = backup3;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button4.Text = "Tab 3 *";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabnow = "4";
            this.richTextBox1.Text = backup4;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button5.Text = "Tab 4 *";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabnow = "5";
            this.richTextBox1.Text = backup5;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button6.Text = "Tab 5 *";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabnow = "6";
            this.richTextBox1.Text = backup6;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button7.Text = "Tab 6 *";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabnow = "7";
            this.richTextBox1.Text = backup7;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button8.Text = "Tab 7 *";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabnow = "8";
            this.richTextBox1.Text = backup8;
            this.button2.Text = "Tab 1";
            this.button3.Text = "Tab 2";
            this.button4.Text = "Tab 3";
            this.button5.Text = "Tab 4";
            this.button6.Text = "Tab 5";
            this.button7.Text = "Tab 6";
            this.button8.Text = "Tab 7";
            this.button9.Text = "Tab 8";
            this.button9.Text = "Tab 8 *";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (tabnow == "1")
            {
                backup = richTextBox1.Text;
            }
            else if (tabnow == "2")
            {
                backup2 = richTextBox1.Text;
            }
            else if (tabnow == "3")
            {
                backup3 = richTextBox1.Text;
            }
            else if (tabnow == "4")
            {
                backup4 = richTextBox1.Text;
            }
            else if (tabnow == "5")
            {
                backup5 = richTextBox1.Text;
            }
            else if (tabnow == "6")
            {
                backup6 = richTextBox1.Text;
            }
            else if (tabnow == "7")
            {
                backup7 = richTextBox1.Text;
            }
            else if (tabnow == "8")
            {
                backup8 = richTextBox1.Text;
            }
        }

        private void runAsLuaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tabnow == "1")
            {


                if (path == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "2")
            {


                if (path2 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "3")
            {


                if (path3 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "4")
            {


                if (path4 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "5")
            {


                if (path5 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "6")
            {


                if (path6 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "7")
            {


                if (path7 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "8")
            {


                if (path8 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            this.groupBox1.Visible = true;
            this.richTextBox2.Text = null;
            if (tabnow == "1")
            {
                File.WriteAllText(path, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "2")
            {
                File.WriteAllText(path2, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path2 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "3")
            {
                File.WriteAllText(path3, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path3 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "4")
            {
                File.WriteAllText(path4, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path4 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "5")
            {
                File.WriteAllText(path5, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path5 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "6")
            {
                File.WriteAllText(path6, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path6 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "7")
            {
                File.WriteAllText(path7, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path7 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "8")
            {
                File.WriteAllText(path8, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K lua53 " + path8 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
        }

        private void runAsPythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabnow == "1")
            {


                if (path == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "2")
            {


                if (path2 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "3")
            {


                if (path3 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "4")
            {


                if (path4 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "5")
            {


                if (path5 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "6")
            {


                if (path6 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "7")
            {


                if (path7 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "8")
            {


                if (path8 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            this.groupBox1.Visible = true;
            this.richTextBox2.Text = null;
            if (tabnow == "1")
            {
                File.WriteAllText(path, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "2")
            {
                File.WriteAllText(path2, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path2;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "3")
            {
                File.WriteAllText(path3, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path3;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "4")
            {
                File.WriteAllText(path4, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path4;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "5")
            {
                File.WriteAllText(path5, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path5;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "6")
            {
                File.WriteAllText(path6, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path6;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "7")
            {
                File.WriteAllText(path7, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path7;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "8")
            {
                File.WriteAllText(path8, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "python";
                    process.StartInfo.Arguments = path8;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
        }

        private void runAsBatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabnow == "1")
            {


                if (path == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "2")
            {


                if (path2 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "3")
            {


                if (path3 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "4")
            {


                if (path4 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "5")
            {


                if (path5 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "6")
            {


                if (path6 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "7")
            {


                if (path7 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            else if (tabnow == "8")
            {


                if (path8 == null)
                {
                    MessageBox.Show("Please save or open file first!");
                    return;
                }
            }
            this.groupBox1.Visible = true;
            this.richTextBox2.Text = null;
            if (tabnow == "1")
            {
                File.WriteAllText(path, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "2")
            {
                File.WriteAllText(path2, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path2 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "3")
            {
                File.WriteAllText(path3, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path3 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "4")
            {
                File.WriteAllText(path4, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path4 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "5")
            {
                File.WriteAllText(path5, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path5 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "6")
            {
                File.WriteAllText(path6, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path6 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "7")
            {
                File.WriteAllText(path7, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path7 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
            else if (tabnow == "8")
            {
                File.WriteAllText(path8, richTextBox1.Text);
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/K " + path8 + " && exit";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Synchronously read the standard output of the spawned process.
                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    // Write the redirected output to this application's window.
                    this.richTextBox2.Text += output;

                    process.WaitForExit();
                }
            }
        }

        private void resizeFontsTerminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var asksize = Interaction.InputBox("New font Size", "Change Fonts Size for Terminal", richTextBox2.Font.Size.ToString());
            if (asksize == "")
            {

            }
            else
            {
                try
                {
                    this.richTextBox2.Font = new Font("Arial", int.Parse(asksize));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }
    }
}
