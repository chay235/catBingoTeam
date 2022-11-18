 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_state
{
    public int id;
    public string name;
    public int score;
    public int[] questions;
    public int[] answers;
    public Dictionary<string, int> rewards;

    public Game_state(int id, string name,int score, int[] questions, int[] answers, Dictionary<string, int> rewards)
    {
        this.id = id;
        this.name = name;
        this.score = score;
        this.questions = questions;
        this.answers = answers;
        this.rewards = rewards;
    }
}
