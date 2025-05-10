using System;

public class QuestStartedEventArgs : EventArgs
{
    public Quest Quest { get; }

    public QuestStartedEventArgs(Quest quest)
    {
        Quest = quest;
    }
}
