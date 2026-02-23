using System;
using System.Collections.Generic;
using System.Text;

namespace ProviderOptimizer.Domain
{
    internal class Provider
    {
        public Guid Id { get; private set; }
        public double DistanceKm { get; private set; }
        public double Rating { get; private set; }
        public bool IsBusy { get; private set; }

        // Concurrency Token (optimistic locking)
        public byte[] RowVersion { get; private set; }

        public Provider(Guid id, double distanceKm, double rating)
        {
            Id = id;
            DistanceKm = distanceKm;
            Rating = rating;
            IsBusy = false;
        }

        public void Assign()
        {
            if (IsBusy)
                throw new InvalidOperationException("Provider already assigned");

            IsBusy = true;
        }
    }
}
