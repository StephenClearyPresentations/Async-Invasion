using System;

namespace SampleCode._3B_IAsyncResult
{
    public interface IDownloadFromInternet
    {
        IAsyncResult BeginDownload(AsyncCallback callback, object state);
        string EndDownload(IAsyncResult result);
    }
}
