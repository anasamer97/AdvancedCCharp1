using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_1.Static_Class
{
	internal class Utility
	{
		private const double pi = 5;
		public static double PI { get { return pi; } }
		//Object Member Constructor
		//it's not the right place to Inialize Static Member 

		//Static Constructor => Inialize Static Members
		//Will Be Executed Just only on time per Class LifeTime 
		//1.Call Static Method
		//2.Call Static Property
		//3.Create Object From this Class
		//4.Create Object From Class Inhiert from Class
		static Utility()
		{
		}


		//Object Member
		//Class Member Method
		public static double CmToInch(double cm)
		{
			return cm * 2.54;
		}

		public static double CalcCircleArea(double redius)
		{
			return PI * Math.Pow(redius, 2);//0
		}
	}
}
