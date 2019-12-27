using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ByteROT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                CheckFileExists = true,
                CheckPathExists = true,

                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte offset = byte.Parse(txtOffset.Text);
            byte[] input = File.ReadAllBytes(txtDir.Text);
            File.WriteAllBytes(txtDir.Text + "_ENC", encrypt(input, offset));
            setHints(offset);

            MessageBox.Show("Done !");
        }
        void setHints(byte offset)
        {
            txtHints.Text = @"
         byte[] decrypt(byte[] input)
        {
           
            for (int i = 0; i < input.Length; i++)
            {

                if (i % 2 == 0)
                {
                    input[i] = (byte)(input[i] - offset - 7);
                }
                else if (i % 3 == 0)
                {
                    input[i] = (byte)(input[i] - offset - 13);
                }
                else if (i % 5 == 0)
                {
                    input[i] = (byte)(input[i] - offset - 4);
                }
                else
                {
                    input[i] = (byte)(input[i] - offset);
                }
               
            }
            return input;
        }
".Replace("offset", offset.ToString());
        }

        byte[] encrypt(byte[] input, byte offset)
        {

            for (int i = 0; i < input.Length; i++)
            {

                if (i % 2 == 0)
                {
                    input[i] = (byte)(input[i] + offset+7);
                }
                else if (i % 3 == 0)
                {
                    input[i] = (byte)(input[i] + offset+13);
                }
                else if (i % 5 == 0)
                {
                    input[i] = (byte)(input[i] + offset+4);
                }
                else
                {
                    input[i] = (byte)(input[i] + offset);
                }
               
                
            }
            return input;
        }

       byte[] decrypt(byte[] input,byte offset)
        {
           
            for (int i = 0; i < input.Length; i++)
            {

                if (i % 2 == 0)
                {
                    input[i] = (byte)(input[i] - offset - 7);
                }
                else if (i % 3 == 0)
                {
                    input[i] = (byte)(input[i] - offset - 13);
                }
                else if (i % 5 == 0)
                {
                    input[i] = (byte)(input[i] - offset - 4);
                }
                else
                {
                    input[i] = (byte)(input[i] - offset);
                }
               
            }
            return input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte offset = byte.Parse(txtOffset.Text);
            byte[] input = File.ReadAllBytes(txtDir.Text);
            File.WriteAllBytes(txtDir.Text + "dec.exe", decrypt(input,offset));
            MessageBox.Show("Done!");
        }


    }
}
