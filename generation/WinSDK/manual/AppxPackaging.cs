﻿using System;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation.Metadata;

namespace Windows.Win32.Storage.Packaging.Appx
{
    public static unsafe partial class Apis
    {
        public const uint PACKAGE_FULL_NAME_MIN_LENGTH = PACKAGE_NAME_MIN_LENGTH + 1 + PACKAGE_VERSION_MIN_LENGTH + 1 + PACKAGE_ARCHITECTURE_MIN_LENGTH + 1 + PACKAGE_RESOURCEID_MIN_LENGTH + 1 + PACKAGE_PUBLISHERID_MIN_LENGTH;

        public const uint PACKAGE_FULL_NAME_MAX_LENGTH = PACKAGE_NAME_MAX_LENGTH + 1 + PACKAGE_VERSION_MAX_LENGTH + 1 + PACKAGE_ARCHITECTURE_MAX_LENGTH + 1 + PACKAGE_RESOURCEID_MAX_LENGTH + 1 + PACKAGE_PUBLISHERID_MAX_LENGTH;

        public const uint PACKAGE_FAMILY_NAME_MIN_LENGTH = PACKAGE_NAME_MIN_LENGTH + 1 + PACKAGE_PUBLISHERID_MIN_LENGTH;

        public const uint PACKAGE_FAMILY_NAME_MAX_LENGTH = PACKAGE_NAME_MAX_LENGTH + 1 + PACKAGE_PUBLISHERID_MAX_LENGTH;

        public const uint PACKAGE_GRAPH_MAX_SIZE = 1 + PACKAGE_MAX_DEPENDENCIES + PACKAGE_FAMILY_MAX_RESOURCE_PACKAGES;

        public const uint APPLICATION_USER_MODEL_ID_MIN_LENGTH = PACKAGE_FAMILY_NAME_MIN_LENGTH + 1 + PACKAGE_RELATIVE_APPLICATION_ID_MIN_LENGTH;

        public const uint APPLICATION_USER_MODEL_ID_MAX_LENGTH = PACKAGE_FAMILY_NAME_MAX_LENGTH + 1 + PACKAGE_RELATIVE_APPLICATION_ID_MAX_LENGTH;
    }
}