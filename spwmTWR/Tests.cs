namespace spwmTWR;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    #region TestCaseData
    private static readonly object[] _sourceTestData =
    {
        new object[]{
            new List<double>{
            0 
            ,0 
            ,-0.006253657 
            ,-0.00361612 
            ,-0.004777986 
            ,-0.026842209 
            ,0.000095331
            ,0 
            ,0 
            ,-0.004793408
            },
            -0.045534757 //result
        },
        new object[]{
            new List<double>{
            0 
            },
            0 //result
        },
        new object[]{
            new List<double>{
            0 
            ,0.157300 
            ,-0.006253657 
            ,-0.00361612 
            ,0.004777986 
            ,-0.026842209 
            ,0.000095331
            ,0.0054634
            ,0.12234
            ,0.004793408
            },
            0.270604676 //result
        }
    };
    #endregion

    [Test]
    [TestCaseSource(nameof(_sourceTestData))]
    public void TestTWR(List<double> dailyReturns, double expectedResult)
    {
        var actual = TWR.CalculateTWR(dailyReturns);

        Assert.AreEqual(expectedResult, TWR.CalculateTWR(dailyReturns),1e-9);
    }
}