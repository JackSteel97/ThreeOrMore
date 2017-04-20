using System;

namespace ThreeOrMore {

    internal class Die : ICloneable {
        private int value;
        private bool rolled;
        private int numberOfFaces;

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

        public bool Rolled {
            get {
                return this.rolled;
            }
            set {
                this.rolled = value;
            }
        }

        public int NumberOfFaces {
            get {
                return this.numberOfFaces;
            }
            set {
                this.numberOfFaces = value;
            }
        }

        public Die(int numberOfFaces) {
            this.numberOfFaces = numberOfFaces;
            this.rolled = false;
            this.value = 1;
        }

        public virtual int roll() {
            if (!this.rolled) {
                Random rnd = new Random();
                int rolledNum = rnd.Next(1, this.numberOfFaces + 1);
                this.value = rolledNum;
                this.rolled = true;
                return rolledNum;
            }
            throw new InvalidOperationException("Die has been rolled.");
        }

        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}