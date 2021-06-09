using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class HinhTron : HinhHoc
    {
        public string Name { get; set; }
        public double BanKinh { get; set; }

        
        public override double ChuVi()
        {
            return 2 * BanKinh * Math.PI;
        }

        public override double DienTich()
        {
            return Math.PI * Math.Pow(BanKinh,2);
        }
    }
}
