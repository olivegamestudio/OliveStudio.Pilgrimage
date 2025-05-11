using System;

[Serializable]
public class QuestState
{
    public int Id;

    public QuestProgress Progress = QuestProgress.NotStarted;
}
