using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Files;

namespace Syncfolderi
{
    public class Syncfolders : ISyncfolders
    {
        string LeftPath;
        string RightPath;
        string[] LeftFiles;
        string[] LeftFolders;
        string[] RightFiles;
        string[] RightFolders;
        SyncOperationStatistics stats;


        public string SourcePath()
        {
            return LeftPath;
        }
        
        public string TargetPath()
        {
            return RightPath;
        }

        public string[] Sourcefiles()
        {
            return LeftFiles;
        }

        public string[] Sourcefolders()
        {
            return LeftFolders;
        }

        public string[] Targetfolders()
        {
            return RightFolders;
        }

        public string[] Targetfiles()
        {
            return RightFiles;
        }

        public string StatDownloadChangesApplied()
        {
            return stats.DownloadChangesApplied.ToString();
        }

        public string StatDownloadChangesFailed()
        {
            return stats.DownloadChangesFailed.ToString();
        }

        public string StatDownloadChangesTotal()
        {
            return stats.DownloadChangesTotal.ToString();
        }

        public string StatUploadChangesApplied()
        {
            return stats.UploadChangesApplied.ToString();
        }

        public string StatUploadChangesFailed()
        {
            return stats.UploadChangesFailed.ToString();
        }

        public string StatUploadChangesTotal()
        {
            return stats.UploadChangesTotal.ToString();
        }


        public void TakeSource()
        {
           FolderBrowserDialog leftPanel = new FolderBrowserDialog();
            if (leftPanel.ShowDialog() == DialogResult.OK)
                {
                
                    LeftPath = leftPanel.SelectedPath;
               
                   LeftFiles = Directory.GetFiles(leftPanel.SelectedPath);
                   LeftFolders = Directory.GetDirectories(leftPanel.SelectedPath);
               
                }
        }

        public void TakeTarget()
        {
            FolderBrowserDialog rightPanel = new FolderBrowserDialog();
            if (rightPanel.ShowDialog() == DialogResult.OK)
            {
                RightPath = rightPanel.SelectedPath;
               
                 RightFiles = Directory.GetFiles(rightPanel.SelectedPath);
                 RightFolders = Directory.GetDirectories(rightPanel.SelectedPath);
                
                
            }
        }


        public void SyncFolder()
        {
            // Create file system provider
            FileSyncProvider providerA = new FileSyncProvider(LeftPath);
            FileSyncProvider providerB = new FileSyncProvider(RightPath);

            // Ask providers to detect changes
            providerA.DetectChanges();
            providerB.DetectChanges();

            // Sync changes
            
            SyncOrchestrator agent = new SyncOrchestrator();
            agent.LocalProvider = providerA;
            agent.RemoteProvider = providerB;
            agent.Direction = SyncDirectionOrder.UploadAndDownload;
            
            // Statistica
           stats = agent.Synchronize();
           

        }
    }
}
