namespace NerveFalcon.Mafia;

public class Card
{
	public Card( string title ) => Title = title;

	public string Title { get; }

	public bool Act( Player player )
	{
		throw new NotImplementedException();
	}
}