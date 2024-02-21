public enum PlayerTypes
{
  Character,
  Poultry
}

public interface IIdentity
{
 public string GetName(string myName);

 public string GetType(string myType);

 // IE player 1, player 2
 public int GetPlayer(int myPlayer);
}