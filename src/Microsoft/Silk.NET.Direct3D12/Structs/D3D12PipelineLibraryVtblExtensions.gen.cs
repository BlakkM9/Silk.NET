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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12PipelineLibraryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12PipelineLibrary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12PipelineLibrary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ID3D12PipelineState* pPipeline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pName, pPipeline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref ID3D12PipelineState pPipeline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pName, pPipelinePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ID3D12PipelineState* pPipeline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipeline);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref ID3D12PipelineState pPipeline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ID3D12PipelineState* pPipeline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipeline);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ID3D12PipelineState pPipeline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ID3D12PipelineState* pPipelinePtr = &pPipeline)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pNamePtr, pPipelinePtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineStatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pNamePtr = &pName)
        {
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineState);
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (void** ppPipelineStatePtr = &ppPipelineState)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riid, ppPipelineStatePtr);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDesc, riidPtr, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineState);
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riid, ppPipelineStatePtr);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineState);
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPWStr);
        fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, byte*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pNamePtr, pDescPtr, riidPtr, ppPipelineStatePtr);
                }
            }
        }
        SilkMarshal.Free((nint)pNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint GetSerializedSize(this ComPtr<ID3D12PipelineLibrary> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        nuint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, nuint>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Serialize(this ComPtr<ID3D12PipelineLibrary> thisVtbl, void* pData, nuint DataSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, void*, nuint, int>)@this->LpVtbl[12])(@this, pData, DataSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Serialize<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref T0 pData, nuint DataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary*, void*, nuint, int>)@this->LpVtbl[12])(@this, pDataPtr, DataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComPtr<TI0> pPipeline) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StorePipeline(pName, (ID3D12PipelineState*) pPipeline.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<ID3D12PipelineState> pPipeline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StorePipeline(pName, ref pPipeline.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, ID3D12PipelineState* pPipeline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StorePipeline(ref pName.GetPinnableReference(), pPipeline);
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ComPtr<TI0> pPipeline) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StorePipeline(ref pName, (ID3D12PipelineState*) pPipeline.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<ID3D12PipelineState> pPipeline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StorePipeline(ref pName.GetPinnableReference(), ref pPipeline.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComPtr<TI0> pPipeline) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StorePipeline(pName, (ID3D12PipelineState*) pPipeline.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int StorePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<ID3D12PipelineState> pPipeline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StorePipeline(pName, ref pPipeline.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadGraphicsPipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadGraphicsPipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), pDesc, riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadGraphicsPipeline(ref pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), pDesc, riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadGraphicsPipeline(ref pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadGraphicsPipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadGraphicsPipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<GraphicsPipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadGraphicsPipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<GraphicsPipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadGraphicsPipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadComputePipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<ComputePipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadComputePipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<ComputePipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), pDesc, riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadComputePipeline(ref pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), pDesc, riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, ComputePipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, ComputePipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<ComputePipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadComputePipeline(ref pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<ComputePipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<char> pName, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(ref pName.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadComputePipeline(pName, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, pDesc, ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, pDesc, ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<ComputePipelineStateDesc> pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), riid, ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppPipelineState = default;
        return @this->LoadComputePipeline(pName, ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<ComputePipelineStateDesc> pDesc, Guid* riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), riid, ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadComputePipeline(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, Span<ComputePipelineStateDesc> pDesc, Span<Guid> riid, ref void* ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadComputePipeline(pName, ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static int Serialize<T0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, Span<T0> pData, nuint DataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Serialize(ref pData.GetPinnableReference(), DataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(ref pName, pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(ref pName, ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> LoadGraphicsPipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadGraphicsPipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, char* pName, ref ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadComputePipeline(ref pName, pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, ref char pName, ref ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadComputePipeline(ref pName, ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> LoadComputePipeline<TI0>(this ComPtr<ID3D12PipelineLibrary> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pName, ref ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->LoadComputePipeline(pName, ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
