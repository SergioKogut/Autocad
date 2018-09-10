using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AutoCAD;

namespace Autocad
{
    class Autocad
    {
        private AcadApplication AcadApp = default(AcadApplication);

        //-----------------------------------------------------------------

        private AcadApplication gbl_app;
        private AcadDocument gbl_doc;

       // public static  AcadModelSpaceClass gbl_modSpace;

        private AcadAcCmColor gbl_color;

        private double gbl_pi = 3.14159;

        private AcadLayer TerminalsLayer; //Layer For Donuts 

        private AcadLayer SwitchLayer;

        private AcadLayer TerminationPoints; //Layer Termination Points 

        private void CreateAutoCADObject()

        {

            try

            {

                CloseAllInstance(); // this method is used to close any opened instance of autocad, if you dont require it then comment it 

                gbl_app = new AcadApplication();

                gbl_doc = gbl_app.ActiveDocument;

                gbl_app.Application.Visible = true;

              //  gbl_modSpace = (AcadModelSpaceClass)gbl_doc.ModelSpace;

                gbl_doc.Linetypes.Load("HIDDEN", "acad.lin");

                gbl_doc.Linetypes.Load("CENTER", "acad.lin");

                //Other Objects Layer 

                SwitchLayer = gbl_doc.Layers.Add("Switch110Layer");

                SwitchLayer.color = AutoCAD.AcColor.acGreen;

                gbl_doc.ActiveLayer = SwitchLayer;

                //Layer For Donuts 

                TerminalsLayer = gbl_doc.Layers.Add("TerminalsLayer");

                TerminalsLayer.color = AutoCAD.AcColor.acRed;

                //Layer Termination Points 

                TerminationPoints = gbl_doc.Layers.Add("TerminationPoints");

                TerminationPoints.color = AutoCAD.AcColor.acWhite;

            }

            catch (Exception ex)

            {

            //    MessageBox.Show(ex.Message);

            }

        }

        private void CloseAllInstance()
        {
            Process[] aCAD = Process.GetProcessesByName("acad");
            foreach (Process aCADPro in aCAD)

            {
                aCADPro.CloseMainWindow();
            }
        }



        // креслення лінії (Line)
        public void Line(double StartX1, double StartY1, double EndX2, double EndY2, string LineType)
         {
            //Створюємо об'єкт Line
            AcadLine lineObj;
           
            //створюємо масиви для початку і кінця лінії
            double[] startPoint = new double[3];
            double[] endPoint = new double[3];

            // задаємо  координати початкової точки
            startPoint[0] = StartX1;
            startPoint[1] = StartY1;
            startPoint[2] = 0.0;

            // задаємо  координати кінцевої точки
            endPoint[0] = EndX2;
            endPoint[1] = EndY2;
            endPoint[2] = 0.0;

            // креслимо лінію в автокаді
            lineObj = AcadApp.ActiveDocument.ModelSpace.AddLine(startPoint, endPoint);

            // перевірка чи довжина не нуль
            if (LineType.Length > 0)
            {
                lineObj.Linetype = LineType; //'"HIDDEN" 
                lineObj.LinetypeScale = 10;
                lineObj.Update();
                
            }
            AcadApp.ZoomAll();
        }

        // написання тексту (Text)
        private void Text(double StartingXPoint, double StartingYPoint, string textString, double Height, double Rotation)
        {
            //Створюємо об'єкт Text
            AcadText textObj;
         
            double[] insertionPoint = new double[3];

            insertionPoint[0] = StartingXPoint;
            insertionPoint[1] = StartingYPoint;
            insertionPoint[2] = 0.0;

            textObj = AcadApp.ActiveDocument.ModelSpace.AddText(textString, insertionPoint, Height);
            textObj.Alignment = AcAlignment.acAlignmentLeft;
            textObj.Backward = false;
            textObj.Rotation = Rotation;
                
        }

        // креслення круга (Circle)
        private void Circle(double CenterXPoint, double CenterYPoint, double Radius, string LineType, double ThicknessCircle)
        {
            //Створюємо об'єкт Circle
            AcadCircle circleObj;

            double[] centerPoint = new double[3];

            centerPoint[0] = CenterXPoint;
            centerPoint[1] = CenterYPoint;
            centerPoint[2] = 0.0;


            circleObj = AcadApp.ActiveDocument.ModelSpace.AddCircle(centerPoint, Radius);

            if (circleObj.Radius > 0)
            {
                circleObj.Linetype = LineType; //'"HIDDEN" 
                circleObj.Thickness = ThicknessCircle;
                circleObj.Update();
            }
        }
    }
}
