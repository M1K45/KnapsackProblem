using System.Linq;
using lab_1;

namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Problem_Solve_EmptySolution()
        {
            Problem problem = new Problem(2, 1);

            // capacity is purposefully too low 
            Result result = problem.Solve(1);

            // checking if the list is empty - number of elements is 0
            Assert.AreEqual(0, result.itemsId.Count());
        }

        [TestMethod]
        public void Problem_Solve_ReturnAtLeastOneElement()
        {
            Problem problem = new Problem(2, 1);

            // capacity is to high it is impossible to not fill it 
            Result result = problem.Solve(10);

            Assert.IsTrue(result.itemsId.Count() > 0);
        }

        [TestMethod]
        public void Problem_Solve_IsCorrect()
        {
            Problem problem = new Problem(5, 1);
            Result result = problem.Solve(10);

            bool output = false;
            int expectedTotalWeight = 10;
            int expectedTotalValue = 22;

            List<int> expectedItems = new List<int> { 4, 3, 1 };


            if (result.itemsId.SequenceEqual(expectedItems) && result.totalValue == expectedTotalValue
                && result.totalWeight == expectedTotalWeight) { output = true; }


            Assert.IsTrue(output);

        }

        [TestMethod]
        public void Problem_Solve_MaxFill()
        {
            Problem problem = new Problem(5, 1);

            // numbers randomly generated above will fill exactly this weight
            int maxFill = 13;
            Result result = problem.Solve(maxFill);

            Assert.AreEqual(maxFill, result.totalWeight);
        }

        [TestMethod]
        public void Problem_Solve_lessThanOneCapacity()
        {
            // this code checks if the error is being thrown after kapesack capacity if set 
            // to a negative number

            Problem problem = new Problem(5, 1);
            Action action = () => problem.Solve(-10);
            Assert.ThrowsException<ArgumentException>(action);
        }
    }
}
