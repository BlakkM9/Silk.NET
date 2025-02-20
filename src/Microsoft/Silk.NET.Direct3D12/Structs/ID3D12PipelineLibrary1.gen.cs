// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("80eabf42-2568-4e5e-bd82-c37f86961dc3")]
    [NativeName("Name", "ID3D12PipelineLibrary1")]
    public unsafe partial struct ID3D12PipelineLibrary1 : IComVtbl<ID3D12PipelineLibrary1>, IComVtbl<ID3D12PipelineLibrary>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("80eabf42-2568-4e5e-bd82-c37f86961dc3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12PipelineLibrary(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, ID3D12PipelineLibrary>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12PipelineLibrary1
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline(char* pName, ID3D12PipelineState* pPipeline)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pName, pPipeline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline(char* pName, ref ID3D12PipelineState pPipeline)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pName, pPipelinePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline(ref char pName, ID3D12PipelineState* pPipeline)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipeline);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StorePipeline(ref char pName, ref ID3D12PipelineState pPipeline)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ID3D12PipelineState* pPipeline)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipeline);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StorePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ID3D12PipelineState pPipeline)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline(ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline(ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetSerializedSize()
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, nuint>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(void* pData, nuint DataSizeInBytes)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, void*, nuint, int>)@this->LpVtbl[12])(@this, pData, DataSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Serialize<T0>(ref T0 pData, nuint DataSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, void*, nuint, int>)@this->LpVtbl[12])(@this, pDataPtr, DataSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(char* pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline(ref char pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppPipelineStatePtr = &ppPipelineState)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineState);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, byte*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDevice = default;
            return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline<TI0>(char* pName, ComPtr<TI0> pPipeline) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StorePipeline(pName, (ID3D12PipelineState*) pPipeline.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int StorePipeline<TI0>(ref char pName, ComPtr<TI0> pPipeline) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StorePipeline(ref pName, (ID3D12PipelineState*) pPipeline.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int StorePipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComPtr<TI0> pPipeline) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->StorePipeline(pName, (ID3D12PipelineState*) pPipeline.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline<TI0>(char* pName, GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadGraphicsPipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline<TI0>(char* pName, ref GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadGraphicsPipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline<TI0>(ref char pName, GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadGraphicsPipeline(ref pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadGraphicsPipeline<TI0>(ref char pName, ref GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadGraphicsPipeline(ref pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadGraphicsPipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadGraphicsPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadGraphicsPipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline<TI0>(char* pName, ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadComputePipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline<TI0>(char* pName, ref ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadComputePipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline<TI0>(ref char pName, ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadComputePipeline(ref pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadComputePipeline<TI0>(ref char pName, ref ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadComputePipeline(ref pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadComputePipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadComputePipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadComputePipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline<TI0>(char* pName, PipelineStateStreamDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadPipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline<TI0>(char* pName, ref PipelineStateStreamDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadPipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline<TI0>(ref char pName, PipelineStateStreamDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadPipeline(ref pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadPipeline<TI0>(ref char pName, ref PipelineStateStreamDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadPipeline(ref pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadPipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->LoadPipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetDevice<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>(char* pName, GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>(char* pName, ref GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>(ref char pName, GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(ref pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> LoadGraphicsPipeline<TI0>(ref char pName, ref GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(ref pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> LoadGraphicsPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadComputePipeline<TI0>(char* pName, ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadComputePipeline<TI0>(char* pName, ref ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadComputePipeline<TI0>(ref char pName, ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadComputePipeline(ref pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> LoadComputePipeline<TI0>(ref char pName, ref ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadComputePipeline(ref pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadComputePipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> LoadComputePipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadPipeline<TI0>(char* pName, PipelineStateStreamDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadPipeline(pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadPipeline<TI0>(char* pName, ref PipelineStateStreamDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadPipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadPipeline<TI0>(ref char pName, PipelineStateStreamDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadPipeline(ref pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> LoadPipeline<TI0>(ref char pName, ref PipelineStateStreamDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadPipeline(ref pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> LoadPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, PipelineStateStreamDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadPipeline(pName, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> LoadPipeline<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref PipelineStateStreamDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->LoadPipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
