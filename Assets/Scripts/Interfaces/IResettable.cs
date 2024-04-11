public interface IResettable
{
    public void Reset();
    
    /*
     * Make objects ‘Resettable”
     * Eg, if you fall off the map, die, get stabbed, the round timer finishes, new round starts etc
     * You could use an interface with a simple function like “Reset();”
     * eg
     * Button status
     * Player positions
     * velocities
     * Object placements
     * Animations states
     * Statemanager resets and changes state back to default
     */
}