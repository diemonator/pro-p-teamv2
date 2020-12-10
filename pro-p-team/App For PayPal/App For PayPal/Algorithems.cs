using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_For_PayPal
{
    public static class Algorithems
    {
        public static List<string> SplitterToLists(List<string>oldList)
        {
            List<string> temp = new List<string>();
            temp.AddRange(oldList);
            oldList = null;
            oldList = (LeftSpliterToList(temp));
            oldList.AddRange((RightSpliterToList(temp)));
            return oldList;
        }
        private static List<string> LeftSpliterToList(List<string> oldList)
        {
            List<string> passer = new List<string>();
            passer.AddRange(LeftArray(oldList));
            return passer;
        }
        private static List<string> RightSpliterToList(List<string> oldList)
        {
            List<string> passer = new List<string>();
            passer.AddRange(RightArray(oldList));
            return passer;
        }
        private static string[] LeftArray(List<string> oldList)
        {
            string[] leftArray = new string [oldList.Count - 4];
            string[] tempArray = null;
            for (int i = 4; i < oldList.Count; i++)
            {

                tempArray = oldList[i].Split(' ');
                leftArray[i -4] = tempArray[0];
                tempArray = null;

            }
            return leftArray;
        }
        private static string[] RightArray(List<string> oldList)
        {
            string[] rightArray = new string[oldList.Count -4];
            string[] tempArray = null;
            for (int i = 4; i < oldList.Count; i++)
            {

                tempArray = oldList[i].Split(' ');
                rightArray[i - 4] = tempArray[1];
                tempArray = null;


            }
            return rightArray;
        }
        private static bool IsOdd(int i)
        {
            return i % 2 != 0;
        }
        private static bool IsEven(int i)
        {
            return i % 2 == 0;
        }
    }
}
