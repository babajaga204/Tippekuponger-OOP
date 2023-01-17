namespace Tippekupong;

public class Match
{
    public int ScoreHome;
    public int ScoreAway;
    public bool IsActive = true;
    public void Goal(string team)
    {
        switch (team)
        {
            case "H":
                ScoreHome++;
                break;
            case "B":
                ScoreAway++;
                break;
        }
    }
    public void EndGame()
    {
        IsActive = false;
    }
}