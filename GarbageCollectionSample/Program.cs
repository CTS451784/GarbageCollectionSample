using System;

namespace GarbageCollectionSample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			newEmployee (1000000);
			Console.WriteLine ("Memory used before collection" + GC.GetTotalMemory (false));

			GC.Collect ();
			Console.WriteLine ("Memory used after collection " + GC.GetTotalMemory (false));

		 //*****////
			long val1 = GC.GetTotalMemory (false); // Not to wait for garbage collector 
			{
				int[] values = new int[1000000];
				values = null; // Allocating an Array and making itar NotSupportedException reachable
			}
			long val2 = GC.GetTotalMemory (false);
			{
				GC.Collect (); //gets immediate garbage
			}
			long val3 = GC.GetTotalMemory (false);
			{
				Console.WriteLine ("Sample Array checking");
				Console.WriteLine (val1);
				Console.WriteLine (val2);
				Console.WriteLine (val3);


			}

			/*****///
			Console.ReadLine ();
		}
		static void newEmployee(int size)
		{
			Employee e;
			for (int i = 0; i < size; i++) {

				e = new Employee ();
			}

		}
	}
}
