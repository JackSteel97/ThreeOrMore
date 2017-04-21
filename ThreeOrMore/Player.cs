using System;

namespace ThreeOrMore {

    /// <summary>
    /// Class for modeling a player
    /// </summary>
    public class Player {
        private string name;
        private int points;
        private bool aiPlayer;

        /// <summary>
        /// Name of the player
        /// </summary>
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }

        /// <summary>
        /// Current points this player has
        /// </summary>
        public int Points {
            get {
                return this.points;
            }
            set {
                this.points = value;
            }
        }

        /// <summary>
        /// Flag indicating if this player is controlled by the AI
        /// </summary>
        public bool AIPlayer {
            get {
                return this.aiPlayer;
            }
            set {
                this.aiPlayer = value;
            }
        }

        /// <summary>
        /// Construct a new Player object
        /// </summary>
        /// <param name="name">Name of the player</param>
        /// <param name="playerIsAI">flag for making this player AI controlled</param>
        public Player(string name, bool playerIsAI = false) {
            //validate the player's name
            if (name.Length == 0 || name == null) {
                throw new FormatException("Name cannot be empty or null");
            }
            //assign properties
            this.name = name;
            this.aiPlayer = playerIsAI;
        }
    }
}