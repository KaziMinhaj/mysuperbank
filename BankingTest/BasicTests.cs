using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTest
{
    public class BasicTests

    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {

            var account = new BankAccount("minhaj", 1000);  

            Assert.Throws<InvalidOperationException>(
                ()=> account.MakeWithdrawal(7500,DateTime.Now,"Attempt to overdraw")
                );      
           
        }

        //[Fact]
        //public void Test3()
        //{

        //    Assert.Throws<ArgumentOutOfRangeException>(
        //        ()=> new BankAccount("invalid", -55)
        //        );

        //}
    }
}