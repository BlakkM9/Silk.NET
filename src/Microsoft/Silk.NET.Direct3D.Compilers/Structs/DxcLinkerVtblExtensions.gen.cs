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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcLinkerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLinker> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLinker> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLinker> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLinker> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcLinker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcLinker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, char* pLibName, IDxcBlob* pLib)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, char*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibName, pLib);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, char* pLibName, ref IDxcBlob pLib)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pLibPtr = &pLib)
        {
            ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, char*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibName, pLibPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, ref char pLibName, IDxcBlob* pLib)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pLibNamePtr = &pLibName)
        {
            ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, char*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibNamePtr, pLib);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, ref char pLibName, ref IDxcBlob pLib)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pLibNamePtr = &pLibName)
        {
            fixed (IDxcBlob* pLibPtr = &pLib)
            {
                ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, char*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibNamePtr, pLibPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLibName, IDxcBlob* pLib)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pLibNamePtr = (byte*) SilkMarshal.StringToPtr(pLibName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, byte*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibNamePtr, pLib);
        SilkMarshal.Free((nint)pLibNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLibName, ref IDxcBlob pLib)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pLibNamePtr = (byte*) SilkMarshal.StringToPtr(pLibName, NativeStringEncoding.LPWStr);
        fixed (IDxcBlob* pLibPtr = &pLib)
        {
            ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, byte*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibNamePtr, pLibPtr);
        }
        SilkMarshal.Free((nint)pLibNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pLibNamesPtr = &pLibNames)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pEntryNamePtr = &pEntryName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResultPtr);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfile, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pLibNamesPtr = &pLibNames)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArguments, argCount, ppResultPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResult);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNames, libCount, pArgumentsPtr, argCount, ppResultPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResult);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArguments, argCount, ppResultPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResult);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pLibNamesPtr = &pLibNames)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, byte*, byte*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryNamePtr, pTargetProfilePtr, pLibNamesPtr, libCount, pArgumentsPtr, argCount, ppResultPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDxcLinker> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLinker> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcLinker> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterLibrary<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pLibName, ComPtr<TI0> pLib) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterLibrary(pLibName, (IDxcBlob*) pLib.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, char* pLibName, Span<IDxcBlob> pLib)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterLibrary(pLibName, ref pLib.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, Span<char> pLibName, IDxcBlob* pLib)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterLibrary(ref pLibName.GetPinnableReference(), pLib);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterLibrary<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pLibName, ComPtr<TI0> pLib) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterLibrary(ref pLibName, (IDxcBlob*) pLib.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, Span<char> pLibName, Span<IDxcBlob> pLib)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterLibrary(ref pLibName.GetPinnableReference(), ref pLib.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterLibrary<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLibName, ComPtr<TI0> pLib) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterLibrary(pLibName, (IDxcBlob*) pLib.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterLibrary(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLibName, Span<IDxcBlob> pLib)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterLibrary(pLibName, ref pLib.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, char* pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(ref pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(ref pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, ref pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, ref char pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(ref pEntryName, pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, Span<char> pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(ref pEntryName.GetPinnableReference(), pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, char* pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, ref pArguments, argCount, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, ref char pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, ref pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, Span<char> pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Link(pEntryName, ref pTargetProfile.GetPinnableReference(), ref pLibNames, libCount, ref pArguments, argCount, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pLibNamesSa, uint libCount, ref char* pArguments, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pLibNames = (char**) SilkMarshal.StringArrayToPtr(pLibNamesSa);
        var ret = @this->Link(pEntryName, pTargetProfile, pLibNames, libCount, ref pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pLibNames, pLibNamesSa);
        SilkMarshal.Free((nint) pLibNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, char** pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, string[] pArgumentsSa, uint argCount, ref IDxcOperationResult* ppResult)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, pArguments, argCount, ref ppResult);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link<TI0>(this ComPtr<IDxcLinker> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pLibNames, uint libCount, ref char* pArguments, uint argCount, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Link(pEntryName, pTargetProfile, ref pLibNames, libCount, ref pArguments, argCount, (IDxcOperationResult**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcLinker> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
