using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

public class ProximityQuestRequirement : QuestRequirement
{
    public GameObject Target;

    public float Distance = 1f;

    /// <summary>
    /// Checks if the player is within the proximity distance.
    /// </summary>
    bool IsInProximityToTarget => Target != null && Vector2.Distance(gameObject.transform.position, Target.transform.position) < Distance;

    void Update()
    {
        if (IsInProximityToTarget)
        {
            IsComplete = true;
        }
    }
}
