using System;
using System.Windows.Forms;

namespace CarLibrary
{
    public class MiniVan : Car
    {
        public MiniVan()
        {
        }

        public MiniVan(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp)
        {
        }

        public override void TurboBoost()
        {
            // Minivans have poor turbo capabilities!
            egnState = EngineState.engineDead;
            MessageBox.Show("Eek!", "Your engine block exploded!");
        }

        public void TurnOnRadio(bool musicOn, MusicMedia mm)
        {
            if (musicOn)
                MessageBox.Show(string.Format("Jamming {0}", mm));
            else
                MessageBox.Show("Quiet time...");
        }
    }
}
