using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTestOrm
{
    internal class Cats { }

    //public class Cat(string? NameCat, Owner? Owner, ISet<Exposition>? Expositions)
    // public record Cat(string? NameCat, Owner? Owner, Exposition Expositions);
    public record Cat(string? NameCat, Owner? Owner, ISet<Exposition>? Expositions)
    {
        public ISet<Exposition> Expositions { get; set; }
        public Owner Owner { get; set; }
        public Cat() : this(default, default, default) { }
    };
    //{
    //    public string? NameCat { get; set; } = NameCat;
    //    public Owner? Owner { get; set; } = Owner;
    //    public ISet<Exposition>? Expositions { get; set; } = Expositions;
    //}
    public record Owner(string NameOvner, ISet<Cat> Cats)
    {
        public Owner() : this(default, default) { }
    };
    public record Exposition(string DateExpo, string Country, string City, ISet<Cat> Cats)
    {
        public ISet<Cat> Cats { get; set; }
        public Exposition() : this(default, default, default, default) { }

    };

    public class ExpositionReportItemDTO
    {
        public string DateExpo { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Cat { get; set; }
        public string Owner { get; set; }
    }
}
