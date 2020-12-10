using System;
using System.Windows.Forms;
using System.Drawing;

namespace GUI
{
    public static class Animation
    {

        /// <summary>
        /// Resizes a pictureBox on width and height
        /// </summary>
        public static Func<int, PictureBox, PictureBox> ResizeOfPictureBox = delegate (int sizeValue, PictureBox originalPic)
         {
             originalPic.Height = sizeValue;
             originalPic.Width = sizeValue;
             return originalPic;
         };
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        public static bool IsFourth(int value)
        {
            return value % 4 == 0;
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        public static bool IsThird(int value)
        {
            return value % 3 == 0;
        }
        /// <summary>
        /// assigns a images from the DEbug folder to PB array
        /// </summary>
        /// <param name="initPicture"></param>
        /// <param name="name"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Func<PictureBox, string, int, PictureBox> AssigningImageToPB = delegate (PictureBox initPicture, string name, int index)
           {
               Image img = Image.FromFile(Application.StartupPath + @"/" + name + "/" + index + ".png");
               initPicture.Image = img;
               initPicture.SizeMode = PictureBoxSizeMode.StretchImage;
               return initPicture;
           };
        public static Func<PictureBox, string, int, PictureBox> AssigningImageToPBDrinks = delegate (PictureBox initPicture, string name, int index)
        {
            Image img = Image.FromFile(Application.StartupPath + @"/" + name + index + ".png");
            initPicture.Image = img;
            initPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            return initPicture;
        };
        /// <summary>
        /// Returns a pictureBox array, Gets them from bin Application.StartupPath 
        /// </summary>
        public static Func<string ,int, string, Image[]> CampSightImageToPB = delegate (string fileName, int numberOfImages, string fileExtension)
         {
             Image[] ImageArray = new Image[numberOfImages];
             try
             {
                 for (int i = 0; i < numberOfImages; i++)
                 {
                     Image img = Image.FromFile(Application.StartupPath + @"/"+ fileName + i + fileExtension);
                     ImageArray[i] = img;                     
                 }
             }
             catch (Exception)
             {
                 return ImageArray;
             }
             return ImageArray;
         };
    }
}
