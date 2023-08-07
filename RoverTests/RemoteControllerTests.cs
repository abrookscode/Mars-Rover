namespace RoverTests
{
    [TestClass]
    public class RemoteControllerTests
    {
        [TestMethod]
        public void Move_WhenGivenNorthHeading_IncrementsYAxis()
        {
            string heading = "N";
            int positionX = 0;
            int positionY = 0;

            RemoteController remoteController = new RemoteController(positionX, positionY, heading);

            remoteController.Move();
            Assert.AreEqual(1, remoteController.PositionY);
            Assert.AreEqual(0, remoteController.PositionX);
        }
        [TestMethod]
        public void Move_WhenGivenSouthHeading_DecrementsYAxis()
        {
            string heading = "S";
            int positionX = 5;
            int positionY = 5;

            RemoteController remoteController = new RemoteController(positionX, positionY, heading);

            remoteController.Move();
            Assert.AreEqual(4, remoteController.PositionY);
            Assert.AreEqual(5, remoteController.PositionX);
        }

        [TestMethod]
        public void Move_WhenGivenEastHeading_IncrementsXAxis()
        {
            string heading = "E";
            int positionX = 0;
            int positionY = 0;

            RemoteController remoteController = new RemoteController(positionX, positionY, heading);

            remoteController.Move();
            Assert.AreEqual(1, remoteController.PositionX);
            Assert.AreEqual(0, remoteController.PositionY);
        }

        [TestMethod]
        public void Move_WhenGivenWestHeading_DecrementsXAxis()
        {
            string heading = "W";
            int positionX = 5;
            int positionY = 5;

            RemoteController remoteController = new RemoteController(positionX, positionY, heading);

            remoteController.Move();
            Assert.AreEqual(4, remoteController.PositionX);
            Assert.AreEqual(5, remoteController.PositionY);
        }
    }

    public class CompassAbstractClass : Compass
    {
        public CompassAbstractClass(string heading) : base(heading)
        {
        }
    }
}