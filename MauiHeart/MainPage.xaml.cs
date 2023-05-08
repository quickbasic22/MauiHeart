using Microsoft.Maui.Controls.Shapes;

namespace MauiHeart;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Microsoft.Maui.Controls.Shapes.PathFigure figure1 = new Microsoft.Maui.Controls.Shapes.PathFigure();
		figure1.StartPoint = new Point(100, 100);
		figure1.Segments.Add(new BezierSegment(new Point(70, 50), new Point(40, 120), new Point(100, 200)));
		figure1.Segments.Add(new BezierSegment(new Point(160, 120), new Point(130, 50), new Point(100, 100)));
		figure1.Segments.Add(new LineSegment(new Point(100, 100)));
	
		Microsoft.Maui.Controls.Shapes.PathFigureCollection figureCollection = new Microsoft.Maui.Controls.Shapes.PathFigureCollection();
		figureCollection.Add(figure1);
		Microsoft.Maui.Controls.Shapes.PathGeometry pathGeometry = new Microsoft.Maui.Controls.Shapes.PathGeometry(figureCollection);
		Microsoft.Maui.Controls.Shapes.Path firstHeart = new Microsoft.Maui.Controls.Shapes.Path(pathGeometry);
		firstHeart.StrokeThickness = 2.0;
		firstHeart.Stroke = Colors.Red;
		firstHeart.Fill = Colors.Red;
		firstHeart.TranslationY = -400.0;
		firstHeart.TranslationX = 500.0;
		firstHeart.Scale = 1.0;
		MyVerticalStackLayout.Add(firstHeart);

		
        Microsoft.Maui.Controls.Shapes.Path secondHeart = new Microsoft.Maui.Controls.Shapes.Path(pathGeometry);
		secondHeart.StrokeThickness = 2.0;
		secondHeart.Stroke = Colors.YellowGreen;
		secondHeart.Fill = Colors.Crimson;
		secondHeart.TranslationX = 250.0;
		secondHeart.TranslationY = -300.0;

        MyVerticalStackLayout.Add(secondHeart);

        Microsoft.Maui.Controls.Shapes.Path thirdHeart = new Microsoft.Maui.Controls.Shapes.Path(pathGeometry);
        thirdHeart.StrokeThickness = 2.0;
        thirdHeart.Stroke = Colors.YellowGreen;
        thirdHeart.Fill = Colors.Purple;
        thirdHeart.TranslationX = 100.0;
        thirdHeart.TranslationY = -100.0;
        

        MyVerticalStackLayout.Add(thirdHeart);

        //double transX = 100;

        //for (int i = 0;i < 6;i++)
        //{
        //	firstHeart.TranslationX += transX;
        //          MyVerticalStackLayout.Add(firstHeart);
        //      }

        //      transX = 0;
        //double transY = 250.0;

        //      for (int i = 0; i < 6; i++)
        //      {
        //          firstHeart.TranslationX += transX;
        //	firstHeart.TranslationY += transY;
        //          MyVerticalStackLayout.Add(firstHeart);
        //      }
        //      transX = 0;
        //      transY = 500.0;
        //      for (int i = 0; i < 6; i++)
        //      {
        //          firstHeart.TranslationX += transX;
        //          firstHeart.TranslationY += transY;
        //          MyVerticalStackLayout.Add(firstHeart);
        //      }
    }
}

