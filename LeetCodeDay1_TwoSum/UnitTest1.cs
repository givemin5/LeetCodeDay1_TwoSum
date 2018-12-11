using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeDay1_TwoSum
{
    //Given nums = [2, 7, 11, 15], target = 9,
    //Because nums[0] + nums[1] = 2 + 7 = 9,
    //return [0, 1].

    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void TwoSum_Target_is_9_Then_Return_0_1()
        {
            //Arrange
            var nums = new[] { 2, 7, 11, 15 };

            //Act
            Solution solution = new Solution();
            var actual = solution.TwoSum(nums, 9);

            //Assert
            var exptected = new[] { 0, 1 };
            actual.ToExpectedObject().ShouldEqual(exptected);
        }
    }
}