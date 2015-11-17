using System;
using System.Collections.Generic;
using System.Linq;
using Conventional.Samples.Domain;
using NUnit.Framework;

namespace Conventional.Samples.Tests.Domain
{
    public class DomainConventions
    {
        [Test]
        public void AggregatePropertiesMustHavePrivateSetters()
        {
            AggregateRoots()
                .MustConformTo(Convention.PropertiesMustHavePrivateSetters);
        }

        [Test]
        public void MustInstantiateValueTypesInDefaultConstructor()
        {
            AggregateRoots()
                .MustConformTo(Convention.MustInstantiatePropertiesOfSpecifiedTypeInDefaultConstructor(ValueTypes()));
        }

        [Test]
        public void MustHaveNonPublicDefaultConstructor()
        {
            AggregateRoots()
                .MustConformTo(Convention.MustHaveANonPublicDefaultConstructor);
        }

        private Type[] AggregateRoots()
        {
            return typeof (IAggregateRoot).Assembly.GetExportedTypes()
                .Where(x => typeof (IAggregateRoot).IsAssignableFrom(x) && !x.IsInterface)
                .ToArray();
        }

        private Type[] ValueTypes()
        {
            return typeof(IAggregateRoot).Assembly.GetExportedTypes()
                .Where(x => x.Namespace != null &&  x.Namespace.Equals("Conventional.Samples.Domain.ValueTypes"))
                .ToArray();
        }
    }
}