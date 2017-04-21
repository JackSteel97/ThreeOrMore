using System;
using System.Timers;
using System.Windows.Forms;
using ThreeOrMore.Properties;

namespace ThreeOrMore {

    /// <summary>
    /// Class for a Die with a UI component, extends the ThreeOrMore.Die Class
    /// </summary>
    internal class UIDie : Die {

        //callback for when the die finishes rolling
        private Action dieFinishedCallback;

        private PictureBox dieImage;

        /// <summary>
        /// PictureBox used to display the value of this die
        /// </summary>
        public PictureBox DieImage {
            get {
                return this.dieImage;
            }
            set {
                this.dieImage = value;
            }
        }

        //random number used to determine how long the die rolls for
        private int countFrom;

        ///timer for handling rolling
        private System.Timers.Timer dieTimer;

        private int intermediateValue;
        private bool rolling = false;

        /// <summary>
        /// Flag indicating if the die is currently rolling
        /// </summary>
        public bool Rolling {
            get {
                return this.rolling;
            }
        }

        /// <summary>
        /// Construct a new UIDie object
        /// </summary>
        /// <param name="numberOfFaces">Max value for this die</param>
        /// <param name="dieImage">picturebox to display the die value image</param>
        public UIDie(int numberOfFaces, PictureBox dieImage) : base(numberOfFaces) {
            //assign properties
            this.dieImage = dieImage;
        }

        /// <summary>
        /// Roll this die asynchronously
        /// </summary>
        /// <param name="callback">Method to call when the die finishes rolling</param>
        public void roll(Action callback) {
            //if already rolling, do nothing
            if (rolling) {
                return;
            }
            //ensure the die hasn't been rolled already
            if (!Rolled) {
                //generate a random number from 20 to 80
                Random rnd = new Random();
                this.countFrom = rnd.Next(20, 81);
                //assign the callback method
                this.dieFinishedCallback = callback;
                //instantiate a new timer
                dieTimer = new System.Timers.Timer();
                //enable the timer
                dieTimer.Enabled = true;
                //set the timer interval to 25ms
                dieTimer.Interval = 25;
                //assign an event handler to the timer
                dieTimer.Elapsed += new ElapsedEventHandler(TimerTick);
                //start the timer
                dieTimer.Start();
                //set the rolling flag to true
                rolling = true;
                return;
            }
            throw new InvalidOperationException("Die has been rolled.");
        }

        /// <summary>
        /// Set the die image to a specific value
        /// </summary>
        /// <param name="value">A value from 1 to 20</param>
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

        /// <summary>
        /// Called when the timer ticks
        /// </summary>
        private void TimerTick(object source, ElapsedEventArgs e) {
            //decrement the counter
            countFrom -= 1;
            //increment the interval to simulate slowing down of die
            dieTimer.Interval += 1;

            //is the counter still above zero?
            if (countFrom > 0) {
                //yes, generate a new random number from 1 to numberOfFaces
                Random rnd = new Random();
                intermediateValue = rnd.Next(1, NumberOfFaces + 1);
                //update the die image
                setDieImage(intermediateValue);
            } else {
                //no, the die has stopped. Disable the timer
                dieTimer.Enabled = false;
                dieTimer.Stop();
                //set the final value of the die
                Value = intermediateValue;
                //visually disable the die
                this.dieImage.BackColor = System.Drawing.Color.DimGray;
                //set flags accordingly
                rolling = false;
                Rolled = true;
                //call the callback method
                dieFinishedCallback();
            }
        }
    }
}