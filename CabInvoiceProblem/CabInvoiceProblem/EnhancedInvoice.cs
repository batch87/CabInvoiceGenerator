﻿namespace CabInvoiceProblem
{
    public class EnhancedInvoice
    {
        public EnhancedInvoice(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFarePerRide = totalFare / numberOfRides;
        }

        public int numberOfRides { get; }
        public double totalFare { get; }
        public double averageFarePerRide { get; }
    }
}

