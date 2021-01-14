using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("please enter your age bellow:");
		String UserAge = Console.In.ReadLine();
		int UserAgeToInt = int.Parse(UserAge);
		int CurrentYear = 2021;
		int Result = CurrentYear - UserAgeToInt;
		Console.WriteLine("Your Year Of Birth is : " + Result);
		
		
	}
}
