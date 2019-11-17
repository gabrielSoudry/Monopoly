using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly_TD7.model;
using Newtonsoft.Json;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            GameMasters game = GameMasters.Instance;

            string jsonTypeNameAuto = JsonConvert.SerializeObject(game, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });


            GameMasters game2 = JsonConvert.DeserializeObject<GameMasters>(jsonTypeNameAuto, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            Assert.AreEqual("Mediterranean Avenue", game2.board.lands[1].ToString());
        }
    }
}
