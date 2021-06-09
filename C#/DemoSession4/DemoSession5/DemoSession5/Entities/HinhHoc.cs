using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public abstract class HinhHoc
    {
        //HinhHoc hinhhoc1 = new HinhHoc(); --> báo lỗi
        //HinhHoc hinhhoc1 = new HinhVuong() --> ok
        public string Name { get; set; }
        public abstract double DienTich();
        public abstract double ChuVi();
        
    }
}
