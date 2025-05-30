﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_frame_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_frame_created;
        internal IntPtr _on_frame_destroyed;
        internal IntPtr _on_frame_attached;
        internal IntPtr _on_frame_detached;
        internal IntPtr _on_main_frame_changed;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_frame_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_frame_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_frame_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_frame_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_frame_created_delegate(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* frame);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_frame_destroyed_delegate(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* frame);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_frame_attached_delegate(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int reattached);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_frame_detached_delegate(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* frame);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_main_frame_changed_delegate(cef_frame_handler_t* self, cef_browser_t* browser, cef_frame_t* old_frame, cef_frame_t* new_frame);
        
        private static int _sizeof;
        
        static cef_frame_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_frame_handler_t));
        }
        
        internal static cef_frame_handler_t* Alloc()
        {
            var ptr = (cef_frame_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_frame_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_frame_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
