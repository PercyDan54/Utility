﻿using System.Buffers;

namespace ArknightsResources.Utility
{
    internal static class InternalArrayPools
    {
        internal static readonly ArrayPool<byte> ByteArrayPool = ArrayPool<byte>.Create(64 * 1024 * 1024, 3);
        internal static readonly ArrayPool<byte[]> ByteArrayArrayPool = ArrayPool<byte[]>.Create(12, 3);
        internal static readonly ArrayPool<int> Int32ArrayPool = ArrayPool<int>.Create(64, 3);
    }
}