using System.Data.Common;

namespace Rectangles
{
    public class Rectangle
    {
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }


        public bool IsValidRectangle()
        {
            bool isSegment = (left == right) || (top == bottom);
            bool isDot = (left == right && top == bottom);
            bool isTopGreaterThanBottom = top > bottom;
            bool isleftGreaterThanRight = left > right;

            return !isSegment && !isDot && !isTopGreaterThanBottom && !isleftGreaterThanRight;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the rectangle A (left,right,top,bottom): ");
            string? rectangle1Str = Console.ReadLine();
            int[] rectangle1Coords = Array.ConvertAll(rectangle1Str?.Split(',') ?? Array.Empty<string>(), int.Parse);
            
            if (rectangle1Coords.Length != 4)
            {
                Console.WriteLine("Invalid input. Please enter exactly 4 coordinates.");
                return;
            }
            Rectangle Rec1 = new Rectangle
            {
                left = rectangle1Coords[0],
                right = rectangle1Coords[1],
                top = rectangle1Coords[2],
                bottom = rectangle1Coords[3]
            };

            Console.WriteLine("Enter the coordinates of the rectangle B (left,right,top,bottom): ");
            string? rectangle2Str = Console.ReadLine();
            int[] rectangle2Coords = Array.ConvertAll(rectangle2Str?.Split(',') ?? Array.Empty<string>(), int.Parse);
            
            if (rectangle2Coords.Length != 4)
            {
                Console.WriteLine("Invalid input. Please enter exactly 4 coordinates.");
                return;
            }
            Rectangle Rec2 = new Rectangle
            {
                left = rectangle2Coords[0],
                right = rectangle2Coords[1],
                top = rectangle2Coords[2],
                bottom = rectangle2Coords[3]
            };

            if (!Rec1.IsValidRectangle())
            {
                Console.WriteLine("The first rectangle is not valid.");
                return;
            }

            if (!Rec2.IsValidRectangle())
            {
                Console.WriteLine("The second rectangle is not valid.");
                return;
            }
            
            if (ContainmentTest(Rec1, Rec2))
            {
                return;
            } 

            if (Overlap(Rec1, Rec2) is Rectangle overlap)
            {
               Console.WriteLine("The rectangles intersect.");
               foreach (var (x, y) in BorderCrossings(Rec1, Rec2))
                   Console.WriteLine($"Intersection: ({x}, {y})");
            }
        }

        public static Rectangle? Overlap(Rectangle a, Rectangle b)
        {
            int leftMax = Math.Max(a.left, b.left);
            int rightMin = Math.Min(a.right, b.right);
            int topMax = Math.Max(a.top, b.top);
            int bottomMin = Math.Min(a.bottom, b.bottom);

            if (leftMax > rightMin || topMax > bottomMin)
            {
                Console.WriteLine("The rectangles are separate.");
                return null;
            }

            if (leftMax == rightMin || topMax == bottomMin)
            {
                Console.WriteLine("The rectangles are adjacent.");
                return null;
            }
            
            return new Rectangle{left = leftMax, top = topMax, right = rightMin, bottom = bottomMin};
        }

        public static List<(int X, int Y)> BorderCrossings(Rectangle a, Rectangle b)
        {
            var result = new List<(int X, int Y)>();
            if (Overlap(a, b) is not Rectangle o)
                return result;

            int[] xs = { o.left, o.right };
            int[] ys = { o.top, o.bottom };

            foreach (int x in xs)
            {
                foreach (int y in ys)
                {
                    bool xOnA = x == a.left || x == a.right;   // on a vertical edge of A
                    bool xOnB = x == b.left || x == b.right;   // on a vertical edge of B
                    bool yOnA = y == a.top || y == a.bottom;  // on a horizontal edge of A
                    bool yOnB = y == b.top || y == b.bottom;  // on a horizontal edge of B

                    // A crossing is where a vertical edge of one rectangle
                    // meets a horizontal edge of the other.
                    if ((xOnA && yOnB) || (xOnB && yOnA))
                    {
                        var point = (x, y);
                        if (!result.Contains(point))
                            result.Add(point);
                    }
                }
            }
            return result;
        }


        private static bool ContainmentTest(Rectangle recA, Rectangle recB)
        {
            bool AInsideB = recA.left >= recB.left && recA.right <= recB.right && recA.top >= recB.top && recA.bottom <= recB.bottom;
            bool BInsideA = recB.left >= recA.left && recB.right <= recA.right && recB.top >= recA.top && recB.bottom <= recA.bottom;
            
            switch (2*Convert.ToInt32(AInsideB) + Convert.ToInt32(BInsideA))
            {
                case 0:
                    return false;
                case 1:
                    Console.WriteLine("Rectangle B is inside Rectangle A.");
                    return true;
                case 2:
                    Console.WriteLine("Rectangle A is inside Rectangle B.");
                    return true;
                case 3:
                    Console.WriteLine("The rectangles are equal.");
                    return true;
                default:
                    return false;
            }
        }        
    }
}
