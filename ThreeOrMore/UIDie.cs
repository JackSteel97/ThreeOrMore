using System;
using System.Timers;
using System.Windows.Forms;
using ThreeOrMore.Properties;

namespace ThreeOrMore {
   class UIDie : Die {

        private PictureBox dieImage;
        private int countFrom;
        private System.Timers.Timer dieTimer;
        private int intermediateValue;

        public UIDie(int numberOfFaces, PictureBox dieImage) : base(numberOfFaces) {
            this.dieImage = dieImage;
        }

        public override int roll() {
            if (!this.Rolled) {
                Random rnd = new Random();
                this.countFrom = rnd.Next(20, 80);

                dieTimer = new System.Timers.Timer();
                dieTimer.Enabled = true;
                dieTimer.Interval = 25;
                dieTimer.Elapsed += new ElapsedEventHandler(TimerTick);
                dieTimer.Start();
                return -1;
            }
            throw new InvalidOperationException("Die must be rolled first");
        }
        
        private void TimerTick(object source, ElapsedEventArgs e) {
            countFrom -= 1;
            dieTimer.Interval += 1;

            if (countFrom > 0){
                Random rnd = new Random();
                intermediateValue = rnd.Next(1, NumberOfFaces);
                switch (intermediateValue) {
                    case 1:
                        dieImage.Image = Resources.Die1;
                        break;
                    case 2:
                        dieImage.Image = Resources.Die2;
                        break;
                    case 3:
                        dieImage.Image = Resources.Die3;
                        break;
                    case 4:
                        dieImage.Image = Resources.Die4;
                        break;
                    case 5:
                        dieImage.Image = Resources.Die5;
                        break;
                    case 6:
                        dieImage.Image = Resources.Die6;
                        break;
                    default:
                        dieImage.Image = Resources.Die6;
                        break;
                }
            }else {
                dieTimer.Enabled = false;
                dieTimer.Stop();
                Value = intermediateValue;
                Rolled = true;
            }

        }
    }
}
