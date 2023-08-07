namespace RoverTests
{
    [TestClass]
    public class MarsRoverTests
    {
        [TestMethod]
        public void Move_IfNoCollisionPossible_IncrementsYPosition()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 0;
            int positionY = 0;
            string heading = "N";

            MarsRover rover = new MarsRover(positionX, positionY, heading, new Planet(boundsX, boundsY));

            rover.Move();
            Assert.AreEqual(1, rover.PositionY);
            rover.Move();
            Assert.AreEqual(2, rover.PositionY);
            rover.Move();
            Assert.AreEqual(3, rover.PositionY);
            rover.Move();
            Assert.AreEqual(4, rover.PositionY);
            rover.Move();
            Assert.AreEqual(5, rover.PositionY);

            // collison possible
            rover.Move();
            Assert.AreEqual(5, rover.PositionY);
        }

        [TestMethod]
        public void Move_IfNoCollisionPossible_IncrementsXPosition()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 0;
            int positionY = 0;
            string heading = "E";

            Planet planet = new Planet(boundsX, boundsY);
            MarsRover rover = new MarsRover(positionX, positionY, heading, planet);

            rover.Move();
            Assert.AreEqual(1, rover.PositionX);
            rover.Move();
            Assert.AreEqual(2, rover.PositionX);
            rover.Move();
            Assert.AreEqual(3, rover.PositionX);
            rover.Move();
            Assert.AreEqual(4, rover.PositionX);
            rover.Move();
            Assert.AreEqual(5, rover.PositionX);

            // collision possible
            rover.Move();
            Assert.AreEqual(5, rover.PositionX);
        }

        [TestMethod]
        public void Move_IfNoCollisionPossible_DecrementsXPosition()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 5;
            int positionY = 0;
            string heading = "W";

            Planet planet = new Planet(boundsX, boundsY);
            MarsRover rover = new MarsRover(positionX, positionY, heading, planet);

            rover.Move();
            Assert.AreEqual(4, rover.PositionX);
            rover.Move();
            Assert.AreEqual(3, rover.PositionX);
            rover.Move();
            Assert.AreEqual(2, rover.PositionX);
            rover.Move();
            Assert.AreEqual(1, rover.PositionX);
            rover.Move();
            Assert.AreEqual(0, rover.PositionX);

            // collision possible
            rover.Move();
            Assert.AreEqual(0, rover.PositionX);
        }

        [TestMethod]
        public void Move_IfNoCollisionPossible_DecrementsYPosition()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 5;
            int positionY = 5;
            string heading = "S";

            Planet planet = new Planet(boundsX, boundsY);
            MarsRover rover = new MarsRover(positionX, positionY, heading, planet);

            rover.Move();
            Assert.AreEqual(4, rover.PositionY);
            rover.Move();
            Assert.AreEqual(3, rover.PositionY);
            rover.Move();
            Assert.AreEqual(2, rover.PositionY);
            rover.Move();
            Assert.AreEqual(1, rover.PositionY);
            rover.Move();
            Assert.AreEqual(0, rover.PositionY);

            // collision possible
            rover.Move();
            Assert.AreEqual(0, rover.PositionY);
        }


        [TestMethod]
        public void Rotate_IfGivenValidDirection_RotatesRight()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 5;
            int positionY = 5;
            string heading = "N";

            Planet planet = new Planet(boundsX, boundsY);
            MarsRover rover = new MarsRover(positionX, positionY, heading, planet);

            rover.Rotate("R");
            Assert.AreEqual("E", rover.Heading);
            rover.Rotate("R");
            Assert.AreEqual("S", rover.Heading);
            rover.Rotate("R");
            Assert.AreEqual("W", rover.Heading);
            rover.Rotate("R");
            Assert.AreEqual("N", rover.Heading);
            rover.Rotate("R");
            Assert.AreEqual("E", rover.Heading);
        }

        [TestMethod]
        public void Rotate_IfGivenValidDirection_RotatesLeft()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 5;
            int positionY = 5;
            string heading = "N";

            Planet planet = new Planet(boundsX, boundsY);
            MarsRover rover = new MarsRover(positionX, positionY, heading, planet);

            // Rotate Left
            rover.Rotate("L");
            Assert.AreEqual("W", rover.Heading);
            rover.Rotate("L");
            Assert.AreEqual("S", rover.Heading);
            rover.Rotate("L");
            Assert.AreEqual("E", rover.Heading);
            rover.Rotate("L");
            Assert.AreEqual("N", rover.Heading);
            rover.Rotate("L");
            Assert.AreEqual("W", rover.Heading);
        }

        [TestMethod]
        public void Instruct_IfGivenIterableCommands_CallsCorrectMethodsInLoop()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 0;
            int positionY = 0;
            string heading = "N";

            char[] commands = { 'R', 'M', 'M', 'L', 'M', 'R', 'R' };
            Planet planet = new Planet(boundsX, boundsY);
            MarsRover rover = new MarsRover(positionX, positionY, heading, planet);

            rover.Instruct(commands);

            Assert.AreEqual(2, rover.PositionX);
            Assert.AreEqual(1, rover.PositionY);
            Assert.AreEqual("S", rover.Heading);
        }

        [TestMethod]
        public void Report_WhenCalled_WritesRoverStatusToConsole()
        {
            int boundsX = 5;
            int boundsY = 5;
            int positionX = 2;
            int positionY = 3;
            string heading = "N";

            Planet planet = new Planet(boundsX, boundsY);
            MarsRover rover = new MarsRover(positionX, positionY, heading, planet);

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            rover.Report();

            string output = stringWriter.ToString();
            Assert.AreEqual("\r\nThe rover is now located at:\r\n2 3 N\r\n\r\n", output);
        }
    }
}