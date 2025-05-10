using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

public class Quest : MonoBehaviour
{
    /// <summary>
    /// Gets or sets the unique identifier for the quest.
    /// </summary>
    public int Id;

    /// <summary>
    /// Gets or sets the quest to auto complete when the objectives are all done.
    /// Set to true if the quest completes on collecting/achieving goals.
    /// Set to false if the quest completes manually e.g. at a quest end point.
    /// </summary>
    public bool CanAutoComplete;

    /// <summary>
    /// Gets or sets the localized title of the quest.
    /// </summary>
    public LocalizedString Title;

    /// <summary>
    /// Gets or sets the localized description of the quest.
    /// </summary>
    public LocalizedString Description;

    /// <summary>
    /// Gets or sets the localized progress of the quest.
    /// </summary>
    public LocalizedString Progress;

    public List<QuestRequirement> Requirements = new();
}
