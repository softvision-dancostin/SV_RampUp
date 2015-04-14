using System;
using System.Windows.Forms;

namespace CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar()
        {
        }

        public SportsCar(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp)
        {
        }

        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed!", "Faster is better...");
        }
    }
}
