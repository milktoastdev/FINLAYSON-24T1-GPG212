public interface IIdentity
{
 public string GetName(string myName);

 public string GetType(string myType);
}

// *** POULTRY VS CHARACTER ***

/*

What do all characters share?
 * Has sprites and animations
 * Has maybe voices/shouts?
 * Same movement abilities
 * Same basic attack types

// Is poultry a character??????

// What is different?
 * One can use items & cannot fight from a distance
 * One only uses distance attacks & cannot use items (magic!)
 * Different sprites and animations
 * different voices/shouts
 * Different healths/damages for attacks
 * similar and different attack controls??

// What would they both inherit or have interfaces for?
 * Movement (left, right, jump, duck)
 * 'Attack' buttons (atk 1, atk 2, atk 3 even though the attacks are different)
 * Health
 * Dealing Damage
 * Taking Damage
 * Healing
 * Changing animations/sprites based on what they are doing
 * Making noises when their states change?

 */