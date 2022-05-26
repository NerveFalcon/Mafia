namespace NerveFalcon.Mafia;

public class Effect
{
	public Effect( string title ) => Title = title;

	public string Title     { get; }
	public bool   IsEndless { get; }
	public int    CoolDown  { get; }
}