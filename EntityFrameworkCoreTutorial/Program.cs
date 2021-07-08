using System;
using System.Linq;
using EntityFrameworkCoreTutorial.Models;

namespace EntityFrameworkCoreTutorial {
    class Program {
        static void Main(string[] args) {

            var _context = new salesdbContext();

            var customers = _context.Customers
                                    .Where(c => c.City == "Cincinnati" && c.Sales >= 50000)
                                    .OrderByDescending(c => c.Name)
                                    .ToList();

            foreach (var c in customers) {
                Console.WriteLine($"{c.Name}|{c.City}|{c.State}|{c.Sales}");
            }



        }
    }
}
