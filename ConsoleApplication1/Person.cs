using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {

        private String name;
        private String surname;

        public Person(string name, string surname) {
            this.name = name;
            this.surname = surname;
        }

        public void setName(string name){
            this.name = name;
        }

        public void setName(string surname)
        {
            this.surname = surname;
        }

        public string getName() {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

    }
}
