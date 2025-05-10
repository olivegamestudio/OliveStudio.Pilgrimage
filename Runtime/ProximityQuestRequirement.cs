using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

public class ProximityQuestRequirement : QuestRequirement
{
    public QuestActor Target;

    public float Distance = 1f;

    /// <summary>
    /// Checks if the player is within the proximity distance.
    /// </summary>
    bool IsInProximityToTarget => Target != null && Vector2.Distance(gameObject.transform.position, Target.transform.position) < Distance;

    void Start()
    {
        if (Target == null)
        {
            Debug.LogError("Target is not set for ProximityQuestRequirement.");
        }
    }

    void Update()
    {
        if (!IsComplete && IsInProximityToTarget)
        {
            Debug.Log("The actor has reached the target area, requirement completed.");
            IsComplete = true;
        }
    }
}
