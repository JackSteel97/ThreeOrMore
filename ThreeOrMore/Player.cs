using System;


namespace ThreeOrMore{
   public class Player {
        private string name;
        private int points;
        private bool aiPlayer;
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
            
        }
        public int Points {
            get {
                return this.points;
            }
            set {
                this.points = value;
            }
        }
        public bool AIPlayer {
            get {
                return this.aiPlayer;
            }
            set {
                this.aiPlayer = value;
            }
        }

        

        public Player(string name, bool playerIsAI = false) {
            if (name.Length == 0 || name == null) {
                throw new FormatException("Name cannot be empty or null");
            }
            this.name = name;
            this.aiPlayer = playerIsAI;
        }
    }
}
