using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenshotVerificationServer.Models;

namespace ScreenshotVerificationServer.Services
{
    public interface IScreenshotRepository
    {
        void Add(ScreenshotInfo screenshotInfo);
        ScreenshotInfo Get(object key);
        IReadOnlyCollection<ScreenshotInfo> Get();
        void Delete(object key);
        void Delete(object[] keys);
    }
}
