﻿using ServiceReference1;
using System;
using System.Threading.Tasks;

namespace OpenSilverServiceProxy
{
    public class ServiceProxy
    {
        ServiceClient serviceClient;
        public ServiceProxy()
        {
            serviceClient = new ServiceClient();
        }

        public async Task<string> GetDataAsync(Int32 id)
        {
            return await serviceClient.GetDataAsync(id);
        }
    }
}
