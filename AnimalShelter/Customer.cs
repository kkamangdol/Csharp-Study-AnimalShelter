using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalShelter
{
    public class Customer
    {
     //private 여기서만 사용하기 public 다른대서도 사용가능 
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
     // private int _Age;
        private bool _IsQualified;
        public string Address;
        public string Description;

        private Cat _MyCat;
        public Cat MyCat
        {
            get { return _MyCat; }
        }
        public bool Adopt(Cat cat)
        {
            if (_IsQualified)
            {
                _MyCat = cat;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public Customer(string firstName, string lastName, DateTime birthday) //int age 제거
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

         // this._IsQualified = age >= 18;
            this._IsQualified = DateTime.Now.Year - birthday.Year >= 18;
        }

/*        public int GetAge()
        {
            return _Age;
        }
        public void SetAge(int age)
        {
            _Age = age;
            _IsQualified = age >= 18;

        }
*/      
        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                _IsQualified = DateTime.Now.Year - value.Year >= 18;
            }
        }
        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
 /*         set 
  *         {
                _Age = value;
                _IsQualified = value >= 18;
            }
*/
        }
        
 /*       public bool GetIsQualified()
        {
            return _IsQualified;
        }
 */
        public bool IsQualified
        {
            get
            {
                return this._IsQualified;
            }
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
} 
