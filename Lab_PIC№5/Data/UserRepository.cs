using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Data
{
    class UserRepository
    {
        public static List<Role> Rols = new List<Role>
                                    { new Role("Операто по отлову", new Dictionary<string, bool>()
                                                                    {
                                                                        {"Act", true},
                                                                        {"App", false},
                                                                        {"Con", false},
                                                                        {"Org", false}
                                                                    }),
                                      new Role("Операто ОМСУ", new Dictionary<string, bool>()
                                                                    {
                                                                        {"Act", false},
                                                                        {"App", true},
                                                                        {"Con", true},
                                                                        {"Org", true}
                                                                    })
                                     };

        public static List<User> Users = new List<User>
                                    {
                                        new User(1, "User1", "1", Rols[0]),
                                        new User(1, "User2", "2", Rols[1])
                                    };
    };
}
   
