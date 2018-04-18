using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Notes
{
    /// <summary>
    /// Encapsulates logic for sending notifications and 
    /// taking action based on the user's response
    /// </summary>
    public class NotificationService
    {   
//TODO: Implement rest of logic

//HACK: Fixed for now

//UNDONE: Not yet implemented
    }

    public class Ellipse
    {
        public Rectangle BoundingBox { get; set; }
        public class TimeZoneLookup
        {
            public static string Find(string state, string city)
            {
                return null;
            }

        }

        public Ellipse(Rectangle rectangle)
        {
            BoundingBox = rectangle;
        }

        /// <summary>
        /// Gets the time zone based on US state and city
        /// </summary>
        /// <param name="state">US State</param>
        /// <param name="city">US City</param>
        /// <returns>Time Zone</returns>
        public string GetTimeZone(string state, string city)
        {
            var timeZoneId = TimeZoneLookup.Find(state, city);

            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            return timeZoneInfo.ToString();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Ellipse()
        {
            // Instantiate a new instance of Ellipse
            Ellipse ellipse = new Ellipse();

            dynamic message = new object();

            //// Check to see if the SMS failed by checking for 4
            //if (message.Status == 4)
            //{
            //    // Do something
            //}


        }

private void GiganticMethod()
{
    //Do the first thing
    //...

    //Do the second thing
    //...

    //Do the third thing
    //...

    //Keep going forever
}



        /// <summary>
        /// Move ellipse to new point
        /// </summary>
        /// <param name="newPoint">The point</param>
        public void MoveEllipse(Point newPoint)
        {
            //...
        }
    }

    public class Helper
    {
        public Ellipse CreateEllipse()
        {
            var ellipse = new Ellipse(new Rectangle(0, 0, 100, 100));
            var boundingBox = ellipse.BoundingBox;
            boundingBox.Inflate(10, 10);

            return ellipse;
        }

        public Ellipse CreateEllipse2()
        {
            var ellipse = new Ellipse(new Rectangle(0, 0, 100, 100));
            var boundingBox = ellipse.BoundingBox;
            //var smallerBox = boundingBox.Inflate(10, 10);
            var smallerBox = boundingBox;

            return new Ellipse(smallerBox);
        }

        public class Product
        {
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
        }

        IEnumerable<Product> Products;

        IEnumerable<string> GetExpensiveProducts()
        {
            IList<string> filteredInfos = new List<string>();

            foreach (Product product in Products)
            {
                if (product.UnitPrice > 75.0M)
                {
                    filteredInfos.Add($"{product.ProductName} - {product.UnitPrice:c}");
                }

            }

            return filteredInfos;
        }

        IEnumerable<string> GetExpensiveProducts2()
        {
            return from product in Products
                   where product.UnitPrice > 75.0M
                   select $"{product.ProductName} - {product.UnitPrice:c}";
        }
    }

    public class GameCharacter
    {
        private readonly int _health;
        private readonly Point _location;

        public GameCharacter(int health, Point location)
        {
            _health = health;
            _location = location;
        }

        public GameCharacter HitByShooting(Point target)
        {
            int newHealth = CalculateHealth(target);

            return new GameCharacter(newHealth, _location);
        }

        public bool IsAlive => _health > 0;

        // Other methods an properties ommitted
        private int CalculateHealth(Point target)
        {
            throw new NotImplementedException();
        }

        public GameCharacter PerformStep() => this;
        public bool IsCloseTo(GameCharacter character) => true;

        static void Main2(string[] args)
        {
            var monster = new GameCharacter(32, new Point());
            var player = monster;
            var gunShot = new Point();

            var movedMonster = monster.PerformStep();
            var inDanger = player.IsCloseTo(movedMonster);
            //(...)

            var hitMonster = monster.HitByShooting(gunShot);
            var hitPlayer = player.HitByShooting(gunShot);
            //(...)

                var monsters = new List<GameCharacter>();

            var updated = from m in monsters.AsParallel()
                          let nm = m.PerformStep()
                          where nm.IsAlive
                          select nm;
        }
    }
}
