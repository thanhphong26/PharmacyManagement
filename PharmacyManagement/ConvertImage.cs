using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    public class ConvertImage
    {
        public Image ConvertToImage(byte[] ima)
        {
            MemoryStream ms = new MemoryStream(ima);
            Image img = Image.FromStream(ms);
            return img;
        }
        public byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();

        }
    }
}
