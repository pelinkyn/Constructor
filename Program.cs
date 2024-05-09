using System;

namespace Constructors
{

	class Program
	{  //Sınıfı newlediğimizde  çalışmasını istediğimiz kodlar varsa kodu constructor a yazıyoruz
		static void Main(string[] args)
		{
			Customer customer = new Customer { Id = 1, FirstName = "Pelin", LastName = "Kyn", City = "İzmir" };
			Customer customer2 = new Customer(2, "Derin", "Demirog", "Ankara");
		}
	}
	class Customer
	{
		//default constructor
		public Customer()
		{
			Console.WriteLine("Yapıcı blok çalıştı");

		}
		public Customer(int id, string firstName, string lastName, string city)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			City = city;
		}

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }

	}
}



