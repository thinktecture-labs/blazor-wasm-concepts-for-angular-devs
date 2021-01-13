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
            _examplePerson = new Person
            {
                FirstName = "Lando",
                LastName = "Calrissian"
            };

            _fieldnames = _examplePerson.GetType().GetProperties().ToList().Select(p => p.Name);
        }

        private void ChangeFieldValue()
        {
            
            var propertyInfo = _examplePerson.GetType().GetProperty(this._fieldName);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(_examplePerson, _fieldValue);
            }

            Console.WriteLine($"Value of {_fieldName} changed to {_fieldValue}");
        }
    }
}