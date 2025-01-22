using AdvancedC_1.Static_Class;

namespace AdvancedC_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Static Class
			//Concrate Class => Normal Class
			//Abstract Class => Partailly Implementation => Can't Generate Instanse
			//Sealed Class => Stop Inhertace 
			//Partial Class=>
			//Static Class=> Object Member => Class Member 
			//Helpers 

			//Utility U1 = new Utility(5,10);

			//Console.WriteLine(U1.CmToInch(10));

			//Utility U2 = new Utility(8,20);

			//Console.WriteLine(U2.CmToInch(10));

			//Console.WriteLine(Utility.CmToInch(10));

			//Console.WriteLine(Utility.CalcCircleArea(5));
			#endregion

			#region Generics
			//int A = 5; int B = 10;
			//Console.WriteLine($"A:{A}");
			//Console.WriteLine($"B:{B}");
			//Console.WriteLine("=======================================");
			//Helper.Swap(ref A, ref B);//Call know based on Passed Parameter
			//Console.WriteLine($"A:{A}");
			//Console.WriteLine($"B:{B}");
			//Console.WriteLine("=======================================");
			//double A = 5.5; double B = 8.5;
			//Console.WriteLine($"A:{A}");
			//Console.WriteLine($"B:{B}");
			//Console.WriteLine("=======================================");
			//Helper.Swap(ref A, ref B);
			//Console.WriteLine($"A:{A}");
			//Console.WriteLine($"B:{B}");
			//Console.WriteLine("=======================================");
			//Point P01 = new Point(1, 2);
			//Point P02 = new Point(3, 4);
			//Console.WriteLine(P01);
			//Console.WriteLine(P02);
			//Console.WriteLine("=======================================");
			//Helper<Point>.Swap(ref P01, ref P02);
			//Console.WriteLine(P01);
			//Console.WriteLine(P02);
			//Console.WriteLine("=======================================");

			//Helper<int> helper = new Helper<int>();
			#endregion

			#region MyRegion
			//int[] Numbers = { 1, 2, 3 };
			//int Result = Helper.SearchArray(Numbers, 2);//1
			//Console.WriteLine(Result);

			//Employee Emp1 = new Employee(1,"Ahmed",5000);
			//Employee Emp2 = new Employee(1, "Ahmed", 5000);

			//== => ValueType =>operator Overload ==
			//Equals => Value Type => Values
			//== => ReferencType => Address
			//Equals => ReferenceType => Address
			//if(Emp1.Equals(Emp2))
			//{
			//    Console.WriteLine("Equals");
			//}
			//else
			//{
			//    Console.WriteLine("Not Equals");
			//}

			// Employee Emp1 = new Employee(1, "Ahmed", 5000);
			// Employee Emp2 = new Employee(2, "Omar", 9000);
			// Employee Emp3 = new Employee(3, "Ali", 8000);

			// Employee[] employees = { Emp1, Emp2, Emp3 };

			//int Result = Helper<Employee>.SearchArray(employees, Emp3);
			// Console.WriteLine(Result);


			#endregion

			#region Bubble Sort
			//int[] arr = { 3, 6, 2, 5, 7, 8 };
			//Helper<int>.BubbleSort(arr);
			//foreach(int i in arr)
			//{
			//    Console.WriteLine(i);
			//}
			//Employee Emp1 = new Employee(1, "Ahmed", 5000);
			//Employee Emp2 = new Employee(2, "Omar", 9000);
			//Employee Emp3 = new Employee(3, "Ali", 8000);
			//Employee Emp4 = new Employee(4, "Mohamed", 6000);


			//Employee[] employees = { Emp1, Emp2, Emp3,Emp4 };

			//Helper<Employee>.BubbleSort(employees);
			//foreach(Employee employee in employees)
			//{
			//    Console.WriteLine(employee);
			//}

			//Point[] points =
			//{
			//    new Point (4, 5),
			//    new Point (2, 3),
			//    new Point (1, 8),
			//    new Point (3, 7),

			//};
			//Helper<Point>.BubbleSort(points);

			//foreach (Point point in points)
			//    Console.WriteLine(point);
			#endregion

			#region Assignment Solution
			#region Q1
			/*
			 //1- Optimized Bubble Sort
					internal class Helper<T> where T : IComparable<T>
					{
						public static void BubbleSort(T[] arr)
						{
							if (arr is not null)
							{
								for (int i = 0; i < arr.Length; i++)
								{
									bool swapped = false; // Initialize the flag

									for (int j = 0; j < arr.Length - i - 1; j++)
									{
										if (arr[j].CompareTo(arr[j + 1]) > 0)
										{
											Swap(ref arr[j], ref arr[j + 1]);
											swapped = true; // Set the flag if a swap occurs
										}
									}

									// If no swaps occurred, the array is sorted, and we can exit
									if (!swapped)
										break;
								}
							}
						}

						private static void Swap(ref T a, ref T b)
						{
							T temp = a;
							a = b;
							b = temp;
						}
					} 

			*/
			#endregion


			// 2 - Create generic range
			#region Q2
		/*public class Range<T> where T : IComparable<T>
		{
			// Properties to store the minimum and maximum values of the range
			public T Min { get; private set; }
			public T Max { get; private set; }

			// Constructor to define the range
			public Range(T min, T max)
			{
				if (min.CompareTo(max) > 0)
				{
					throw new ArgumentException("Minimum value cannot be greater than the maximum value.");
				}

				Min = min;
				Max = max;
			}

			// Method to check if a value is within the range
			public bool IsInRange(T value)
			{
				return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
			}

			// Method to calculate the length of the range
			public double Length()
			{
				if (typeof(T) == typeof(int))
				{
					return Convert.ToDouble(Max) - Convert.ToDouble(Min);
				}
				else if (typeof(T) == typeof(double) || typeof(T) == typeof(float) || typeof(T) == typeof(decimal))
				{
					return Convert.ToDouble(Max) - Convert.ToDouble(Min);
				}
				else
				{
					throw new InvalidOperationException("Length can only be calculated for numeric types.");
				}
			}*/

			#endregion

			#endregion
		}
	}
}
