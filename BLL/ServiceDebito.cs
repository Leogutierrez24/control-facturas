using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiceDebito
    {
        private static ServiceDebito instance = null;
        private DAL.DebitoMapper mapper;

        private ServiceDebito() 
        { 
            mapper = DAL.DebitoMapper.GetInstance();
        }

        public static ServiceDebito GetInstance()
        {
            if (instance == null) instance = new ServiceDebito();
            return instance;
        }

        public int Load(BE.Debito debito)
        {
            int result = mapper.Insert(debito);
            return result != 0 ? 0 : -1;
        }

        public int Modify()
        {
            return 0;
        }
    }
}
