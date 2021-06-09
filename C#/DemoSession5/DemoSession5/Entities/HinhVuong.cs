using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class HinhVuong : HinhHoc
    {
        public string Name { get; set; }
        public double Canh { get; set; }

        

        public override double ChuVi()
        {
            return Canh * 4;
        }

        public override double DienTich()
        {
            return Canh * Canh;
        }
    }
}
