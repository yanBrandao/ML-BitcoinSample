using System.Collections.Generic;

namespace BinaryClasification_TitanicSurvivalPrediction
{
    internal class TestTitanicData
    {
        internal static readonly TitanicData Passenger = new TitanicData()
        {
            Pclass = 2,
            Name = "Shelley, Mrs. William (Imanita Parrish Hall)",
            Sex = "female",
            Age = 25,
            SibSp = 0,
            Parch = 1,
            Ticket = "230433",
            Fare = "26",
            Cabin = "",
            Embarked = "S"
        };
    }
    internal class TestBitcoinDecisionData
    {
        internal static readonly BitCoinData Trade = new BitCoinData()
        {
           Price = 24800.08000000f,
           Amount = 0.00211754f,
           Type = 0 // 0 Para Compra e 1 Para Venda
        };
    }
}