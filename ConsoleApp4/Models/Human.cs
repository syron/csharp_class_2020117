using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    
    public interface ISpecies
    {
        void Move(int x, int y);
    }

    public abstract class Species : ISpecies
    {
        public string Name { get; set; }

        public abstract void Move(int x, int y);
    }

    public class Dog : Species
    {
        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Move(int x, int y, int z)
        {

        }
    }

    public class Cat : Species
    {
        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    public class Human : Species
    {
        public string Name { get; set; }
        public bool IsHungry { get; set; }
        public string InsuranceNumber { get; set; }
        public bool EatsWithHands { get; set; }

        public override string ToString()
        {
            
            return $"{base.ToString()}: {Name}";
        }

        public virtual void Eat()
        {
            EatsWithHands = false;
        }

        public override void Move(int x, int y)
        {
            
        }
    }


    public sealed class MyDearChild : Human
    {
        public override void Eat()
        {
            EatsWithHands = true;
        }
    }

    public class MyDearRobert : Human
    {
        public override void Eat()
        {
            EatsWithHands = true;
        }
    }


}
