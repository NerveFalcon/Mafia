using System.ComponentModel;

namespace NerveFalcon.Mafia;

[ DefaultValue( WokeUp ) ]
public enum Status
{
	Dead = 0,
	Asleep,
	WokeUp,
}