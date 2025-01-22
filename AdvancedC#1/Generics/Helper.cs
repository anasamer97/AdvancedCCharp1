using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_1.Generics
{
    //Generic Class
    internal  class Helper<T> where T:IComparable<T>
    {
        #region Ex1
        //Generic Method 
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        ////Overload
        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref Point P1, ref Point P2)
        //{
        //    Point temp = P1;
        //    P1 = P2;
        //    P2 = temp;
        //}

        //Generic Method
        //T Compiler will know the type of T based on Function Call
        //T Declared on Method Level
        //Class Level /Interface Level /Struct Level
        // static T Hamada;

        public static T Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

            return temp;
        }
        #endregion

        #region Search Array
        public static int SearchArray(T[] arr, T Value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Value.Equals(arr[i]))
                        return i;
                }
            }
            return -1;
        }
        #endregion

        #region BubbleSort
        public static void BubbleSort(T[] arr)
        {
            if(arr is not null)
            {
                for(int i = 0;i < arr.Length;i++)//2
                {
                    for(int j=0;j<arr.Length -i -1;j++)//0 Length = 6 -3 =3
                    {
                        if (arr[j].CompareTo(arr[j+1])==1)
                            Swap(ref arr[j],ref arr[j+1]);
                    }
                }
            }
        }

        #endregion
    }
}
