using System;
using System.Timers;
using System.Windows.Forms;
using ThreeOrMore.Properties;

namespace ThreeOrMore {

    internal class UIDie : Die {
        private Action dieFinishedCallback;
        private PictureBox dieImage;

        public PictureBox DieImage {
            get {
                return this.dieImage;
            }
            set {
                this.dieImage = value;
            }
        }

        private int countFrom;
        private System.Timers.Timer dieTimer;
        private int intermediateValue;
        private bool rolling = false;
        public bool Rolling {
            get {
                return this.rolling;
            }
        }

        public UIDie(int numberOfFaces, PictureBox dieImage) : base(numberOfFaces) {
            this.dieImage = dieImage;
        }

        public int roll(Action callback) {
            if (rolling) {
                return -2;
            }
            if (!Rolled) {
                Random rnd = new Random();
                this.countFrom = rnd.Next(20, 81);
                this.dieFinishedCallback = callback;
                dieTimer = new System.Timers.Timer();
                dieTimer.Enabled = true;
                dieTimer.Interval = 25;
                dieTimer.Elapsed += new ElapsedEventHandler(TimerTick);
                dieTimer.Start();
                rolling = true;
                return -1;
            }
            throw new InvalidOperationException("Die has been rolled.");
        }
        private void setDieImage(int value) {
            switch (value) {
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
                case 7:
                    dieImage.Image = Resources.Die7;
                    break;
                case 8:
                    dieImage.Image = Resources.Die8;
                    break;
                case 9:
                    dieImage.Image = Resources.Die9;
                    break;
                case 10:
                    dieImage.Image = Resources.die10;
                    break;
                case 11:
                    dieImage.Image = Resources.die11;
                    break;
                case 12:
                    dieImage.Image = Resources.die12;
                    break;
                case 13:
                    dieImage.Image = Resources.die13;
                    break;
                case 14:
                    dieImage.Image = Resources.die14;
                    break;
                case 15:
                    dieImage.Image = Resources.die15;
                    break;
                case 16:
                    dieImage.Image = Resources.die16;
                    break;
                case 17:
                    dieImage.Image = Resources.die17;
                    break;
                case 18:
                    dieImage.Image = Resources.die18;
                    break;
                case 19:
                    dieImage.Image = Resources.die19;
                    break;
                case 20:
                    dieImage.Image = Resources.die20;
                    break;
                default:
                    dieImage.Image = Resources.Die1;
                    break;
            }
       } 
        private void TimerTick(object source, ElapsedEventArgs e) {
            countFrom -= 1;
            dieTimer.Interval += 1;
            
            if (countFrom > 0) {
                Random rnd = new Random();
                intermediateValue = rnd.Next(1, NumberOfFaces + 1);
                setDieImage(intermediateValue);
                
            } else {
                dieTimer.Enabled = false;
                dieTimer.Stop();
                Value = intermediateValue;
                this.dieImage.BackColor = System.Drawing.Color.DimGray;
                rolling = false;
                Rolled = true;
                dieFinishedCallback();
            }
        }
    }
}