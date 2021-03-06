﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using libMPSSEWrapper.Types;

namespace libMPSSEWrapper
{
    public class LibMpsseI2C
    {
        [DllImport(LibMpsse.DllName, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public extern static FtResult I2C_GetNumChannels(out int numChannels);

        [DllImport(LibMpsse.DllName, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern FtResult I2C_OpenChannel(int index, out System.IntPtr handle);

        [DllImport(LibMpsse.DllName, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern FtResult I2C_InitChannel(System.IntPtr handle, ref FtChannelConfig config);

        [DllImport(LibMpsse.DllName, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public extern static FtResult I2C_GetChannelInfo(int index, out FtDeviceInfo chanInfo);

        [DllImport(LibMpsse.DllName, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern FtResult I2C_DeviceRead(System.IntPtr handle, int deviceAddress, int sizeToTransfer, byte[] buffer, out int sizeTransfered, FtI2CTransferOptions options);

        [DllImport(LibMpsse.DllName, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern FtResult I2C_DeviceWrite(System.IntPtr handle, int deviceAddress, int sizeToTransfer, byte[] buffer, out int sizeTransfered, FtI2CTransferOptions options);


    }
}
