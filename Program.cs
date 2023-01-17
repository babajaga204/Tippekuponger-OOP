
namespace Tippekupong;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
        var bet = Console.ReadLine();
        var match = new Match();
        while (match.IsActive)
        {
            Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
            string? command = Console.ReadLine()?.ToUpper();
            match.IsActive = command != "X";
            switch (command)
            {
                case "H":
                    match.Goal(command);
                    break;
                case "B":
                    match.Goal(command);
                    break;
            }
            Console.WriteLine($"Stillingen er {match.ScoreHome}-{match.ScoreAway}.");
        }

        var result = match.ScoreHome == match.ScoreAway ? "U" : match.ScoreHome > match.ScoreAway ? "H" : "B";
        var isBetCorrect = bet.Contains(result);
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
        Console.WriteLine($"Du tippet {isBetCorrectText}");
    }
}