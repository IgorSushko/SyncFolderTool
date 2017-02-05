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
        
        SyncOperationStatistics stats;

       
        public void SourcePath(string spath)
        {
            LeftPath=spath;
        }
        
        public void TargetPath(string tpath)
        {
            RightPath=tpath;
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
