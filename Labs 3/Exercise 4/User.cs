using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class User
    {
        public User(string name, int age, string phone)
        {
            Name = name;
            Age = age;
            Phone = phone;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nТелефон: {Phone}";
        }
    }

}
