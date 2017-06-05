using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
	class Staff
	{
		private string staffName;
		private const int hourlyRate = 30;
		private int hoursWorked;

		public Staff(string staffName)
		{
			this.staffName = staffName;
			Console.WriteLine("\n" + staffName);
			Console.WriteLine("------------------------------------");
		}

		public Staff(string firstName, string lastName)
		{
			this.staffName = firstName + " " + lastName;
			Console.WriteLine("\n" + staffName);
		}

//		public int HoursWorked { get; set; }
		public int HoursWorked
		{
			get
			{
				return hoursWorked;
			}
			set
			{
				hoursWorked = value > 0 ? value : 0;
			}
		}

		public void PrintMessage()
		{
			Console.WriteLine("Calculating Pay ...");
		}

		public int CalculatePay()
		{
			PrintMessage();
			int staffPay = hoursWorked * hourlyRate;

			return staffPay > 0 ? staffPay : 0;
		}

		public int CalculatePay(int bonus, int allowance)
		{
			PrintMessage();
			if (hoursWorked > 0)
			{
				return hoursWorked * hourlyRate + bonus + allowance;
			}
			return 0;
		}

		public override string ToString()
		{
			return "Staff Name: " + staffName +
			       ", Hourly Rate: " + hourlyRate +
			       ", Hours Worked: " + hoursWorked;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int pay;
			Staff staff1 = new Staff("Peter");
			staff1.HoursWorked = 160;

			pay = staff1.CalculatePay(1000, 400);
			Console.WriteLine(staff1.ToString());
			Console.WriteLine("Pay is {0}", pay);
			Console.Read();
		}
	}
}
