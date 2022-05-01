using Cow_and_Bulls_game.Models;
using System.ComponentModel;

namespace Cow_and_Bulls_game.ViewModels
{
    public class UserGameViewModel
    {
        public User? user { get; set; }
        public string? errorMsg { get; set; }

    }
}
