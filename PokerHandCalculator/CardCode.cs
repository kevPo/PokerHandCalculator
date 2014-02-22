namespace PokerHandCalculator
{
    public class CardCode
    {
        public string FaceCode { get; set; }
        public string SuitCode { get; set; }

        public CardCode(string cardData)
        {
            FaceCode = cardData.Substring(0, cardData.Length - 1).ToUpper();
            SuitCode = cardData.Substring(cardData.Length - 1).ToUpper();
        }
    }
}
