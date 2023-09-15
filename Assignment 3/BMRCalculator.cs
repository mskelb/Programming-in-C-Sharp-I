using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class BMRCalculator
    {
        private UnitTypes gender;
        private double activityLevel;
        private int age; 
        private double weight;
        private double height;
        #region Getters and Setters
        public UnitTypes GetGender()
        {
            return gender;
        }
        public double GetActivityLevel()
        {
            return activityLevel;
        }
        public int GetAge()
        {
            return age;
        }
        
        public double GetHeight()
        {
            return height;    
        }
        public double GetWeight() 
        { 
            return weight;
        }
        public void SetAge(int value)
        {
            age = value;
        }
        public void SetWeight(double value) 
        {
            weight = value; 
        }
        public void SetHeight(double value) 
        { 
            height = value; 
        }
        public void SetGender(UnitTypes value)
        {
            gender = value;
        }
        public void SetActivityLevel(double value)
        {
            activityLevel = value;
        }
        #endregion
        public double CalculateBMR()
        {
            double bmr = (10 * weight) + (6.25 * height) - (5 * age);
            if (this.gender == UnitTypes.Female)
                bmr = bmr - 161;
            else
                bmr = bmr + 5;
            return bmr;
        }
    }
}
