using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangles;
using System;
using System.IO;

namespace Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Intersect1()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,0,10" + Environment.NewLine +
            "5,15,5,15" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles intersect.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }


    [TestMethod]
    public void Intersect2()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,20,10,15" + Environment.NewLine +
            "5,10,0,20" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles intersect.");
            StringAssert.Contains(
                consoleOutput,
                "Intersection: (5, 10)"); 
            StringAssert.Contains(
                consoleOutput,
                "Intersection: (5, 15)"); 
            StringAssert.Contains(
                consoleOutput,
                "Intersection: (10, 10)"); 
            StringAssert.Contains(
                consoleOutput,
                "Intersection: (10, 15)");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Intersect3()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,0,10" + Environment.NewLine +
            "5,15,5,15" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles intersect.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
    
    [TestMethod]
    public void Intersect7()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,20,10,20" + Environment.NewLine +
            "10,15,0,15" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles intersect.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Contain1()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,20,0,20" + Environment.NewLine +
            "10,15,5,15" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "Rectangle B is inside Rectangle A.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Contain2()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "10,15,5,15" + Environment.NewLine +
            "0,20,0,20" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "Rectangle A is inside Rectangle B.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Contain3()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,20,0,20" + Environment.NewLine +
            "0,15,10,15" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "Rectangle B is inside Rectangle A.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Adjacent1()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,0,20" + Environment.NewLine +
            "10,20,5,10" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles are adjacent.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Adjacent2()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,0,20" + Environment.NewLine +
            "10,20,5,10" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles are adjacent.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Adjacent3()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,5,20" + Environment.NewLine +
            "10,20,0,10" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles are adjacent.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Adjacent4()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,20,10,20" + Environment.NewLine +
            "0,20,0,10" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles are adjacent.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Invalid1()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,0,0,0" + Environment.NewLine +
            "0,20,0,10" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The first rectangle is not valid.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Invalid2()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,20,0,10" + Environment.NewLine +
            "0,0,0,0" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The second rectangle is not valid.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Invalid3()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "10,10,0,5" + Environment.NewLine +
            "10,20,10,20" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The first rectangle is not valid.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Invalid4()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,5,5" + Environment.NewLine +
            "10,20,10,20" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The first rectangle is not valid.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Invalid5()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,5,20,10" + Environment.NewLine +
            "10,20,10,20" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The first rectangle is not valid.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Invalid6()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "20,10,0,10" + Environment.NewLine +
            "10,20,10,20" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The first rectangle is not valid.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Equal()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,0,10" + Environment.NewLine +
            "0,10,0,10" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "The rectangles are equal.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }

    [TestMethod]
    public void Invalid7()
    {
        var originalInput = Console.In;
        var originalOutput = Console.Out;

        // left,right,top,bottom
        using var input = new StringReader(
            "0,10,0,10" + Environment.NewLine +
            "0" + Environment.NewLine);

        using var output = new StringWriter();

        try
        {
            Console.SetIn(input);
            Console.SetOut(output);

            Program.Main([]);

            var consoleOutput = output.ToString();

            StringAssert.Contains(
                consoleOutput,
                "Invalid input. Please enter exactly 4 coordinates.");
        }
        finally
        {
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
}