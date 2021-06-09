using finale.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finale
{
    class StudentLib
    {
        public delegate void Find(SinhVien sinhVien, string key);
        public event Find ID;
        public event Find Name;


        public void Run(List<SinhVien> SinhViens, string key)
        {
            foreach (var sinhvien in SinhViens)
            {
                if (sinhvien.ID.Contains(key))
                {
                    if (ID != null)
                    {
                        ID(sinhvien, key);
                    }
                }

                if (sinhvien.Name.Contains(key))
                {
                    if (Name != null)
                    {
                        Name(sinhvien, key);
                    }
                }
            }

        }
    }
}
