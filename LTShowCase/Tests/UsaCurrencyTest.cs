using LTShowCase;
using NUnit.Framework;

namespace Tests
{
    public class ExactChangeExerciseTests
    {
        private decimal _amount;
        
        [SetUp]
        public void SetupForZeroAmount()
        
        {
            _amount = 0.00m;
        }

        [Test]
        public void CalculateChange_ShouldReturnEmptyWhenGivenZero()
        {
            var change = ExactChangeExercise.CalculateChange(_amount);

            Assert.That(change.Count, Is.EqualTo(0));
        }
        
        // having issues with this test - hit a road block
        // [SetUp]
        // private void SetupFor19_99()
        // {
        //     _amount = 19.99m;
        // }
        //
        // [Test]
        // public void CalculateChange_ShouldReturnCorrectChangeWhenGiven19_99()
        // {
        //     var change = ExactChangeExercise.CalculateChange(_amount);
        //
        //     Assert.That(change[0], Is.EqualTo("1 - $10 bill"));
        //     Assert.That(change[1], Is.EqualTo("1 - $5 bill"));
        //     Assert.That(change[2], Is.EqualTo("4 - $1 bill"));
        //     Assert.That(change[3], Is.EqualTo("3 - quarter"));
        //     Assert.That(change[4], Is.EqualTo("2 - dime"));
        //     Assert.That(change[5], Is.EqualTo("4 - penny"));
        //}
    }
}