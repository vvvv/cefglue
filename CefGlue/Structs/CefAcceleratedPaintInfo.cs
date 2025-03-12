namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Structure representing accelerated paint info.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    public unsafe struct CefAcceleratedPaintInfo
    {
        /// <summary>
        /// Handle for the shared texture. The shared texture is instantiated
        /// without a keyed mutex.
        /// </summary>
        public nint SharedTextureHandle { get; }
        /// <summary>
        /// The pixel format of the texture.
        /// </summary>
        public CefColorType Format { get; }
        /// <summary>
        /// Timestamp of the frame in microseconds since capture start.
        /// </summary>
        public ulong Timestamp { get; }
        /// <summary>
        /// The full dimensions of the video frame.
        /// </summary>
        public CefSize CodedSize { get; }
        /// <summary>
        /// The visible area of the video frame.
        /// </summary>
        public CefRectangle VisibleRect { get; }
        /// <summary>
        /// The region of the video frame that capturer would like to populate.
        /// </summary>
        public CefRectangle ContentRect { get; }
        /// <summary>
        /// Full size of the source frame.
        /// </summary>
        public CefSize SourceSize { get; }
        /// <summary>
        /// Updated area of frame, can be considered as the `dirty` area.
        /// </summary>
        public CefRectangle CaptureUpdateRect { get; }
        /// <summary>
        /// May reflects where the frame's contents originate from if region
        /// capture is used internally.
        /// </summary>
        public CefRectangle RegionCaptureRect { get; }
        /// <summary>
        /// The increamental counter of the frame.
        /// </summary>
        public ulong CaptureCounter { get; }
        /// <summary>
        /// Optional flag of capture_update_rect
        /// </summary>
        public byte HasCaptureUpdateRect { get; }
        /// <summary>
        /// Optional flag of region_capture_rect
        /// </summary>
        public byte HasRegionCaptureRect { get; }
        /// <summary>
        /// Optional flag of source_size
        /// </summary>
        public byte HasSourceSize { get; }
        /// <summary>
        /// Optional flag of capture_counter
        /// </summary>
        public byte HasCaptureCounter { get; }
    }
}
