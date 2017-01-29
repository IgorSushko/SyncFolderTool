using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;

namespace Syncfolderi
{
    public partial class Form1 : Form
    {
        //string[] arrayLeftfiles;
        //string[] arrayRightfiles;

        ErrorProvider errorProvider;   //For Errors
        Syncfolders bb1;    // for sync

        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            bb1 = new Syncfolders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bb1.TakeSource();
            label1.Text = bb1.SourcePath();
            listBox1.Items.Clear();
                foreach (string file in bb1.Sourcefiles())
                        {
                          listBox1.Items.Add(Path.GetFileName(file));
                        }
                foreach (string folder in bb1.Sourcefolders())
                        {
                          listBox1.Items.Add(Path.GetFileName(folder));
                        }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            bb1.TakeTarget();
            label2.Text = bb1.TargetPath();
            listBox2.Items.Clear();
                  foreach (string file5 in bb1.Targetfiles())
                          {
                             listBox2.Items.Add(Path.GetFileName(file5));
                          }
                 foreach (string folder5 in bb1.Targetfolders())
                          {
                             listBox2.Items.Add(Path.GetFileName(folder5));
                          }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bb1.SourcePath()) || String.IsNullOrEmpty(bb1.TargetPath()))
            {
                errorProvider.SetError(button1, "Please select folders to Sync");
                return;
            }
            else
            {
                errorProvider.Clear();
            }

            bb1.SyncFolder();

            listBox3.Items.Add("Download Applied: " + bb1.StatDownloadChangesApplied());
            listBox3.Items.Add("Download Failed: " + bb1.StatDownloadChangesFailed());
            listBox3.Items.Add("Download Total: " + bb1.StatDownloadChangesTotal());
            listBox3.Items.Add("Upload Total: " + bb1.StatUploadChangesApplied());
            listBox3.Items.Add("Upload Total: " + bb1.StatUploadChangesFailed());
            listBox3.Items.Add("Upload Total: " + bb1.StatUploadChangesTotal());
        }
    }
    }
