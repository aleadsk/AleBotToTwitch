namespace BotTwitch.Classes;

public class Time {
    private DateTime discordLastNotification;

    public bool CalculateTime(DateTime dateTime) {
        DateTime dateTimeNow = DateTime.Now;

        var result = (dateTimeNow.Subtract(discordLastNotification)).Minutes;

        if (result >= 5) {
            return true;
        }

        return false;
    }
}