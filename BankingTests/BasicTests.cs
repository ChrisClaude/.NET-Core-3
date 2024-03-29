using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new BankAccount("Kelly", 10000);

            // Test for a negative balance
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(75000,
                    DateTime.Now,
                    "Attempt to overdraw")
            );
        }

        [Fact]
        public void InitialBalance()
        {
            // Test that the initial balances must be positive
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("ivalid", 55)
            );
        }
    }
}