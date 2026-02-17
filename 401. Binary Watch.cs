public class Solution
{
    private void TurnOn(int ledsToTurnOn, int ledsLeft, int value, List<string> result)
    {
        if (ledsLeft == 0)
        {
            int hour = value >> 6;
            int minute = value & 0b111111;

            if (hour < 12 && minute < 60)
            {
                result.Add($"{hour}:{minute:00}");
            }

            return;
        }

        if (ledsToTurnOn < ledsLeft)
        {
            TurnOn(ledsToTurnOn, ledsLeft - 1, value << 1, result);
        }

        if (ledsToTurnOn > 0)
        {
            TurnOn(ledsToTurnOn - 1, ledsLeft - 1, (value << 1) | 1, result);
        }
    }

    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        int leds = 10;
        List<string> result = [];

        TurnOn(turnedOn, leds, 0, result);

        return result;
    }
}
