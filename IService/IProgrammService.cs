﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    [ServiceContract]
    public interface IProgrammService
    {
        [OperationContract]
        string Msg(string msg);
    }
}
