using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test
{
    class EmployDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }

        public string Login(string UserId, string password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(password))
            {
                return "Userid or password could not be Empty.";
            }
            else
            {
                if (UserId == "Admin" && password == "Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }
        public List<EmployDetails> AllUsers()
        {
            List<EmployDetails> li = new List<EmployDetails>();
            li.Add(new EmployDetails
            {
                Id = 100,
                Name = "Bharat",
                Gender = "Male",
                Salary = 67000
            });
            return li;
        }
        public List<EmployDetails> GetDetails(int id)
        {
            List<EmployDetails> li1 = new List<EmployDetails>();
            var li = new EmployDetails().AllUsers();
            foreach (var x in li)
            {
                if (x.Id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
    }
    
}
