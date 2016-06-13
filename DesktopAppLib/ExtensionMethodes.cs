using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppLib
{
    public static class ExtensionMethodes
    {
        public static string ToUsageString(this DriveInfo dInfo)
        {
            return string.Format("{0} of {1}", (dInfo.TotalSize - dInfo.AvailableFreeSpace).FormatDataSize(), dInfo.TotalSize.FormatDataSize());
        }

        public static double ToPercentDouble(this DriveInfo dInfo)
        {
            return ((double)(dInfo.TotalSize - dInfo.AvailableFreeSpace) / dInfo.TotalSize) * 100;
        }

        public static string FormatDataSize(this long sizeInBytes)
        {
            if (sizeInBytes < 1024)
                return sizeInBytes + " Bytes";

            if (sizeInBytes < 1048576)
                return (sizeInBytes / 1024) + " KB";

            if (sizeInBytes < 1073741824)
                return (sizeInBytes / 1048576) + " MB";

            return (sizeInBytes / 1073741824) + " GB";
        }
    }
}
