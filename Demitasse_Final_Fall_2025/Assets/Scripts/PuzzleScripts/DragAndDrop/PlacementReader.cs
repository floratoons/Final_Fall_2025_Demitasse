using UnityEngine;

public class PlacementReader : MonoBehaviour
{
    
    // here we need to:

    // get the stats on the puzzlepiece scriptable objs
    // when a piece is placed,
    // register whether the piece is in its right place

    // if it is:
    // make it not a raycast target (?)
    // register that 1/4 pieces is placed right
    // tell gamemanager 1/4 to puzzle complete
    // take that piece off the list of items to spawn

    // if it isn't:
    // let it snap back to its place on the PItemGroup

}
