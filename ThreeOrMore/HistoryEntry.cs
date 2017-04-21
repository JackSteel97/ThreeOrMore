using System;

namespace ThreeOrMore {

    /// <summary>
    /// Class for encapsulating data relating to a History entry of the game
    /// </summary>
    internal class HistoryEntry {
        private int turnNumber;
        private Player activePlayer;
        private Die[] dice;
        private string notes;

        /// <summary>
        /// The turn number
        /// </summary>
        public int TurnNumber {
            get {
                return this.turnNumber;
            }
        }

        /// <summary>
        /// The Player whose turn it was
        /// </summary>
        public Player ActivePlayer {
            get {
                return this.activePlayer;
            }
        }

        /// <summary>
        /// The state of the dice at the end of this turn
        /// </summary>
        public Die[] Dice {
            get {
                return this.dice;
            }
        }

        /// <summary>
        /// Textual notes relating to this turn
        /// </summary>
        public string Notes {
            get {
                return this.notes;
            }
        }

        /// <summary>
        /// Constructs a new HistoryEntry object
        /// </summary>
        /// <param name="turnNumber">Current turn number</param>
        /// <param name="activePlayer">Player whose turn it is</param>
        /// <param name="dice">Current state of the dice</param>
        /// <param name="notes">Textual notes</param>
        public HistoryEntry(int turnNumber, Player activePlayer, Die[] dice, string notes = "") {
            //ensure all parameters are valid
            if (activePlayer == null || dice == null || dice.Length == 0) {
                throw new ArgumentException("No parameters can be null or zero-length");
            }
            //assign properties
            this.turnNumber = turnNumber;
            this.activePlayer = activePlayer;
            this.dice = dice;
            this.notes = notes;
        }

        /// <summary>
        /// Constructs a new HistoryEntry object containing only textual information
        /// </summary>
        /// <param name="notes">Textual notes</param>
        public HistoryEntry(string notes) {
            this.notes = notes;
        }

        /// <summary>
        /// Format this object's data in a readable fashion
        /// </summary>
        /// <returns>A human-readable formatted copy of the data as text</returns>
        public string getReadableFormat() {
            string output = "";
            //add the turn number if one has been assigned
            if (turnNumber != 0) {
                output += string.Format("Turn: {0} \n", turnNumber);
            }
            //add the player name and score if a player has been assigned
            if (activePlayer != null) {
                output += string.Format("Player: {0} \n", activePlayer.Name);
                output += string.Format("Score: {0} \n", activePlayer.Points);
            }
            //add the dice values if they have been assigned
            if (dice != null) {
                output += "Dice: ";
                foreach (Die die in dice) {
                    output += string.Format("{0} ", die.Value);
                }
            }
            //add note text if it has been assigned
            if (notes.Length > 0) {
                output += string.Format("\n{0}", notes);
            }
            return output;
        }

        /// <summary>
        /// Calculate the average value of the dice
        /// </summary>
        /// <returns>An average rounded to one decimal place</returns>
        public double getAverageofDice() {
            //get the total value
            double total = this.getTotalofDice();
            //calculate and return the average
            return Math.Round(total / dice.Length, 1);
        }

        /// <summary>
        /// Calculate the sum of the dice
        /// </summary>
        /// <returns>A total number of dice values</returns>
        public int getTotalofDice() {
            int total = 0;
            foreach (Die die in dice) {
                total += die.Value;
            }
            return total;
        }
    }
}