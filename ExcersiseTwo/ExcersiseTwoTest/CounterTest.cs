using ExcersiseTwo;
namespace ExcersiseTwoTest;

public class CounterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Tnitial_InstanceCountandTotalCount()
    {
        //Arrange
        Counter counter1 = new Counter(0);

        //Act
        var initialCount = counter1.InstanceCount;

        //Assert
        Assert.AreEqual(0, initialCount);
        Assert.AreEqual(0, Counter.TotalCount);
    }
    [Test]
    public void Test_InstanceCountandTotalCount_AfterIncrement()
    {
        //Arrange
        Counter counter1 = new Counter();
        Counter counter2 = new Counter();

        //Act
        var intantCount1 = counter1.InstanceCount;
        var intantCount2 = counter2.InstanceCount;
        var totalCount = Counter.TotalCount;

        //Assert
        Assert.AreEqual(1, intantCount1);
        Assert.AreEqual(1, intantCount2);
        Assert.AreEqual(2, totalCount);
    }
    [Test]
    public void InstanceCountandTotalCount_AfterMultiIncrement()
    {
        //Arrange&Act
        Counter counter1 = new Counter();
        Counter counter2 = new Counter();
        Counter counter3 = new Counter();
        Counter counter4 = new Counter();

        //Assert
        Assert.AreEqual(1, counter1.InstanceCount);
        Assert.AreEqual(1,counter2.InstanceCount);
        Assert.AreEqual(1,counter3.InstanceCount);
        Assert.AreEqual(1,counter4.InstanceCount);
        Assert.AreEqual(4, Counter.TotalCount);
    }

}