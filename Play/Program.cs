// See https://aka.ms/new-console-template for more information
using NerveFalcon.Mafia;

Console.WriteLine( "Hello, World!" );
var game = new Game("Title");
game.AddPlayers( new List<Player>() );
game.SelectDeck( new Deck( "13" ) );
game.DistributeCards();
