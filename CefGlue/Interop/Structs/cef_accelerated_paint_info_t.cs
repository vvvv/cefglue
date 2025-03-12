namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    internal unsafe struct cef_accelerated_paint_info_t
    {
        public nint shared_texture_handle;
        public CefColorType format;
        public cef_accelerated_paint_info_common_t extra;
    }
}
