using System;
using System.Collections.Generic;
using System.Dynamic;
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
        private readonly dynamic _expandoPerson;
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

            _expandoPerson = new ExpandoObject();
            _expandoPerson.FirstName = "Luke";
            _expandoPerson.LastName = "Skywalker";
        }

        private void ChangeFieldValue()
        {
            
            var propertyInfo = _examplePerson.GetType().GetProperty(_fieldName);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(_examplePerson, _fieldValue);
            }

            ((IDictionary<string,object>)_expandoPerson)[_fieldName] = _fieldValue;

            Console.WriteLine($"Value of {_fieldName} changed to {_fieldValue}");
        }
    }
}