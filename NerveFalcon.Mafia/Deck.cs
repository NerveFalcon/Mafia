namespace NerveFalcon.Mafia;

public class Deck
{
	public Deck( string title )
	{
		Title = title;
		Cards = new List<Card>();
	}

	public string            Title { get; }
	public IEnumerable<Card> Cards { get; }
}