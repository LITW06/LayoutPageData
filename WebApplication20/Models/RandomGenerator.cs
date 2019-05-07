using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker;

namespace WebApplication20.Models
{
    public static class RandomGenerator
    {
        public static string GetRandomName()
        {
            return Name.FullName();
        }
    }
}
