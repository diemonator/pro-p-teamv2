using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GeneratorDrinks
    {   //fields
        private static ResizeTimer classTimer;
        //ctor
        public GeneratorDrinks(ListBox lb)
        {
            classTimer = new ResizeTimer(lb);
        }
        //methods
        public Action<string, PictureBox[]> AddPicutureBox = delegate (string name, PictureBox[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                counter++;
                array[i] = Animation.AssigningImageToPB(array[i], name, counter);
            }
        };
        public Action<string, PictureBox[][]> AddPictureBoxToArrays = delegate (string name, PictureBox[][] arrayOfArrays)
          {
              int counter = 0;
              for (int i = 0; i < arrayOfArrays.Length; i++)
              {
                  for (int j = 0; j < arrayOfArrays[i].Length; j++)
                  {
                      counter++;
                      if (name == "drinkDecorator")
                          if (i == 0)
                              arrayOfArrays[i][j] = Animation.AssigningImageToPBDrinks(arrayOfArrays[i][j], name + "/" + "coffie", counter);
                          else if (i == 2)
                              arrayOfArrays[i][j] = Animation.AssigningImageToPBDrinks(arrayOfArrays[i][j], name + "/" + "beer", counter);
                          else if (i == 3)
                              arrayOfArrays[i][j] = Animation.AssigningImageToPBDrinks(arrayOfArrays[i][j], name + "/" + "cola", counter);
                          else if (i == 5)
                              arrayOfArrays[i][j] = Animation.AssigningImageToPBDrinks(arrayOfArrays[i][j], name + "/" + "pepsi", counter);
                          else
                              arrayOfArrays[i][j] = Animation.AssigningImageToPBDrinks(arrayOfArrays[i][j], name + "/" + name, counter);
                      else
                          arrayOfArrays[i][j] = Animation.AssigningImageToPB(arrayOfArrays[i][j], name, counter);
                  }
                  counter = 0;
              }
              counter = 0;
          };

        public static void StartNewAnimation(PictureBox[] arrayToResize)
        {
            foreach (PictureBox iamge in arrayToResize)
            {
                iamge.Enabled = true;
                iamge.Visible = true;
            }
            classTimer.StartTimerButtonAnim(arrayToResize);
        }
        public static void StartSuccessAnim(PictureBox pb, System.Drawing.Image[] frames)
        {
            classTimer.StartTimerSuccessAnim(pb, frames);
        }
        public static void StartMoveAnim(PictureBox[] arrayToResize)
        {
            classTimer.StartTimerResizeAnim(arrayToResize);
        }
    }
}
