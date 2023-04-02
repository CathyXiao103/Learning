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
        //Counter counter1 = new Counter();      
        //Assert.AreEqual(1, counter1.InstanceCount);
        Assert.AreEqual(0, Counter.TotalCount);
    }
    [Test]
    public void Test_InstanceCountandTotalCount_AfterIncrement()
    {
        Counter counter1 = new Counter();
        Counter counter2 = new Counter();

        Assert.AreEqual(1, counter1.InstanceCount);
        Assert.AreEqual(1, counter2.InstanceCount);
        Assert.AreEqual(2, Counter.TotalCount);
    }
    [Test]
    public void InstanceCountandTotalCount_AfterMultiIncrement()
    {
        Counter counter1 = new Counter();
        Counter counter2 = new Counter();
        Counter counter3 = new Counter();
        Counter counter4 = new Counter();

        Assert.AreEqual(1, counter1.InstanceCount);
        Assert.AreEqual(1,counter2.InstanceCount);
        Assert.AreEqual(1,counter3.InstanceCount);
        Assert.AreEqual(1,counter4.InstanceCount);
        Assert.AreEqual(4, Counter.TotalCount);
    }

}