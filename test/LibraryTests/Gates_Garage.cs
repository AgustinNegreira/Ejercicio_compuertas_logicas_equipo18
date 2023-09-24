
using Gates;
using NUnit.Framework;

namespace GatesTests
{
    public class TestingGates
    {
        [Test]
        public void AndTest()
        {
            //arrange
            ILogicGate andfalse = new AndGate(false, true);
            ILogicGate andtrue = new AndGate(true, true);
            ILogicGate andfalse2 = new AndGate(false, false);
            ILogicGate andfalse3 = new AndGate(true, false);
            
            //act
            bool andfalsecheck = andfalse.Evaluate();
            bool andtruecheck = andtrue.Evaluate();
            bool andfalse2check = andfalse2.Evaluate();
            bool andfalse3check = andfalse3.Evaluate();
            
            //assert
            Assert.IsFalse(andfalsecheck);
            Assert.IsTrue(andtruecheck);
            Assert.IsFalse(andfalse2check);
            Assert.IsFalse(andfalse3check);
        }
        
        [Test]
        public void OrTest()
        {
            //arrange
            ILogicGate orfalse = new OrGate(false, false);
            ILogicGate ortrue = new OrGate(true, true);
            ILogicGate ortrue2 = new OrGate(false, true);
            ILogicGate ortrue3 = new OrGate(true, false);
            
            //act
            bool orfalsecheck = orfalse.Evaluate();
            bool ortruecheck = ortrue.Evaluate();
            bool ortrue2check = ortrue2.Evaluate();
            bool ortrue3check = ortrue3.Evaluate();
            
            //assert
            Assert.IsFalse(orfalsecheck);
            Assert.IsTrue(ortruecheck);
            Assert.IsTrue(ortrue2check);
            Assert.IsTrue(ortrue3check);
        }

        [Test]
        public void NotTest()
        {
            //arrange
            ILogicGate notfalse = new NotGate(true);
            ILogicGate nottrue = new NotGate(false);
            
            //act
            bool notfalsecheck = notfalse.Evaluate();
            bool nottruecheck = nottrue.Evaluate();
            
            //assert
            Assert.IsFalse(notfalsecheck);
            Assert.IsTrue(nottruecheck);
        }

        [Test]
        public void GarageTest()
        {
            //arrange
            ILogicGate Garagetrue = new GarageGate (true, true, true);
            ILogicGate Garagetrue2 = new GarageGate (false, false, true);
            ILogicGate Garagefalse = new GarageGate (false, false, false);
            ILogicGate Garagefalse2 = new GarageGate (false, true, false);
            ILogicGate Garagefalse3 = new GarageGate (true, true, false);
            ILogicGate Garagefalse4 = new GarageGate (true, false, true);
            ILogicGate Garagefalse5 = new GarageGate (false, true, true);
            ILogicGate Garagefalse6 = new GarageGate (true, false, false);
           
            //act
            bool Garagetruecheck = Garagetrue.Evaluate();
            bool Garagetrue2check = Garagetrue2.Evaluate();
            bool Garagefalsecheck = Garagefalse.Evaluate();
            bool Garagefalse2check = Garagefalse2.Evaluate();
            bool Garagefalse3check = Garagefalse3.Evaluate();
            bool Garagefalse4check = Garagefalse4.Evaluate();
            bool Garagefalse5check = Garagefalse5.Evaluate();
            bool Garagefalse6check = Garagefalse6.Evaluate();
            
            //assert
            Assert.IsTrue(Garagetruecheck);
            Assert.IsTrue(Garagetrue2check);
            Assert.IsFalse(Garagefalsecheck);
            Assert.IsFalse(Garagefalse2check);
            Assert.IsFalse(Garagefalse3check);
            Assert.IsFalse(Garagefalse4check);
            Assert.IsFalse(Garagefalse5check);
            Assert.IsFalse(Garagefalse6check);
        }
    }
}