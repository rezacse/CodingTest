using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCoding.Validation.Infrastructure
{
    public class Predicate<T> : Specification<T>
    {
        public Func<T, bool> Delegate { get; }

        public Predicate(Func<T, bool> predicate)
        {
            this.Delegate = predicate;
        }

        public override bool IsSatisfiedBy(T obj)
            => this.Delegate(obj);

    }
}
