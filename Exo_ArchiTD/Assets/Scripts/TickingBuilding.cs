using System.Collections;
using UnityEngine;

public abstract class TickingBuilding : Building
{
    IEnumerator Tick()
    {
        yield return new WaitForEndOfFrame();
    }
}
