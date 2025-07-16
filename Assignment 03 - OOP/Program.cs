using Assignment_03___OOP;
using System;

namespace Assignment_03___OOP
{
    #region Part 1
    /*
     Question 1: b) To define a blueprint for a class
     Question 2: a) private
     Question 3: b) No
     Question 4: b) Yes, interfaces can inherit from multiple interfaces
     Question 5: d) implements
     Question 6: a) Yes
     Question 7: b) No, all members are implicitly public
     Question 8: a) To hide the interface members from outside access
     Question 9: b) No, interfaces cannot have constructors
     Question 10: c) By separating interface names with commas
     */
    #endregion

    #region Part 2 Q1)
    interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    interface ICircle : IShape { }

    interface IRectangle : IShape { }

    class Circle : ICircle
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get { return 3.14 * Radius * Radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Area: " + Area);
        }
    }

    class Rectangle : IRectangle
    {
        public double Length;
        public double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Area
        {
            get { return Length * Width; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Area: " + Area);
        }
    }


    #endregion

    #region Part 2 Q2)

    interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "admin";
        private string storedPassword = "1234";
        private string storedCredentials = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedCredentials;
        }
    }

    #endregion

    #region Part 2 Q3)

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 2 Q1)

            Circle c = new Circle(5);
            c.DisplayShapeInfo();

            Console.WriteLine(); // blank line

            Rectangle r = new Rectangle(4, 6);
            r.DisplayShapeInfo();

            #endregion

            #region Part 2 Q2

            IAuthenticationService authService = new BasicAuthenticationService();

            bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
            Console.WriteLine("Authenticated: " + isAuthenticated);

            bool isAuthorized = authService.AuthorizeUser("admin", "admin");
            Console.WriteLine("Authorized: " + isAuthorized);

            #endregion
        }
    }
}
