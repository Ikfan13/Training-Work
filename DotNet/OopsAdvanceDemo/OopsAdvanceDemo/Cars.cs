using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAdvanceDemo
{
    abstract class Cars
    {
        public string brand;
        public string model;

        public abstract string getCarDetails();
    }

    class BMW : Cars
    {
        public string specialfeatures;

        public override string getCarDetails()
        {
            return  this.brand + " launched  a  " + this.model + " with new features "+ this.specialfeatures;
        }
    }

    class Mercedez:Cars
    {
        public string mileage;
        public override string getCarDetails() {
            return this.brand + " launched  a  " + this.model + " with new mileage of " + this.mileage;


        }
    }
}
