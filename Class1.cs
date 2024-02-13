using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt11_3._0
{
    internal class Room
    {
        private double length;
        private double width;
        private double height;
        private int nwindow;
        private double heightwindow;
        private double widthwindow;
        public void SetLength(double length1)
        {
            length = length1;
        }
        public void SetWidth(double width1)
        {
            width = width1;
        }
        public void SetHeight(double height1)
        {
            height = height1;
        }
        public void SetNwindow(int nwindow1)
        {
            nwindow = nwindow1;
        }
        public void SetHeightWindow(double heightwindow1)
        {
            heightwindow = heightwindow1;
        }
        public void SetWidthWindow(double widthwindow1)
        {
            widthwindow = widthwindow1;
        }
        public double SetSroom()
        {
            double Sroom = length * width;
            return Sroom;
        }
        public double SetVroom()
        {
            double Vroom = length * width * height;
            return Vroom;
        }
        public string Information()
        {
            string message = "";
            if (length > 0 && width > 0 && height > 0 && heightwindow > 0 && widthwindow > 0 && nwindow > 0)
            {
                if (height >= heightwindow && (width >= widthwindow || length >= widthwindow))
                {
                    message = $"Длина комнаты составляет {length} метров\n" +
                    $"Ширина комнаты составяет {width}\n" +
                    $"Высота потолков составяет {height}\n" +
                    $"Количество окон = {nwindow}\n" +
                    $"Ширина окон = {widthwindow}\n" +
                    $"Высота окон = {heightwindow}";
                }
            }
            return message;
        }
        public double Remont(double rulonlength)
        {
            double nrulon = -1;
            if (length > 0 && width > 0 && height > 0 && heightwindow > 0 && widthwindow > 0 && nwindow > 0)
            {
                if (height >= heightwindow && (width >= widthwindow || length >= widthwindow))
                {
                    double Swalls = height * width * 2 + height * length * 2 - nwindow * heightwindow * widthwindow;
                    if (Swalls > 0)
                        nrulon = Math.Floor(Swalls / (rulonlength * 0.5));
                }
            }
            return nrulon;
        }
        public double SetOSWindow()
        {
            double OSwindow = -1;
            if (heightwindow > 0 && widthwindow > 0 && nwindow > 0)
            {
                OSwindow = nwindow * heightwindow * widthwindow;
            }
            return OSwindow;
        }
    }
}
