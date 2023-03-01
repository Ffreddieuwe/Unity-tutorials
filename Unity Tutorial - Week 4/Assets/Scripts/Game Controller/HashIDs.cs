using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour
{
    public int dyingState;
    public int walkState;
    public int backwardsState;
    public int shoutState;
    
    public int deadBool;
    public int sneakingBool;
    public int shoutingBool;

    public int speedFloat;



    private void Awake()
    {
        dyingState = Animator.StringToHash("BaseLayer.Dying");
        walkState = Animator.StringToHash("Walk");
        backwardsState = Animator.StringToHash("Backwards");
        shoutState = Animator.StringToHash("Shouting.Shout");

        deadBool = Animator.StringToHash("Dead");
        sneakingBool = Animator.StringToHash("Sneaking");
        shoutingBool = Animator.StringToHash("Shouting");

        speedFloat = Animator.StringToHash("Speed");
    }
}
