using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    // Purpose: 
    // Input: height, weight, unit 
    // Output:
    /* 
    BMI = weight in kg / (height * height in m2) (Metric Units)
    BMI = 703.0 *·weight in lb / (height * height in inch2) (Imperial (U.S.) Units)
     */
    class BMICalculator
    {
        private double height;
        private double weight;
        private UnitTypes unit;

        public BMICalculator()
        {
            unit = UnitTypes.Metric;
        }
        #region Getters and Setters 
        // setters and getters 
        public double GetHeight()
        {
            return height;
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetHeight(double h)
        {
            if (h >= 0.0)
                this.height = h;
        }
        public void SetWeight(double w)
        {
            if (w >= 0.0)
                this.weight = w;
        }
        public UnitTypes GetUnitType()
        {
            return unit;
        }
        public void SetUnitType(UnitTypes type)
        {
            this.unit = type;
        }
        #endregion
        //Calculation 
   
        public string WeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;
            if (bmi < 18.5)
                stringout = "Underweight";
            else if (bmi <= 24.9)
                stringout = "Normal weight";
            else if (bmi <= 29.9)
                stringout = "Overweight (Pre-obesity)";
            else if (bmi <= 34.9)
                stringout = "Overweight (Obesity class I)";
            else if (bmi <= 39.9)
                stringout = "Overweight (Obesity class II)";
            else
                stringout = "Overweight (Obesity class III)";

            return stringout;
        }
        public double CalculateBMI()
        {
            double bmiValue = 0.0;
            double factor = 1.0;

            if (this.unit == UnitTypes.Imperial)
            {
                factor = 703.0;
            }
            bmiValue = (factor * weight) / (height * height);

            return bmiValue;
        }
    }
}
