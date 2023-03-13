using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    public class Comparable
    {
        public class MaxNumber<T> where T : IComparable
        {
            public static T MaxNumb(T numbOne, T numbTwo, T numbThree)
            {
                if (numbOne.CompareTo(numbTwo) > 0)
                {
                    if (numbOne.CompareTo(numbTwo) > 0) return numbOne;
                    else return numbThree;
                }
                else if (numbTwo.CompareTo(numbThree) > 0) return numbTwo;

                else return numbThree;
            }
        }
    }
}
