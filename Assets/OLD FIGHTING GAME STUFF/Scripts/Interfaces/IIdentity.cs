public enum PlayerTypes
{
  Fighter,
  Summon
}

public interface IIdentity
{
    public string GetName(string myName);

    public string GetType(string myType);
}