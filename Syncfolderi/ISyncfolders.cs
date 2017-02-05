using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfolderi
{
    public interface ISyncfolders
    {
        
        string StatDownloadChangesApplied();
        string StatDownloadChangesFailed();
        string StatDownloadChangesTotal();
        string StatUploadChangesApplied();
        string StatUploadChangesFailed();
        string StatUploadChangesTotal();
        void SyncFolder();
    }
}
