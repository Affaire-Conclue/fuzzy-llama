using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fuzzy_llama.Core.Models;

namespace fuzzy_llama.ViewModels
{
    public class User
    {
        public Core.Models.User NewUser { get; set; }
        public IEnumerable<Core.Models.User> AllUsers { get; set; }
    }
}