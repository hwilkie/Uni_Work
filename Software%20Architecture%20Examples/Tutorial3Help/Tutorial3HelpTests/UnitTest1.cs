using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tutorial3Help;

namespace Tutorial3HelpTests
{
    [TestClass]
    public class UnitTest1
    {
        IGameWinnerService _gameWinnerService;
        char[,] _gameboard;

        [TestInitialize]
        public void SetUpMyTests()
        {
            _gameWinnerService = new GameWinnerService();
            _gameboard = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '},
            };
        }

        [TestMethod]
        public void TestMethod1()
        {
            const char expected = ' ';

            var actual = _gameWinnerService.Validate(_gameboard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }


        [TestMethod]
        public void PlayerWithAllCrossesIntopRowIsWinner()
        {
            const char expected = 'X';

            for (var i = 0; i < 3; ++i)
            {
                _gameboard[0, i] = expected;
            }

            var actual = _gameWinnerService.Validate(_gameboard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }
}
