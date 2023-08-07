namespace RoverTests
{
    [TestClass]
    public class PlanetTests
    {
        [TestMethod]
        public void WillCollide_WhenCurrentPositionOnEdge_DetectsCollisionNorth()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 0;
            int positionY = 5;

            Planet planet = new Planet(boundsX, boundsY);

            bool collisionResult = planet.WillCollide(positionX, positionY)["N"];
            Assert.AreEqual(true, collisionResult);

            Assert.AreEqual(true, collisionResult);
        }

        [TestMethod]
        public void WillCollide_WhenCurrentPositionOnEdge_DetectsCollisionSouth()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 2;
            int positionY = 0;

            Planet planet = new Planet(boundsX, boundsY);


            bool collisionResult = planet.WillCollide(positionX, positionY)["S"];
            Assert.AreEqual(true, collisionResult);
            Assert.AreEqual(true, collisionResult);
        }

        [TestMethod]
        public void WillCollide_WhenCurrentPositionOnEdge_DetectsCollisionEast()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 5;
            int positionY = 2;

            Planet planet = new Planet(boundsX, boundsY);

            bool collisionResult = planet.WillCollide(positionX, positionY)["E"];
            Assert.AreEqual(true, collisionResult);
        }

        [TestMethod]
        public void WillCollide_WhenCurrentPositionOnEdge_DetectsCollisionWest()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 0;
            int positionY = 2;

            Planet planet = new Planet(boundsX, boundsY);

            bool collisionResult = planet.WillCollide(positionX, positionY)["W"];
            Assert.AreEqual(true, collisionResult);
        }

        [TestMethod]
        public void WillCollide_WhenCurrentPositionNotOnEdge__DetectsNoChanceOfCollision()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 3;
            int positionY = 3;

            Planet planet = new Planet(boundsX, boundsY);

            bool collisionResultNorth = planet.WillCollide(positionX, positionY)["N"];
            bool collisionResultSouth = planet.WillCollide(positionX, positionY)["S"];
            bool collisionResultEast = planet.WillCollide(positionX, positionY)["E"];
            bool collisionResultWest = planet.WillCollide(positionX, positionY)["W"];

            Assert.AreEqual(false, collisionResultNorth);
            Assert.AreEqual(false, collisionResultSouth);
            Assert.AreEqual(false, collisionResultEast);
            Assert.AreEqual(false, collisionResultWest);
        }
    }
}