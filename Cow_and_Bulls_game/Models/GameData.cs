using System.ComponentModel.DataAnnotations;

namespace Cow_and_Bulls_game.Models
{
    public class GameData
    {
        [Display(Name = "Please Guess Any Four Digit Number : ")]
        public string number { get; set; }
        public int? bulls { get; set; }
        public int? cows { get; set; }
        public bool isWon { get; set; }
        public string msg { get; set; }
        public int? turns { get; set; }
    }
}
