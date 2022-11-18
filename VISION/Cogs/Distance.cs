using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISION.Cogs
{
    public class Distance
    {
        private Cognex.VisionPro.Dimensioning.CogDistancePointPointTool Tool;

        public Distance(int Toolnumber)
        {
            Tool = new Cognex.VisionPro.Dimensioning.CogDistancePointPointTool();
            Tool.Name = "Distance - " + Toolnumber.ToString();
        }


        public string ToolName(int toolnum)
        {
            return Tool.Name;
        }

        private bool NewTool()
        {
            Tool.StartX = 10;
            Tool.StartY = 10;
            Tool.EndX = 70;
            Tool.EndY = 40;

            return true;
        }

        /// <summary>
        /// 파일에서 툴을 불러 옴. 파일이 있는 폴더의 경로만 제공 하면 됨.
        /// </summary>
        /// <param name="path">파일이 있는  폴더의 경로</param>
        /// <returns></returns>
        public bool Loadtool(string path, int num)
        {
            string Savepath = path;

            if (System.IO.Directory.Exists(Savepath) == false)
            {
                NewTool();
                return true;
            }
           
                Savepath = Savepath + "\\" + Tool.Name + ".vpp";

            if (System.IO.File.Exists(Savepath) == false)
            {
                NewTool();
                return false;
            }

            Tool = (Cognex.VisionPro.Dimensioning.CogDistancePointPointTool)CogSerializer.LoadObjectFromFile(Savepath);

            return true;
        }

        /// <summary>
        /// 파일에 툴의 정보를 씀. 대상 파일이 위치 할 폴더의 경로만 제공 하면 됨.
        /// </summary>
        /// <param name="path">저장 할 대상 폴더의 경로</param>
        /// <returns></returns>
        public bool Savetool(string path, int num)
        {
            string Savepath = path;

            if (System.IO.Directory.Exists(Savepath) == false)
            {
                return false;
            }

            Savepath = Savepath + "\\" + Tool.Name + ".vpp";
            CogSerializer.SaveObjectToFile(Tool, Savepath);

            return true;
        }

        /// <summary>
        /// 툴에 이미지 입력
        /// </summary>
        /// <param name="image">툴에 입력 할 이미지</param>
        /// <returns></returns>
        public bool InputImage(int toolnum, CogImage8Grey image)
        {
            if (image == null)
            {
                return false;
            }

            Tool.InputImage = image;
            return true;
        }
        public void ResultDisplay(int toolnum, Cognex.VisionPro.Display.CogDisplay display, CogGraphicCollection Collection)
        {
            CogLineSegment segment;
            try
            {
                segment = (CogLineSegment)Tool.CreateLastRunRecord().SubRecords["InputImage"].SubRecords["Arrow"].Content;
                Collection.Add(segment);
                display.StaticGraphics.AddList(Collection, "");
            }
            catch (Exception ee)
            {
                return;
            }
        }
        public double DistanceValue(int toolnum)
        {
            try
            {
                return Tool.Distance;
            }
            catch (Exception ee)
            {
                return 0;
            }

        }
        public bool Run(int toolnum, CogImage8Grey image)
        {
            if (!InputImage(toolnum, image))
            {
                return false;
            }

            Tool.Run();

            return true;
        }

        public bool InputStartXY(double StX, double StY)
        {
            if (StX == 0 || StY == 0)
                return false;

            Tool.StartX = StX;
            Tool.StartY = StY;

            return true;
        }

        public bool InputEndXY(double EndX, double EndY)
        {
            if (EndX == 0 || EndY == 0)
                return false;

            Tool.EndX = EndX;
            Tool.EndY = EndY;

            return true;
        }

        public double GetX(int toolnum)
        {
            return Tool.StartX;
        }
        public double GetY(int toolnum)
        {
            return Tool.StartY;
        }
        /// <summary>
        /// 검사 툴 전체 셋업 화면을 화면에 표시
        /// </summary>
        public void ToolSetup(int toolnum)
        {
            System.Windows.Forms.Form Window = new System.Windows.Forms.Form();
            Cognex.VisionPro.Dimensioning.CogDistancePointPointEditV2 Edit = new Cognex.VisionPro.Dimensioning.CogDistancePointPointEditV2();

            Edit.Dock = System.Windows.Forms.DockStyle.Fill; // 화면 채움
            Edit.Subject = Tool; // 에디트에 툴 정보 입력.
            Window.Controls.Add(Edit); // 폼에 에디트 추가.

            Window.Width = 800;
            Window.Height = 600;

            Window.Show(); // 폼 실행

        }
    }
}

