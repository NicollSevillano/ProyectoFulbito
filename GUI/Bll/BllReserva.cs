﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be;
using Interface;
using Mapper;

namespace Bll
{
    public class BllReserva : IABMC<BeReserva>
    {
        MapperReserva mReserva = new MapperReserva();
        public void Alta(BeReserva pObject)
        {
            mReserva.Alta(pObject);
        }

        public void Baja(int pId)
        {
            throw new NotImplementedException();
        }

        public List<BeReserva> Consulta()
        {
            return mReserva.Consulta();
        }

        public List<BeReserva> ConsultaCondicional(string pCondicion, string pCondicion2 = null)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(BeReserva pObject)
        {
            throw new NotImplementedException();
        }
    }
}
