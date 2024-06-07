using SudPR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudPR.IModels
{
    public interface IAccount
    {
        int Id { get; set; }
        string Login { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string PhoneNumber { get; set; }
        Role Role { get; }
    }
}
