﻿namespace XmlRpc.Client.Model
{
    public class XmlRpcResponse
    {
        public XmlRpcResponse()
        {
            retVal = null;
        }

        public XmlRpcResponse(object retValue)
        {
            retVal = retValue;
        }

        public object retVal;
    }
}