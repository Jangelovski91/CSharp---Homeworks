using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Homework
{
	public class Person
	{
		public Person(string firstName, string lastName, int age, char gender)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = Gender;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public char Gender { get; set; }

	}
	class Program
	{
		static void Main(string[] args)
		{

			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			Console.WriteLine("-----Task 01-----------------------------------");
			// all people aged 50 or more

			List<Person> greaterThan50 = people
											.Where(human => human.Age >= 50)
											.ToList();
			greaterThan50.ForEach(human => Console.WriteLine($"Person {human.FirstName} is {human.Age} years old."));
			Console.WriteLine("-----Task 02-----------------------------------");
			// all people name starts with B
			List<Person> nameStartsWithB = people
											.Where(human => human.FirstName.StartsWith("B"))
											.ToList();
			nameStartsWithB.ForEach(human => Console.WriteLine($"Person name is {human.FirstName}."));
			Console.WriteLine("-----Task 03-----------------------------------");
			// first person whose surname starts with T
			List<Person> lastNameStartsWithT = people
											.Where(human => human.LastName.StartsWith("T"))
											.ToList();
			lastNameStartsWithT.ForEach(human => Console.WriteLine($"Person  lastname is {human.LastName}."));
			Console.WriteLine("-----Task 04-----------------------------------");
			// find youngest and oldest person
			Person youngestPerson = people.OrderBy(human => human.Age).First();
			Person oldestPerson = people.OrderBy(human => human.Age).Last();
			Console.WriteLine($"The youngest person is {youngestPerson.FirstName} with {youngestPerson.Age} years, and the oldest is {oldestPerson.FirstName} with {oldestPerson.Age} years. ");
			Console.WriteLine("-----Task 05-----------------------------------");
			// find all male people aged 45 or more
			List<Person> maleOlderThan45 = people
											.Where(human => human.Gender == 'M')
											.Where(human => human.Age >= 45)
											.ToList();
			maleOlderThan45.ForEach(human => Console.WriteLine($"Person {human.FirstName} is {human.Age} years old."));
			Console.WriteLine("-----Task 06-----------------------------------");
			// find all females whose name starts with V
			List<Person> femaleStartsWithV = people
											.Where(human => human.Gender == 'F')
											.Where(human => human.LastName.StartsWith("V"))
											.ToList();
			femaleStartsWithV.ForEach(human => Console.WriteLine(human.FirstName));
			Console.WriteLine("-----Task 07-----------------------------------");
			// find last female person older than 30 whose name starts with P
			Person lastFemaleOver30StartsWithP = people
													.Where(human => human.Gender == 'F')
													.Where(human => human.FirstName.StartsWith("P"))
													.Where(human => human.Age > 30)
													.LastOrDefault();
			Console.WriteLine(lastFemaleOver30StartsWithP == null ? "no person found!" : lastFemaleOver30StartsWithP.FirstName);


			Console.WriteLine("-----Task 08-----------------------------------");
			// find first male younger than 40
			Person firstMaleYoungerThan40 = people
												.Where(human => human.Gender == 'M')
												.Where(human => human.Age < 40)
												.FirstOrDefault();
			Console.WriteLine(firstMaleYoungerThan40 == null ? "no person found!" : firstMaleYoungerThan40.FirstName);
			Console.WriteLine("-----Task 09-----------------------------------");
			// print the names of the male persons that have firstName longer than lastName
			List<Person> nameLongerThanLastname = people
													.Where(human => human.Gender == 'M')
													.Where(human => human.FirstName.Length > human.LastName.Length)
													.ToList();
			nameLongerThanLastname.ForEach(human => Console.WriteLine(human.FirstName, human.LastName));
													
			Console.WriteLine("-----Task 10-----------------------------------");
			// print the lastNames of the female persons that have odd number of ages
			List<Person> femaleOddNumber = people
												.Where(human => human.Gender == 'F')
												.Where(human => human.Age % 2 != 0)
												.ToList();
			femaleOddNumber.ForEach(human => Console.WriteLine(human.FirstName));



			Console.ReadLine();
		}

	}
}
