namespace NerveFalcon.Mafia;

public class Game
{
	public string Title { get; }
	public Deck?  Deck  { get; private set; }
	public Time   Time  { get; }
	
	public List<Player> Players { get; set; }

	public Game( string title )
	{
		Title   = title;
		Time    = Time.Day;
		Players = new List<Player>();
	}

	public void SelectDeck( Deck deck ) => Deck = deck;

	public void AddPlayers( IEnumerable<Player> players ) => Players.AddRange(players);

	public void AddPlayer( Player player ) => Players.Add( player );

	public void RemovePlayer( Player player ) => Players.Remove( player );
	public void RemovePlayer( string player ) => Players.Remove( Players.First(x=>x.Name == player) );

	public void DistributeCards()
	{
		if( Deck == null ) throw new ArgumentNullException( nameof( Deck ), "Колода должна быть заполнена" );
		foreach ( var player in Players )
		{
			player.SetCard( new Card( "" ) );
		}
	}
}

public enum Time
{
	Day,
	Night,
}