namespace NerveFalcon.Mafia;

public class Player
{
	public Player( string title, Card card )
	{
		Title   = title;
		Card    = card;
		Status  = Status.WokeUp;
		Impacts = new List<Impact>();
		Fingers = new List<Player>();
	}

	public string              Title   { get; }
	public Card                Card    { get; }
	public Status              Status  { get; private set; }
	public Player?             Choice  { get; private set; }
	public IEnumerable<Impact> Impacts { get; }
	public IEnumerable<Player> Fingers { get; }

	public bool Act( Player player ) => Card.Act(player);

	public void WokeUp()
	{
		Status = Status.WokeUp;
	}

	public void FallAsleep()
	{
		Status = Status.Asleep;
	}
}