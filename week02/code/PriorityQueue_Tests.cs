using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue should return the item with the highest priority.
    // Expected Result: The value "Hannah" should be returned because it has the highest priority (5).
    // Defect(s) Found: If priority comparison is wrong or index logic has mistake, the test will fail.
    public void TestPriorityQueue_HighestPriority()
    {
        var q = new PriorityQueue();
        q.Enqueue("John", 1);
        q.Enqueue("Hannah", 5);
        q.Enqueue("Anne", 3);

        var result = q.Dequeue();

        Assert.AreEqual("Hannah", result);
    }

    [TestMethod]
    // Scenario: When two items have the same priority, the one added first must be dequeued.
    // Expected Result: "Joseph" should be returned (priority 5, arrived before "B").
    // Defect(s) Found: If the rule of ranking the arrival order fails, the test will fail.
    public void TestPriorityQueue_TieBreakOrder()
    {
        var q = new PriorityQueue();
        q.Enqueue("Joseph", 5);
        q.Enqueue("Odette", 5);

        var result = q.Dequeue();

        Assert.AreEqual("Joseph", result);
    }

    [TestMethod]
    // Scenario: Multiple items with differents priorities.
    // Expected Result: First "Paul" (priority 10), then "Clinton" (priority 5), then "John" (priority 5).
    // Defect(s) Found: Logic errors in loop or removing wrong index.
    public void TestPriorityQueue_MixedPriorities()
    {
        var q = new PriorityQueue();
        q.Enqueue("Clinton", 5);
        q.Enqueue("John", 5);
        q.Enqueue("Paul", 10);

        Assert.AreEqual("Paul", q.Dequeue());
        Assert.AreEqual("Clinton", q.Dequeue());
        Assert.AreEqual("John", q.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue throws InvalidOperationException.
    // Expected Result: Correct exception with message "The queue is empty."
    // Defect(s) Found: Missing message or wrong exception type/message.
    public void TestPriorityQueue_EmptyQueueException()
    {
        var q = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() => q.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }

    [TestMethod]
    // Scenario: Items must be removed ONLY by priority, NOT by order of insertion.
    // Expected Result: "Paul" first (priority 100), then "Antony" (priority 2), then "Natalie" (priority 1).
    // Defect(s) Found: Any mistaken behavior in priority comparison.
    public void TestPriorityQueue_PriorityDominatesOrder()
    {
        var q = new PriorityQueue();
        q.Enqueue("Antony", 2);
        q.Enqueue("Natalie", 1);
        q.Enqueue("Paul", 100);

        Assert.AreEqual("Paul", q.Dequeue());
        Assert.AreEqual("Antony", q.Dequeue());
        Assert.AreEqual("Natalie", q.Dequeue());
    }


}
