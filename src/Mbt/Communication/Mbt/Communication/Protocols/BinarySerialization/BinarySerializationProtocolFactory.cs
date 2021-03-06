﻿namespace Hik.Communication.Mbt.Communication.Protocols.BinarySerialization
{
    /// <summary>
    /// This class is used to create Binary Serialization Protocol objects.
    /// </summary>
    public class BinarySerializationProtocolFactory : IMbtWireProtocolFactory
    {
        /// <summary>
        /// Creates a new Wire Protocol object.
        /// </summary>
        /// <returns>Newly created wire protocol object</returns>
        public IMbtWireProtocol CreateWireProtocol()
        {
            return new BinarySerializationProtocol();
        }
    }
}
