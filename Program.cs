using System;
using System.Collections.Generic;

namespace ElectricInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio aRadio = new Radio();
            Radio anotherRadio = new Radio();
            AllInOne anAllInOne = new AllInOne();
            AllInOne anotherAllInOne = new AllInOne();

            List<IRadio> iradioList = new List<IRadio>() {
                aRadio, anotherAllInOne, anotherRadio, anAllInOne
            };

            TestRadios(iradioList); 

        }
        static void TestRadios(List<IRadio> radios) { //all we care about here is the ability to turn on/off
            foreach (IRadio radio in radios)
            {
                radio.TurnRadioOn();
                radio.TurnRadioOff();
            }
        }
    }
}
