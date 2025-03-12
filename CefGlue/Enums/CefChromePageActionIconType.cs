﻿//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_chrome_page_action_icon_type_t.
//
namespace Xilium.CefGlue
{
    using System;

    /// <summary>
    /// Chrome page action icon types. Should be kept in sync with Chromium's
    /// PageActionIconType type.
    /// </summary>
    public enum CefChromePageActionIconType
    {
        BookmarkStar = 0,
        ClickToCall,
        CookieControls,
        FileSystemAccess,
        Find,
        MemorySaver,
        IntentPicker,
        LocalCardMigration,
        ManagePasswords,
        PaymentsOfferNotification,
        PriceTracking,
        PwaInstall,
        [Obsolete] QRCodeGenerator,
        [Obsolete] ReaderMode,
        SaveAutofillAddress,
        SaveCard,
        [Obsolete] SendTabToSelf,
        SharingHub,
        SideSearch,
        SmsRemoteFetcher,
        Translate,
        VirtualCardEnroll,
        VirtualCardManualFallback,
        Zoom,
        SaveIban,
        MandatoryReauth,
        PriceInsights,
        PriceReadAnything,
        ProductSpecifications,
        LensOverlay,
        Discounts,
    }
}
