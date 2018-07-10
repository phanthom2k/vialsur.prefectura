using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Resources
{    
    public class clsManejadorImagenes
    {
        private System.Windows.Forms.ImageList obj_IL;

        public  clsManejadorImagenes()
        {
            obj_IL = new System.Windows.Forms.ImageList();            
        }

        public Image GetImage16(string fileName)
        {
            //if (System.IO.File.Exists(Environment.CurrentDirectory + @"\icons\16x16\" + fileName))
                return Image.FromFile(Environment.CurrentDirectory + @"\icons\16x16\" + fileName);                           
        }
        public Image GetImage32(string fileName)
        {
            //if (System.IO.File.Exists(Environment.CurrentDirectory + @"\icons\16x16\" + fileName))
            return Image.FromFile(Environment.CurrentDirectory + @"\icons\32x32\" + fileName);
        }
        public void SetImage16(string filePic, string Key)
        {
            if(System.IO.File.Exists(Environment.CurrentDirectory + @"\icons\16x16\" + filePic ) )
                obj_IL.Images.Add(Key, Image.FromFile(Environment.CurrentDirectory + @"\icons\16x16\" + filePic));
            else obj_IL.Images.Add(Key, Image.FromFile(Environment.CurrentDirectory + @"\icons\16x16\error_delete.png"));
        }
        public void SetImage32(string filePic, string Key)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\icons\32x32\" + filePic))
                obj_IL.Images.Add(Key, Image.FromFile(Environment.CurrentDirectory + @"\icons\32x32\" + filePic));
            else obj_IL.Images.Add(Key, Image.FromFile(Environment.CurrentDirectory + @"\icons\16x16\error_delete.png"));
        }
        public void SetImage48(string filePic, string Key)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\icons\48x48\" + filePic))
                obj_IL.Images.Add(Key, Image.FromFile(Environment.CurrentDirectory + @"\icons\48x48\" + filePic));
            else obj_IL.Images.Add(Key, Image.FromFile(Environment.CurrentDirectory + @"\icons\16x16\error_delete.png"));
        }

        public System.Windows.Forms.ImageList GetCatalog()
        {
            return obj_IL;
        }

        //public System.Windows.Forms.ImageList GetImage16(string filePic, string Key )
        //{
        //    obj_IL.Images.Add(Key, Image.FromFile(Environment.CurrentDirectory + @"\icons\16x16\"+ filePic));
        //    return obj_IL;
        //}



    }
}
