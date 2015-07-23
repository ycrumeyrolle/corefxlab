// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading;
using Xunit;
using System.Drawing.Graphics;
using System.IO;


public partial class GraphicsUnitTests
{

    /*DEMO*/

<<<<<<< HEAD
=======
    [Fact]
    public static void DemoPresention()
    {
        System.Console.WriteLine("hi");
        System.Console.WriteLine("ayo");

        /*Reading and Writing to a file*/

        //string filepath = @"C:\Users\t-xix\Pictures\Demo\BlackCat.png";
        //Image fromFile = Png.Load(filepath);
        //Png.WriteToFile(fromFile, @"C:\Users\t-xix\Pictures\Results\BlackCatWrite.png");


        ///*Resizing an Image*/

        //string filepath = @"C:\Users\t-xix\Pictures\Demo\SquareCat.jpg";
        //Image fromFileResizeSquare = Jpg.Load(filepath);
        //fromFileResizeSquare = fromFileResizeSquare.Resize(100, 100);
        ////arbitraily passing in pixelformat.argb now 
        //ValidateImage(fromFileResizeSquare, 100, 100);
        //Jpg.WriteToFile(fromFileResizeSquare, @"C:\Users\t-xix\Pictures\Results\SquareCatResizedWrite.jpg");


        ///*Changing Transparency*/

        //Image blackCat = Png.Load(@"C:\Users\t-xix\Pictures\Demo\BlackCat.png");
        //ValidateImage(blackCat, 220, 220);
        //blackCat.SetAlphaPercentage(50);
        //ValidateImage(blackCat, 220, 220);
        //Png.WriteToFile(blackCat, @"C:\Users\t-xix\Pictures\Results\BlackCatTransparencyWrite.png");

        ///*Drawing an Image onto another*/

        //open square cat image
        //Image squareCat = Jpg.Load(@"C:\Users\t-xix\Pictures\Demo\SquareCat.jpg");
        //ValidateImage(squareCat, 600, 701);
        ////open black cat image
        //Image blackCat = Png.Load(@"C:\Users\t-xix\Pictures\Demo\BlackCat.png");
        //ValidateImage(blackCat, 220, 220);
        ////draw & Write
        //squareCat.Draw(blackCat, 0, 0);
        //Jpg.WriteToFile(squareCat, @"C:\Users\t-xix\Pictures\Results\SquareCatDrawWrite.jpg");


        /*Water-Marking an Image*/

        ////black cat load
        //Image blackCat = Png.Load(@"C:\Users\t-xix\Pictures\Demo\BlackCat.png");
        //ValidateImage(blackCat, 220, 220);
        //blackCat.SetAlphaPercentage(20);
        ////square cat load
        //Image squareCat = Jpg.Load(@"C:\Users\t-xix\Pictures\Demo\SquareCat.jpg");
        //ValidateImage(squareCat, 600, 701);
        //squareCat.Draw(blackCat, 0, 0);
        //ValidateImage(squareCat, 600, 701);
        ////write
        //Jpg.WriteToFile(squareCat, @"C:\Users\t-xix\Pictures\Results\SquareCatWatermarkWrite.jpg");


        /* Reading from a stream */
        //FileStream filestream = new FileStream(@"C:\Users\t-xix\Pictures\Demo\BlackCat.png", FileMode.Open);
        //Image catStreamTest = Png.Load((Stream)filestream);
        //Png.WriteToFile(catStreamTest, @"C:\Users\t-xix\Pictures\Results\StreamWrite.png");

        /* Writing to a stream */
        //using (var stream = new MemoryStream())
        //{
        //    //load an image to file & change transparency
        //    Image squareCat = Jpg.Load(@"C:\users\t-xix\Pictures\Demo\SquareCat.jpg");
        //    squareCat.SetAlphaPercentage(10);

        //    Jpg.WriteToStream(squareCat, stream);
        //    stream.Position = 0;
        //    Image streamTest = Jpg.Load((Stream)stream);

        //    Jpg.WriteToFile(streamTest, @"C:\Users\t-xix\Pictures\Results\StreamWrite.jpg");
        //}
    }

>>>>>>> upstream/master
    private static void ValidateImage(Image img, int widthToCompare, int heightToCompare)
    {
        Assert.Equal(img.WidthInPixels, widthToCompare);
        Assert.Equal(img.HeightInPixels, heightToCompare);
    }

<<<<<<< HEAD
    //* Tests Create Method */
=======
    //[Fact]
    //public static void Test2()
    //{
    //    FileStream filestream = new FileStream(@"C:\Users\t-dahid\Pictures\BlackCat.png", FileMode.Open);

    //    Image catStreamTest = Png.Load((Stream)filestream);
    //    Png.WriteToFile(catStreamTest, @"C:\Users\t-dahid\Pictures\TestWrite1.png");


    //    using (var stream = new MemoryStream())
    //    {
    //        //load an image to file & change transparency
    //        Image soccerCat = Jpg.Load(@"C:\users\t-dahid\Pictures\SoccerCat.jpg");
    //        soccerCat.SetAlphaPercentage(10);

    //        Jpg.WriteToStream(soccerCat, stream);
    //        stream.Position = 0;
    //        Image soccerCatTest = Jpg.Load((Stream)stream);

    //        Jpg.WriteToFile(soccerCatTest, @"C:\Users\t-dahid\Pictures\StreamTest2SoccercAT.jpg");
    //    }


    //    Image cat1 = Png.Load(@"C:\Users\t-dahid\Pictures\BlackCat.png");
    //    Image cat2 = Jpg.Load(@"C:\Users\t-dahid\Pictures\SquareCat.jpg");

    //    cat1.SetAlphaPercentage(40);
    //    Png.WriteToFile(cat1, @"C:\Users\t-dahid\Pictures\TransparentBlackCat.png");

    //    Image transparentCat1 = Png.Load(@"C:\Users\t-dahid\Pictures\TransparentBlackCat.png");
    //    cat2.Draw(transparentCat1, 0, 1);
    //    Png.WriteToFile(cat2, @"C:\Users\t-dahid\Pictures\TestWrite2.png");
    //}




    /////* Tests Create Method */
>>>>>>> upstream/master

    [Fact]
    public static void WhenCreatingAnEmptyImageThenValidateAnImage()
    {
        ////create an empty 10x10 image
        Image emptyTenSquare = Image.Create(10, 10);
        ValidateImage(emptyTenSquare, 10, 10);
    }
    [Fact]
    public void WhenCreatingABlankImageWithNegativeHeightThenThrowException()
    {
        Assert.Throws<InvalidOperationException>(() => Image.Create(1, -1));
    }
    [Fact]
    public void WhenCreatingABlankImageWithNegativeWidthThenThrowException()
    {
        Assert.Throws<InvalidOperationException>(() => Image.Create(-1, 1));
    }
    [Fact]
    public void WhenCreatingABlankImageWithNegativeSizesThenThrowException()
    {
        Assert.Throws<InvalidOperationException>(() => Image.Create(-1, -1));
    }
    [Fact]
    public void WhenCreatingABlankImageWithZeroHeightThenThrowException()
    {
       Assert.Throws<InvalidOperationException>(() => Image.Create(1, 0));
    }
    [Fact]
    public void WhenCreatingABlankImageWithZeroWidthThenThrowException()
    {
        Assert.Throws<InvalidOperationException>(() => Image.Create(0, 1));
    }
    [Fact]
    public void WhenCreatingABlankImageWithZeroParametersThenThrowException()
    {
        Assert.Throws<InvalidOperationException>(() => Image.Create(0, 0));
    }
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenCreatingAnImageFromAValidFileGiveAValidImage()
    {
        //checking with cat image
        string filepath = @"C:\Users\t-dahid\Pictures\DemoPictures\1-ImageEx\SquareCat.jpg";
        Image fromFile = Jpg.Load(filepath);
        ValidateImage(fromFile, 600, 701);
    }

    //File I/O should be returning exceptions --> HOW TO DO THIS?!!?
    //Invalid file path
    //Path not found
    //Path not an image

    /* Tests Load(filepath) method */
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenCreatingAnImageFromAMalformedPathThenThrowException()
    {
        //place holder string to demonstrate what would be the error case
        string invalidFilepath = @"C:Users\t-dahid\Pictures\DemoPictures\1-ImageEx\SquareCat.jpg";
        Exception exception = Assert.Throws<FileNotFoundException>(() => Jpg.Load(invalidFilepath));
        Assert.Equal("Malformed file path given.", exception.Message);
    }
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenCreatingAnImageFromAnUnfoundPathThenThrowException()
    {
        //place holder string to demonstrate what would be the error case
        string invalidFilepath = @"C:\Users\t-dahid\Pictures\DemoPictures\1-ImageEx\SquareDog.jpg";
        Exception exception = Assert.Throws<FileNotFoundException>(() => Jpg.Load(invalidFilepath));
        Assert.Equal("Malformed file path given.", exception.Message);
    }
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenCreatingAnImageFromAFileTypeThatIsNotAnImageThenThrowException()
    {
        //place holder string to demonstrate what would be the error case
        string invalidFilepath = @"C:\Users\t-dahid\Documents\GitHub\corefxlab\src\System.Drawing.Graphics\text.txt";
        Exception exception = Assert.Throws<FileLoadException>(() => Jpg.Load(invalidFilepath));
        Assert.Equal("File type not supported.", exception.Message);
    }

    /* Tests Load(stream) mehtod*/
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenCreatingAnImageFromAValidStreamThenGiveValidImage()
    {
        //placeholder stream
        Stream stream = null;
        Image fromStream = Jpg.Load(stream);
        //arbitraily passing in pixelformat.argb now and 0, 0
        ValidateImage(fromStream, 0, 0);
    }
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenCreatingAnImageFromAnInvalidStreamThenThrowException()
    {
        Stream stream = null;
        Exception exception = Assert.Throws<InvalidOperationException>(() => Png.Load(stream));
        Assert.Equal("Stream given is not valid", exception.Message);
    }

    /* Test Resize */
    [Fact]
    public void WhenResizingEmptyImageDownThenGiveAValidatedResizedImage()
    {
        Image emptyResizeSquare = Image.Create(100, 100);
        emptyResizeSquare = emptyResizeSquare.Resize(10, 10);
        //arbitraily passing in pixelformat.argb now 
        ValidateImage(emptyResizeSquare, 10, 10);
    }
    [Fact]
    public void WhenResizingEmptyImageUpThenGiveAValidatedResizedImage()
    {
        Image emptyResizeSquare = Image.Create(100, 100);
        emptyResizeSquare = emptyResizeSquare.Resize(200, 200);
        //arbitraily passing in pixelformat.argb now 
        ValidateImage(emptyResizeSquare, 200, 200);
    }
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenResizingImageLoadedFromFileThenGiveAValidatedResizedImage()
    {
        string filepath = @"C:\Users\t-dahid\Pictures\DemoPictures\1-ImageEx\SquareCat.jpg";
        Image fromFileResizeSquare = Jpg.Load(filepath);
        fromFileResizeSquare = fromFileResizeSquare.Resize(100, 100);
        //arbitraily passing in pixelformat.argb now 
        ValidateImage(fromFileResizeSquare, 100, 100);
        Jpg.WriteToFile(fromFileResizeSquare, @"C:\Users\t-dahid\Pictures\TESTCATResized.jpg");
    }
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenResizingImageLoadedFromStreamThenGiveAValidatedResizedImage()
    {
        Stream stream = null;
        Image fromStreamResizeSquare = Jpg.Load(stream);
        fromStreamResizeSquare.Resize(10, 10);
        //arbitraily passing in pixelformat.argb now 
        ValidateImage(fromStreamResizeSquare, 10, 10);
    }

    /* Testing Resize parameters */
    [Fact]
    public void WhenResizingImageGivenNegativeHeightThenThrowException()
    {
        Image img = Image.Create(1, 1);
        //Not sure if this is how to do this
        Assert.Throws<InvalidOperationException>(() => img.Resize(-1, 1));
    }
    [Fact]
    public void WhenResizingImageGivenNegativeWidthThenThrowException()
    {
        Image img = Image.Create(1, 1);
        //Not sure if this is how to do this
        Assert.Throws<InvalidOperationException>(() => img.Resize(1, -1));
    }
    [Fact]
    public void WhenResizingImageGivenNegativeSizesThenThrowException()
    {
        Image img = Image.Create(1, 1);
        //Not sure if this is how to do this
        Exception exception = Assert.Throws<InvalidOperationException>(() => img.Resize(-1, -1));
        Assert.Equal("Parameters for resizing an image must be positive integers.", exception.Message);
    }
    [Fact]
    public void WhenResizingImageGivenZeroHeightThenThrowException()
    {
        Image img = Image.Create(1, 1);
        //Not sure if this is how to do this
        Exception exception = Assert.Throws<InvalidOperationException>(() => img.Resize(0, 1));
        Assert.Equal("Parameters for resizing an image must be positive integers.", exception.Message);
    }
    [Fact]
    public void WhenResizingImageGivenZeroWidthThenThrowException()
    {
        Image img = Image.Create(1, 1);
        //Not sure if this is how to do this
        Exception exception = Assert.Throws<InvalidOperationException>(() => img.Resize(1, 0));
        Assert.Equal("Parameters for resizing an image must be positive integers.", exception.Message);
    }
    [Fact]
    public void WhenResizingImageGivenZeroSizesThenThrowException()
    {
        Image img = Image.Create(1, 1);
        //Not sure if this is how to do this
        Exception exception = Assert.Throws<InvalidOperationException>(() => img.Resize(0, 0));
        Assert.Equal("Parameters for resizing an image must be positive integers.", exception.Message);
    }

    /* Tests Writing to a file*/
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenWritingABlankCreatedImageToAValidFileWriteToAValidFile()
    {
        Image emptyImage = Image.Create(10, 10);
        ValidateImage(emptyImage, 10, 10);
        Jpg.WriteToFile(emptyImage, @"C:\Users\t-dahid\Pictures\TESTBlankWrite.jpg");
    }
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenWritingAnImageCreatedFromFileToAValidFileWriteAValidImage()
    {
        //checking with cat image
        string filepath = @"C:\Users\t-dahid\Pictures\DemoPictures\1-ImageEx\SquareCat.jpg";
        Image fromFile = Jpg.Load(filepath);
        ValidateImage(fromFile, 600, 701);
        Jpg.WriteToFile(fromFile, @"C:\Users\t-dahid\Pictures\TTestCatWrite.jpg");
    }

    /* Test Draw */
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenDrawingTwoImagesWriteACorrectResult()
    {
        //open yellow cat image
        Image yellowCat = Jpg.Load(@"C:\Users\t-dahid\Pictures\DemoPictures\1-ImageEx\SquareCat.jpg");
        ValidateImage(yellowCat, 600, 701);
        //open black cat image
        Image blackCat = Jpg.Load(@"C:\Users\t-dahid\Pictures\BlackCat.png");
        ValidateImage(blackCat, 220, 220);
        //draw & Write
        yellowCat.Draw(blackCat, 0, 0);
        Jpg.WriteToFile(yellowCat, @"C:\Users\t-dahid\Pictures\DrawTest.png");
    }
    /* Test SetTransparency */
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenSettingTheTransparencyOfAnImageWriteAnImageWithChangedTransparency()
    {
        //open black cat image
        Image blackCat0 = Png.Load(@"C:\Users\t-dahid\Pictures\BlackCat.png");
        ValidateImage(blackCat0, 220, 220);
        blackCat0.SetAlphaPercentage(0);
        ValidateImage(blackCat0, 220, 220);
        Png.WriteToFile(blackCat0, @"C:\Users\t-dahid\\Pictures\SetTransparencyTest0.png");

        Image blackCat1 = Png.Load(@"C:\Users\t-dahid\Pictures\BlackCat.png");
        ValidateImage(blackCat1, 220, 220);
        blackCat1.SetAlphaPercentage(10);
        ValidateImage(blackCat1, 220, 220);
        Png.WriteToFile(blackCat1, @"C:\Users\t-dahid\\Pictures\SetTransparencyTest1.png");
    }
    /* Test Draw and Set Transparency */
    [Fact(Skip = "Not Implemented yet...")]
    public void WhenDrawingAnImageWithTransparencyChangedGiveACorrectWrittenFile()
    {
        //black cat load
        Image blackCat = Png.Load(@"C:\Users\t-dahid\Pictures\BlackCat.png");
        ValidateImage(blackCat, 220, 220);
        blackCat.SetAlphaPercentage(20);
        //yellow cat load
        Image yellowCat = Jpg.Load(@"C:\Users\t-dahid\Pictures\DemoPictures\1-ImageEx\SquareCat.jpg");
        ValidateImage(yellowCat, 600, 701);
        yellowCat.Draw(blackCat, 0, 0);
        ValidateImage(yellowCat, 600, 701);
        //write
        Png.WriteToFile(yellowCat, @"C:\Users\t-dahid\Pictures\DrawAndTransparencyTest.png");

    }

}




