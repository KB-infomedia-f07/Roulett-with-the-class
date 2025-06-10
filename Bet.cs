class Bet
{
    //Hur mycket som beattst
    public int BetValue { get; set; }

    public int BetType { get; set; }

    public int BettedNumber { get; set; }

    public int BettedColor { get; set; }



    public Bet(int betVal, int betType, int bettedNum, int bettedC)
    {
        BetValue = betVal;
        BetType = betType;
        BettedNumber = bettedNum;
        BettedColor = bettedC;
    }
}