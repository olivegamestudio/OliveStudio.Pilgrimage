using System;

public class QuestCompletedEventArgs : EventArgs
{
    public Quest Quest { get; }

    public QuestCompletedEventArgs(Quest quest)
    {
        Quest = quest;
    }
}
