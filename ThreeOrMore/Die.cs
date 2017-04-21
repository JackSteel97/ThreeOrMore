using System;

namespace ThreeOrMore {

    /// <summary>
    /// Class modeling a numbered die
    /// </summary>
    internal class Die : ICloneable {
        private int value;
        private bool rolled;
        private int numberOfFaces;

        /// <summary>
        /// The number on the 'top' face of the die
        /// </summary>
        public int Value {
            get {
                if (this.rolled) {
                    return this.value;
                } else {
                    throw new InvalidOperationException("Die must be rolled first.");
                }
            }
            set {
                this.value = value;
            }
        }

        /// <summary>
        /// indicates the current state of the die as rolled or not
        /// </summary>
        public bool Rolled {
            get {
                return this.rolled;
            }
            set {
                this.rolled = value;
            }
        }

        /// <summary>
        /// number of faces on this die
        /// </summary>
        public int NumberOfFaces {
            get {
                return this.numberOfFaces;
            }
            set {
                this.numberOfFaces = value;
            }
        }

        /// <summary>
        /// constructor to create a new die object
        /// </summary>
        /// <param name="numberOfFaces">max number that can be rolled</param>
        public Die(int numberOfFaces) {
            //assign properties
            this.numberOfFaces = numberOfFaces;
            this.rolled = false;
            this.value = 1;
        }

        /// <summary>
        /// roll the die
        /// </summary>
        /// <returns>A random value between 1 and the number of faces on this die</returns>
        public virtual int roll() {
            //ensure the die has not been rolled yet first
            if (!this.rolled) {
                //generate a random number between 1 and numberOfFaces
                Random rnd = new Random();
                int rolledNum = rnd.Next(1, this.numberOfFaces + 1);
                //set properties
                this.value = rolledNum;
                this.rolled = true;
                //return the random number
                return rolledNum;
            }
            throw new InvalidOperationException("Die has been rolled.");
        }

        /// <summary>
        /// Implements ICloneable to avoid deep cloned references
        /// </summary>
        /// <returns>A shallow copy of this object</returns>
        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}