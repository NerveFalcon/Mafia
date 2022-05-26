namespace NerveFalcon.Mafia;

public class Player
{
	public Player( string name, Card card )
	{
		Name   = name;
		Card    = card;
		Status  = Status.WokeUp;
		Impacts = new List<Impact>();
		Fingers = new List<Player>();
	}

	public string              Name    { get; }
	public Card                Card    { get; private set; }
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

	public void SetCard( Card card )
	{
		Card = card;
	}
}