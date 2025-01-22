using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_1.Generics
{
	internal class Point : IComparable<Point>
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
		public override string ToString()
		{
			return $"({X},{Y})";
		}
		public override bool Equals(object? obj)
		{
			return base.Equals(obj);
		}

		//public int CompareTo(object? obj)

		public int CompareTo(Point? other)
		{
			if (this.X == other.X)
			{//int => Compare
				return this.Y.CompareTo(other.Y);
			}
			else
			{
				return this.X.CompareTo(other.X);
			}
		}
		//Point point = (Point)obj;//UnSafe Excplicit Casting

		//Is Conditional Operator
		//1)Obj Point
		//2)obj Inherit Point 
		//3)Obj NUll
		//if(obj is Point PassedPoint)
		//{
		//    if(PassedPoint == null)
		//    {
		//        return 1;
		//    }

		//    if(this.X == PassedPoint.X)
		//    {//int => Compare
		//        return this.Y.CompareTo(PassedPoint.Y);
		//    }
		//    else
		//    {
		//        return this.X.CompareTo(PassedPoint.X);
		//    }
		//}

		////as Casting Operator
		//Point passedPoint = obj as Point;   //Casting will Success if OBj is point
		//                                    //if casting Faild will  return null => Zero Exception
		//if (passedPoint == null)
		//{
		//    return 1;
		//}

		//if (this.X == passedPoint.X)
		//{//int => Compare
		//    return this.Y.CompareTo(passedPoint.Y);
		//}
		//else
		//{
		//    return this.X.CompareTo(passedPoint.X);
		//}
	}
}