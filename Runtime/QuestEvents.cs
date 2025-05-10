using System;
using System.Linq;
using UnityEngine;

public static class QuestEvents
{
    /// <summary>
    /// Event triggered when a quest is started.
    /// </summary>
    public static event EventHandler<QuestStartedEventArgs> QuestStarted = delegate { };

    /// <summary>
    /// Event triggered when a quest is completed.
    /// </summary>
    public static event EventHandler<QuestCompletedEventArgs> QuestCompleted = delegate { };

    /// <summary>
    /// Event triggered when the player reaches a point of interest.
    /// </summary>

    public static event EventHandler<PointOfInterestEventArgs> ReachedPointOfInterest = delegate { };

    /// <summary>
    /// Invokes the QuestStarted event.
    /// </summary>
    /// <param name="quest">The quest that was started.</param>
    public static void NotifyQuestStarted(Quest quest) 
        => QuestStarted.Invoke(null, new QuestStartedEventArgs(quest));

    /// <summary>
    /// Invokes the QuestCompleted event.
    /// </summary>
    /// <param name="quest">The quest that was completed.</param>
    public static void NotifyQuestCompleted(Quest quest) 
        => QuestCompleted.Invoke(null, new QuestCompletedEventArgs(quest));

    /// <summary>
    /// Invokes the reached point of interest event.
    /// </summary>
    public static void NotifyReachedPointOfInterest()
        => ReachedPointOfInterest.Invoke(null, new PointOfInterestEventArgs());
}
