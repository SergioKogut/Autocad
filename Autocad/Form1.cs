using AutoCAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Autocad
{
    public partial class Form1 : Form
    {
        // Creating object reference to hold the reference of the circle to be created.
        private AcadCircle Circle = default(AcadCircle);

        // Creating object reference to hold the reference of running AutoCAD instance.
        private AcadApplication AcadApp = default(AcadApplication);


        public Form1()
        {
            InitializeComponent();
            AcadApp = (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application");
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            //
            AcadLine Line= default(AcadLine);

            //  AcadLine acLine = new AcadLine(new AcadPoint(5, 5, 0), new AcadPoint(12, 3, 0));
            //Line = AcadApp.ActiveDocument.ModelSpace.AddLine(new AcadPoint(5, 5, 0),);

            

        }

        private void btnCaption_Click(object sender, EventArgs e)
        {
            // Caption - AcadText object to hold the reference of the AcadText 
            AcadText Caption = default(AcadText);

            // Syntax for creating Text in AutoCAD
            // AcadApp.ActiveDocument.ModelSpace.AddText(TextString, InsertionPoint, Height);
            // 
            // AcadApp        - Reference to the running instance of AutoCAD.
            // ActiveDocument - Represents the current working drawing in AutoCAD.
            // ModelSpace     - Work Area in the current drawing.
            // AddText        - Method, which adds a Text to the modelspace of the current drawing using the TextString, InsertionPoint and Height.
            // TextString     - string, which represents the text to be written.
            // InsertionPoint - 3 Dimensional double array variable holds the insertion point of the circle in the X, Y and Z axis.
            // Height         - Double variable holds the height of text.

            // Text to be written just below the circle as a caption.
            string TextString = "CIRCLE";

            // Definfing the insertion point for the circle, in this example, we are going to place the text just below the circle.
            double[] InsertionPoint = new double[3];

            // Getting Centerpoint of circle we have created earlier to define the insertion point for the Caption.
            double[] CenterOfCircle = (double[])Circle.Center;

            InsertionPoint[0] = 0;
            InsertionPoint[1] = 0;
            InsertionPoint[2] = 0;

            // Defining height of the text
            double Height = 200;

            // Adding text to the modelspace and getting reference to the text created.
            Caption = AcadApp.ActiveDocument.ModelSpace.AddText(TextString, InsertionPoint, Height);

            // Changing the text color
            Caption.color = ACAD_COLOR.acGreen;
            
        }

        private void DrawCircle(double StartingXPoint, double StartingYPoint, double Radius)

        {
            AcadCircle circleObj;
            double[] centerPoint = new double[3];

            centerPoint[0] = StartingXPoint;
            centerPoint[1] = StartingYPoint;
            centerPoint[2] = 0.0;
            circleObj = AcadApp.ActiveDocument.ModelSpace.AddCircle(centerPoint, Radius);

        }



        public void Line(double[] Point1, double[] Point2, ACAD_COLOR LineColor)
        {
            
            AcadLine AClineSample = default(AcadLine);
            AClineSample = AcadApp.ActiveDocument.ModelSpace.AddLine(Point1, Point2);
            AClineSample.color = LineColor;
         
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            

          //  AcadApp = (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application");

            // Now AcadApp has the reference to the running AutoCAD instance, AcadApp object acts as a port for accessing running instance of AutoCAD.

            // Syntax for creating circle in AutoCAD
            // AcadApp.ActiveDocument.ModelSpace.AddCircle(CenterOfCircle, RadiusOfCircle);
            //
            // AcadApp        - Reference to the running instance of AutoCAD.
            // ActiveDocument - Represents the current working drawing in AutoCAD.
            // ModelSpace     - Work Area in the current drawing.
            // AddCricle      - Method, which adds a circle to the modelspace of the current drawing using the CenterPoint and Radius.
            // CenterOfCircle - 3 Dimensional double array variable holds the center point of the circle in the X, Y and Z axis.
            // RadiusOfCircle - Double variable holds the radius of circle.

            // Definfing the center point for the circle, in this example, we are using origin(0,0,0) as the center of circle.
            double[] CenterOfCircle = new double[3];
            CenterOfCircle[0] = 0;
            CenterOfCircle[1] = 0;
            CenterOfCircle[2] = 0;

            // Defining radius of circle from the user input.
            double RadiusOfCircle = Convert.ToDouble(txtRadius.Text.Trim());


            // Adding Circle to the modelspace and getting reference to the circle created.
            Circle = AcadApp.ActiveDocument.ModelSpace.AddCircle(CenterOfCircle, RadiusOfCircle);


        }
    }
}
