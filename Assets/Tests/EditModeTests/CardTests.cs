using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CardTests
    {
        private CommonCard c;
        [SetUp]
        public void Setup()
        {
            c = new CommonCard();
        }
        
        //Testing if the target location is smaller than the movement value of 5 
        [Test]
        public void MoveCardBoundaryCheck()
        {
            MoveAction m = new MoveAction();
            m.TargetType = TargetType.Map;
            m.Value = 5;
            m.Target = GameObject.Instantiate(new GameObject(), new Vector3(0, 0, 0), Quaternion.identity);
            m.Param = new Vector3(3f, 0f, 0f);
            c.AddAction(m);

            bool[] success = c.Execute();
            Assert.AreEqual(success[0], true);
        }
    }
}
