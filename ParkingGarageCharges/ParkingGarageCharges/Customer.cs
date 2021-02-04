using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingGarageCharges
{
    class Customer
    {
        const double MinimumCharge = 2.0;
        const double AdditionalCharge = 0.5;
        const double MaximumCharge = 10.0;
        const double MaximumHours = 24;
        const int BaseHours = 3;
        private double _hours;

        public Customer(double hours)
        {
            Hours = hours;
        }
        public double Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 24)
                    throw new Exception("Invalid entry. Please enter a number greater than 0 and less than 25");
                else
                    _hours = value;
            }
        }

        public double CalculateCharges()
        {
            double totalCharge;
            if (Hours <= BaseHours)
                totalCharge = Hours * MinimumCharge;
            else
                totalCharge = MinimumCharge + ((Hours - BaseHours) * AdditionalCharge);
            if (totalCharge > MaximumCharge)
                totalCharge = MaximumCharge;
            return totalCharge;
        }

    }
}
