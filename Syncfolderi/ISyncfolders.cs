using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfolderi
{
    public interface ISyncfolders
    {
        string SourcePath();
        string TargetPath();
        string StatDownloadChangesApplied();
        string StatDownloadChangesFailed();
        string StatDownloadChangesTotal();
        string StatUploadChangesApplied();
        string StatUploadChangesFailed();
        string StatUploadChangesTotal();
        string[] Sourcefiles();
        string[] Sourcefolders();
        string[] Targetfiles();
        string[] Targetfolders();
        void TakeSource();
        void TakeTarget();
        void SyncFolder();
    }
}
