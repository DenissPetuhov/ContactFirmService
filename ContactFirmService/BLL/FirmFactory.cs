using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFirmService.BLL
{
    public class FirmFactory
    {
        private static FirmFactory? Instance;
        protected FirmFactory()
        {

        }
        public static FirmFactory GetInstance()
        {
            if (Instance == null)
                Instance = new FirmFactory();
            return Instance;
        }
        private string[] NameMain = new string[5];
        public string[] flds = new string[5];
        public void SetNamesflds(string Key1, string Key2, string Key3, string Key4, string Key5)
        {
            NameMain[0] = Key1;
            NameMain[1] = Key2;
            NameMain[2] = Key3;
            NameMain[3] = Key4;
            NameMain[4] = Key5;
        }
        public void Setflds(string line1, string line2, string line3, string line4, string line5)
        {
            flds[0] = line1;
            flds[1] = line2;
            flds[2] = line3;
            flds[3] = line4;
            flds[4] = line5;
        }
        public Firm Create(string nameFirm)
        {
            Firm firm;
            if (flds!=null&& NameMain != null)
            {
                Dictionary<string, string> newflds = new Dictionary<string, string>()
                {
                    { NameMain[0], flds[0] },
                    { NameMain[1], flds[1] },
                    { NameMain[2], flds[2] },
                    { NameMain[3], flds[3] },
                    { NameMain[4], flds[4] }

                };
                firm = new Firm(nameFirm, newflds);
                return firm;
            }
            return null;
        
        }


    }
}
