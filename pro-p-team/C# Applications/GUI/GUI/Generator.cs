using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public static class Generator
    {
        /// <summary>
        /// Adds PictureBoxes to The Form
        /// </summary>
        /// <param name="counter">px increase from X</param>
        /// <param name="spawnList">list for product that will be created PictureBoxes</param>
        /// <param name="initLocationStartX"> starting location X</param>
        /// <param name="initLocationStartY"> starting location Y</param>
        /// <param name="newIntervalOnY">px for new Line Y</param>
        /// <param name="newIntervalOnX">px for new Line X</param>
        /// <param name="listToPopulateInForm"> list of PictureBox that will be populated</param>
        public static Func<PictureBox[], int, int, int, int, int, int, PictureBox[]> ProtectedDrinkBtnGenerate = delegate (PictureBox[] buttons, int initLocationStartX, int initLocationStartY, int newIntervalOnY, int newIntervalOnX, int width, int height)
        {
            short counter = 0;
            short counterIncrement = 120;
            Point newLocation = new Point(initLocationStartX, initLocationStartY);
            for (short i = 0; i < buttons.Length; i++)
            {
                buttons[i].Size = new Size(width, height);
                buttons[i].BackColor = Color.Transparent;
                buttons[i].Location = new Point(newLocation.X + counter, newLocation.Y);
                if (i == 4)
                {
                    newLocation.X += newLocation.X + counter;
                }
                if (Animation.IsFourth(i))
                {
                    newLocation.Y += newIntervalOnY;
                    newLocation.X = newIntervalOnX;
                    buttons[i].Location = new Point(newLocation.X, newLocation.Y);
                    counter = 0;
                }
                counter += counterIncrement;
            }
            return buttons;
        };
    }

}

