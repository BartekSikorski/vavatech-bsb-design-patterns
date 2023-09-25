using System;

namespace PrototypePattern
{
    public class Customer : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public Address ShippingAddress { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public object Clone()
        {
            // return new Customer(FirstName, LastName);

            return this.MemberwiseClone();  // Płytka kopia (Shallow Copy)


            // Głęboka kopia (Deep Copy)
            // https://github.com/ReubenBond/DeepCopy
            // https://github.com/AlenToma/FastDeepCloner
        }
    }

    public class Address
    {
        public string City { get; set; }
    }

}
