using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
   public static class Helperr
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public static Image ByteToImage(byte[] arr)
        {
            byte[] image = arr;
            MemoryStream ms = new MemoryStream(image);
            Image i = Image.FromStream(ms);
            return i;
        }
    }
}
