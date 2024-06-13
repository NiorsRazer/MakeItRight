public class Joueur
{
    public bool Status { get; set; } // Indicates if the player is active or not
    public TimeSpan Time { get; set; } // Stores the time spent playing
    public string Operation { get; set; } // Stores the last operation performed by the player
    public int Answer { get; set; } // Stores the player's last answer

    public Joueur(){
        Status = false;
    }
    
    public Joueur(bool status, TimeSpan time, string operation, int answer)
    {
        Status = status;
        Time = time;
        Operation = operation;
        Answer = answer;
    }
}