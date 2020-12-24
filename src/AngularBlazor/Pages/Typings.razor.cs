using System;
using System.Collections.Generic;
using System.Linq;

namespace AngularBlazor.Pages
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public partial class Typings
    {
        private readonly Person _examplePerson;
        private string _fieldName = "FirstName";
        private string _fieldValue;
        private IEnumerable<string> _fieldnames;
        
        public Typings()
        {
            var firstPerson = new Person
            {
                FirstName = "Leia",
                LastName = "Organa"
            };

            Console.WriteLine($"Hello {firstPerson.FirstName} {firstPerson.LastName}");

            dynamic secondPerson = new {FirstName = "Luke", LastName = "Skywalker"};
            Console.WriteLine($"Hello {secondPerson.FirstName} {secondPerson.LastName}");

            // NOT WORKING
            // secondPerson["FirstName"] = "Han";
            // secondPerson["LastName"] = "Solo";

            // Console.WriteLine($"Hello {secondPerson.FirstName} {secondPerson.LastName}");
            
            // Only works for objects that are typed. NOT for dynamics
            firstPerson.GetType().GetProperty("FirstName")?.SetValue(firstPerson, "Han");
            firstPerson.GetType().GetProperty("LastName")?.SetValue(firstPerson, "Solo");
            
            Console.WriteLine($"Hello {firstPerson.FirstName} {firstPerson.LastName}");

            _examplePerson = new Person
            {
                FirstName = "Lando",
                LastName = "Calrissian"
            };

            _fieldnames = _examplePerson.GetType().GetProperties().ToList().Select(p => p.Name);
        }

        private void ChangeFieldValue()
        {
            var propertyInfo =_examplePerson.GetType().GetProperty(this._fieldName);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(_examplePerson, _fieldValue);
            }
            Console.WriteLine($"Value of {_fieldName} changed to {_fieldValue}");
        }
    }
}