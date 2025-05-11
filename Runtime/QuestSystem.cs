using System;
using System.Linq;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    /// <summary>
    /// The array of quests managed by the quest system.
    /// </summary>
    public Quest[] Quests { get; set; } = Array.Empty<Quest>();

    /// <summary>
    /// Start is called before the first frame update.
    /// Initializes the quest system and subscribes to events.
    /// </summary>
    void Start()
    {
        Quests = gameObject.GetComponentsInChildren<Quest>();
    }

    void OnEnable()
    {
        QuestEvents.ReachedPointOfInterest += OnQuestCompleted;
    }

    void OnDisable()
    {
        QuestEvents.ReachedPointOfInterest -= OnQuestCompleted;
    }

    void OnQuestCompleted(object sender, PointOfInterestEventArgs e) => OnCheckQuestCompletion();

    /// <summary>
    /// Gets the quest with the specified identifier.
    /// </summary>
    /// <param name="questId">The identifier of the quest.</param>
    /// <returns>The quest with the specified identifier, or null if not found.</returns>
    public Quest GetQuest(int questId) => Quests.FirstOrDefault(it => it.Id == questId);

    /// <summary>
    /// Check a quest can be completed.
    /// </summary>
    void OnCheckQuestCompletion()
    {
        foreach (Quest quest in Quests)
        {
            if (quest.CanAutoComplete && quest.IsComplete)
            {
                QuestEvents.NotifyQuestCompleted(quest);
            }
        }
    }
}
