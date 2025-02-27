using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment24{
public class RacingGame : MonoBehaviour
{
    public RaceState raceState;

    // Update is called once per frame
    void Update()
    {
        SimulateRace();
    }

    void SimulateRace(){
        switch(raceState){
            case RaceState.start:
                Debug.Log("The race is about to begin. Get ready!");
                break;
            case RaceState.accelerate:
                Debug.Log("You press the gas pedal. The car speeds up!");
                break;
            case RaceState.turn:
                Debug.Log("You approach a sharp turn. Be careful not to crash!");
                break;
            case RaceState.crash:
                Debug.Log("You hit a barrier. The race is over.");
                break;
            case RaceState.finish:
                Debug.Log("You crossed the finish line. Well done!");
                break;
            default:
                Debug.Log("This state is not defined. Something is wrong.");
                break;
        }
    }
}
}
