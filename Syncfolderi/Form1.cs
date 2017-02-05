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
        ErrorProvider errorProvider;   //For Errors
        Syncfolders syncfolders;    // for sync
        FolderBrowserDialog leftPanel;
        FolderBrowserDialog rightPanel;

        string LeftPath;
        string RightPath;
        string[] LeftFiles;
        string[] LeftFolders;
        string[] RightFiles;
        string[] RightFolders;


        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            syncfolders = new Syncfolders();
            leftPanel  =  new FolderBrowserDialog();
            rightPanel = new FolderBrowserDialog();
        }

        

        public void TakeSource()
        {
             
            if (leftPanel.ShowDialog() == DialogResult.OK)
            {          
                LeftFiles = Directory.GetFiles(leftPanel.SelectedPath);
                LeftFolders = Directory.GetDirectories(leftPanel.SelectedPath);

            }
        }


        public void TakeTarget()
        {
            
            if (rightPanel.ShowDialog() == DialogResult.OK)
            {
                
                RightFiles = Directory.GetFiles(rightPanel.SelectedPath);
                RightFolders = Directory.GetDirectories(rightPanel.SelectedPath);


            }
        }

        private void bSource_Click(object sender, EventArgs e)
        {
            
            TakeSource();
            Sourcelabel1.Text= leftPanel.SelectedPath;
            syncfolders.SourcePath(leftPanel.SelectedPath);
            SourceFiles.Items.Clear();


            foreach (string file in LeftFiles) 
            {
                        SourceFiles.Items.Add(Path.GetFileName(file));
                    }
            foreach (string folder in LeftFolders)
            {
                        SourceFiles.Items.Add(Path.GetFileName(folder));
                    }
        }

        private void bTarget_Click(object sender, EventArgs e)
        {
            TakeTarget();
            targetlabel2.Text = rightPanel.SelectedPath;
            syncfolders.TargetPath(rightPanel.SelectedPath);
            TargetFiles.Items.Clear();


            foreach (string file5 in RightFiles)
                    {
                        TargetFiles.Items.Add(Path.GetFileName(file5));
                    }
            foreach (string folder5 in RightFolders)
                    {
                        TargetFiles.Items.Add(Path.GetFileName(folder5));
                    }
        }

        private void bSync_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(leftPanel.SelectedPath) || String.IsNullOrEmpty(rightPanel.SelectedPath))
                {
                    errorProvider.SetError(bSync, "Please select folders to Sync");
                    return;
                }
            else
                {
                    errorProvider.Clear();
                }

            if (leftPanel.SelectedPath == rightPanel.SelectedPath)
               {
                    errorProvider.SetError(bSync, "Please select different folders to Sync");
                    return;
               }
                    else
               {
                    errorProvider.Clear();
               }

            syncfolders.SyncFolder();

            lStitistics.Items.Add("Download Applied: " + syncfolders.StatDownloadChangesApplied());
            lStitistics.Items.Add("Download Failed: " + syncfolders.StatDownloadChangesFailed());
            lStitistics.Items.Add("Download Total: " + syncfolders.StatDownloadChangesTotal());
            lStitistics.Items.Add("Upload Total: " + syncfolders.StatUploadChangesApplied());
            lStitistics.Items.Add("Upload Total: " + syncfolders.StatUploadChangesFailed());
            lStitistics.Items.Add("Upload Total: " + syncfolders.StatUploadChangesTotal());
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
