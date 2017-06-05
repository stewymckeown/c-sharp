using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Member
	{
		protected int annualFee;
		private string name;
		private int memberId;
		private int memberSince;

		public Member()
		{
			Console.WriteLine("Parent no-arg constructor");
		}

		public Member(string pName, int pMemberId, int pMemberSince)
		{
			Console.WriteLine("Parent 3 arg constructor");

			name = pName;
			memberId = pMemberId;
			memberSince = pMemberSince;
		}

		public override string ToString()
		{
			return "Name: " + name + 
				"\nMember Id: " + memberId + 
				"\nMember Since: " + memberSince + 
				"\nTotal Annual Fee: " +  annualFee; 
		}
	}

	class NormalMember : Member
	{
		public NormalMember()
		{
			Console.WriteLine("Normal Member no-arg constructor");
		}	

		public NormalMember (string remarks, string name, int memberId, int memberSince) : base(name, memberId, memberSince)
		{
			Console.WriteLine("Normal Member 4 arg constructor");
			Console.WriteLine("Remarks = {0}", remarks);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			NormalMember normalMember = new NormalMember("Normal Member", "Test Member", 1, 2017);
			Console.ReadLine();
		}
	}
}
