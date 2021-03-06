﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sakuno
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class TypeExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAssignableFrom<T>(this Type type) => type.IsAssignableFrom(typeof(T));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAssignableTo<T>(this Type type) => typeof(T).IsAssignableFrom(type);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSubclassOf<T>(this Type type) => type.IsSubclassOf(typeof(T));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsConcrete(this Type type) => type.IsClass && !type.IsAbstract && !type.IsGenericTypeDefinition;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsStatic(this Type type) => type.IsAbstract && type.IsSealed;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullableType(this Type type) =>
            type.IsValueType && type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
    }
}
