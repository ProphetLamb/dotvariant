//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant<>.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant<T>
        : global::System.IEquatable<Variant<T>>
    {
        private readonly global::dotVariant._G.Foo.Variant<T> _variant;

        /// <summary>
        /// Create a Variant with a value of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant(T value)
            => _variant = new global::dotVariant._G.Foo.Variant<T>(value);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant<T>(T value)
            => new Variant<T>(value);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant<T> Create(T value)
            => new Variant<T>(value);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Index"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public byte Index
            => _variant.Index;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object? other)
            => other is Variant<T> v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant<T>? other)
            => !(other is null) && _variant.Equals(other._variant);

        /// <summary>Compare two Variant<T> objects for equality.</summary>
        /// <param name="lhs">The first <see cref="Variant<T>" /> to compare.</param>
        /// <param name="rhs">The second <see cref="Variant<T>" /> to compare.</param>
        /// <returns><see langword="true" /> if <paramref name="lhs"/> and <paramref name="rhs"/> are considered equal; otherwise, <see langword="false" />.</returns>
        /// <seealso cref="Equals(Variant<T>?)" />
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant<T>? lhs, Variant<T>? rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        /// <summary>Compare two Variant<T> objects for inequality.</summary>
        /// <param name="lhs">The first <see cref="Variant<T>" /> to compare.</param>
        /// <param name="rhs">The second <see cref="Variant<T>" /> to compare.</param>
        /// <returns><see langword="true" /> if <paramref name="lhs"/> and <paramref name="rhs"/> are not considered equal; otherwise, <see langword="false" />.</returns>
        /// <seealso cref="Equals(Variant<T>?)" />
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant<T>? lhs, Variant<T>? rhs)
            => !(lhs == rhs);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.UnsafeGet(global::dotVariant.Accessor._1)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public T UnsafeGet(global::dotVariant.Accessor._1 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.TryMatch(out T?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out T? value)
            => _variant.TryMatch(out value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.TryMatch(global::System.Action{T})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<T> value)
            => _variant.TryMatch(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match(out T?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out T? value)
            => _variant.Match(out value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match(global::System.Action{T})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T> value)
            => _variant.Match(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match(global::System.Action{T}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T> value, global::System.Action _)
            => _variant.Match(value, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match{TResult}(global::System.Func{T, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T, TResult> value)
            => _variant.Match(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match{TResult}(global::System.Func{T, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T, TResult> value, TResult _)
            => _variant.Match(value, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match{TResult}(global::System.Func{T, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
            => _variant.Match(value, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit(global::System.Action{T})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T> value)
            => _variant.Visit(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit(global::System.Action{T}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T> value, global::System.Action _)
            => _variant.Visit(value, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit{TResult}(global::System.Func{T, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T, TResult> value)
            => _variant.Visit(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit{TResult}(global::System.Func{T, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
            => _variant.Visit(value, _);

        private sealed class __DebuggerTypeProxy
        {
            public object? Value { get; }
            public __DebuggerTypeProxy(Variant<T> v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default);
                #pragma warning restore 8604, 8625
            }
        }
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant<T>
    {
        private readonly struct Union
        {
            public readonly T _1;
            public Union(T value)
            {
                _1 = value;
            }
        }

        private readonly Union _x;

        /// <summary>
        /// The 1-based index of the currently stored type,
        /// counted left-ro-right from the <see cref="global::Foo.Variant{T}.VariantOf"/> parameter list.
        /// <c>0</c> if the variant is empty.
        /// </summary>
        public readonly byte Index;

        public Variant(T value)
        {
            Index = 1;
            _x = new Union(value);
        }


        /// <summary>
        /// <see langword="true"/> if Variant was constructed without a value.
        /// </summary>
        public bool IsEmpty => this.Index == 0;

        /// <summary>
        /// The string representation of the stored value's type.
        /// </summary>
        public string TypeString
        {
            get
            {
                switch (this.Index)
                {
                    case 0:
                        return "<empty>";
                    case 1:
                        return "T";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T>");
                }
            }
        }

        /// <summary>
        /// The stored value's <see cref="object.ToString()"/> result, or <c>""</c> if empty.
        /// </summary>
        public override string ToString()
        {
            switch (this.Index)
            {
                case 0:
                    return "";
                case 1:
                    return _x._1?.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T>");
            }
        }

        /// <summary>
        /// The stored value cast to type <see cref="object"/>.
        /// </summary>
        public object? AsObject
        {
            get
            {
                switch (this.Index)
                {
                    case 0:
                        return null;
                    case 1:
                        return _x._1;
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object?>("Foo.Variant<T>");
                }
            }
        }

        public bool Equals(in Variant<T> other)
        {
            if (this.Index != other.Index)
            {
                return false;
            }
            switch (Index)
            {
                case 0:
                    return true;
                case 1:
                    return global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(_x._1, other._x._1);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant<T>");
            }
        }

        public override int GetHashCode()
        {
            switch (this.Index)
            {
                case 0:
                    return 0;
                case 1:
                    return global::System.HashCode.Combine(_x._1);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant<T>");
            }
        }

        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="T"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 1</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public T UnsafeGet(global::dotVariant.Accessor._1 _)
            => _x._1;

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">Receives the stored value if it is of type <see cref="T"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T"/>.</returns>
        public bool TryMatch(out T? value)
        {
            value = this.Index == 1 ? _x._1 : default;
            return this.Index == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<T> value)
        {
            if (this.Index == 1)
            {
                value(_x._1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value">Receives the stored value if it is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T"/>.</exception>
        public void Match(out T? value)
        {
            if (this.Index == 1)
            {
                value = _x._1;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant<T>", "T", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> is rethrown.</exception>
        public void Match(global::System.Action<T> value)
        {
            if (this.Index == 1)
            {
                value(_x._1);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant<T>", "T", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<T> value, global::System.Action _)
        {
            if (this.Index == 1)
            {
                value(_x._1);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <returns>The value returned from invoking <paramref name="value"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T, TResult> value)
        {
            if (this.Index == 1)
            {
                return value(_x._1);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant<T>", "T", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="value"/>, or <paramref name="_"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T, TResult> value, TResult _)
        {
            return this.Index == 1 ? value(_x._1) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
        {
            return this.Index == 1 ? value(_x._1) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant,
        /// and invoke a special delegate if Variant is empty.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T> value, global::System.Action _)
        {
            switch (this.Index)
            {
                case 0:
                    _();
                    break;
                case 1:
                    value(_x._1);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T> value)
        {
            switch (this.Index)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T>");
                    break;
                case 1:
                    value(_x._1);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant and return the result,
        /// and invoke a special delegate if Variant is empty and return its result.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
        {
            switch (this.Index)
            {
                case 0:
                    return _();
                case 1:
                    return value(_x._1);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant and return the result,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T, TResult> value)
        {
            switch (this.Index)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T>");
                case 1:
                    return value(_x._1);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
            }
        }
    }
}


namespace Foo
{
    /// <summary>
    /// Extensions which allow for easy and powerful integration into `System.Linq`-like queries
    /// on <see cref="global::System.Collections.Generic.IEnumerable{T}" /> sequences, that let you manipulate a stream of variants based on the contained type.
    /// </summary>
    public static partial class Variant_T_Ex
    {
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value)
        {
            foreach (var _variant in _source)
            {
                switch (_variant.Index)
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T>");
                        yield break;
                    case 1:
                        yield return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                switch (_variant.Index)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    /// <summary>
    /// Extensions which allow for easy and powerful integration into `System.Reactive.Linq`-like queries
    /// on <see cref="global::System.IObservable{T}" /> sequences, that let you manipulate an asynchronous stream of variants based on the contained type.
    /// </summary>
    public static partial class Variant_T_Ex
    {
        /// <summary>
        /// Projects each <see cref="T"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 1),
                _variant => value(_variant.UnsafeGet(new global::dotVariant.Accessor._1())));
        }

        /// <summary>
        /// Projects each <see cref="T"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _;
                }
            });
        }

        /// <summary>
        /// Projects each <see cref="T"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _();
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to visit.</param>
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T>");
                    case 1:
                        return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to visit.</param>
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<T, TResult> value,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return _();
                    case 1:
                        return value(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
                }
            });
        }


        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
        /// transforming each sub-sequence by the provided selector, and merges the resulting values into one observable sequence.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>The first sub-sequence to produce an OnError message terminates the resulting sequence with OnError.</item>
        ///     <item>When all sub-sequences terminate with OnCompleted (even before the source does) the resulting sequence terminates.</item>
        /// </list>
        /// </remarks>
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="value">Transform an observable sequence of <see cref="T"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<global::System.IObservable<T>, global::System.IObservable<TResult>> value,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(_source, (_1, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(value(_1), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
        /// and combines the resulting values into one observable sequence according to the combining selector,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>How termination (successful or error) of sub-sequences affects the resulting sequence depends on the combining operation.</item>
        /// </list>
        /// </remarks>
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<global::System.IObservable<T>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T>(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
        /// and combines the resulting values into one observable sequence according to the combining selector.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>How termination (successful or error) of sub-sequences affects the resulting sequence depends on the combining operation.</item>
        /// </list>
        /// </remarks>
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> _source,
                global::System.Func<global::System.IObservable<T>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T>(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver<T>
            : global::System.IObserver<global::Foo.Variant<T>>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<T> Subject1 = new global::System.Reactive.Subjects.Subject<T>();
            private readonly bool _accept0;

            public VisitManyObserver(bool _accept0)
            {
                this._accept0 = _accept0;
            }

            public void Dispose()
            {
                Subject1.Dispose();
                Subject0.Dispose();
            }

            public void OnNext(global::Foo.Variant<T> _variant)
            {
                switch (_variant.Index)
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant<T>"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant<T>"));
                        break;
                }
            }

            public void OnError(global::System.Exception _ex)
            {
                Subject1.OnError(_ex);
                if (_accept0)
                {
                    Subject0.OnError(_ex);
                }
            }

            public void OnCompleted()
            {
                Subject1.OnCompleted();
                if (_accept0)
                {
                    Subject0.OnCompleted();
                }
            }
        }

    }
}
#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant<,>.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant<T1, T2>
        : global::System.IEquatable<Variant<T1, T2>>
    {
        private readonly global::dotVariant._G.Foo.Variant<T1, T2> _variant;

        /// <summary>
        /// Create a Variant with a value of type <see cref="T1"/>.
        /// </summary>
        /// <param name="value1">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant(T1 value1)
            => _variant = new global::dotVariant._G.Foo.Variant<T1, T2>(value1);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T2"/>.
        /// </summary>
        /// <param name="value2">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant(T2 value2)
            => _variant = new global::dotVariant._G.Foo.Variant<T1, T2>(value2);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T1"/>.
        /// </summary>
        /// <param name="value1">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant<T1, T2>(T1 value1)
            => new Variant<T1, T2>(value1);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T2"/>.
        /// </summary>
        /// <param name="value2">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant<T1, T2>(T2 value2)
            => new Variant<T1, T2>(value2);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T1"/>.
        /// </summary>
        /// <param name="value1">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant<T1, T2> Create(T1 value1)
            => new Variant<T1, T2>(value1);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T2"/>.
        /// </summary>
        /// <param name="value2">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant<T1, T2> Create(T2 value2)
            => new Variant<T1, T2>(value2);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Index"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public byte Index
            => _variant.Index;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object? other)
            => other is Variant<T1, T2> v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant<T1, T2>? other)
            => !(other is null) && _variant.Equals(other._variant);

        /// <summary>Compare two Variant<T1, T2> objects for equality.</summary>
        /// <param name="lhs">The first <see cref="Variant<T1, T2>" /> to compare.</param>
        /// <param name="rhs">The second <see cref="Variant<T1, T2>" /> to compare.</param>
        /// <returns><see langword="true" /> if <paramref name="lhs"/> and <paramref name="rhs"/> are considered equal; otherwise, <see langword="false" />.</returns>
        /// <seealso cref="Equals(Variant<T1, T2>?)" />
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant<T1, T2>? lhs, Variant<T1, T2>? rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        /// <summary>Compare two Variant<T1, T2> objects for inequality.</summary>
        /// <param name="lhs">The first <see cref="Variant<T1, T2>" /> to compare.</param>
        /// <param name="rhs">The second <see cref="Variant<T1, T2>" /> to compare.</param>
        /// <returns><see langword="true" /> if <paramref name="lhs"/> and <paramref name="rhs"/> are not considered equal; otherwise, <see langword="false" />.</returns>
        /// <seealso cref="Equals(Variant<T1, T2>?)" />
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant<T1, T2>? lhs, Variant<T1, T2>? rhs)
            => !(lhs == rhs);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.UnsafeGet(global::dotVariant.Accessor._1)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public T1 UnsafeGet(global::dotVariant.Accessor._1 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.TryMatch(out T1?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out T1? value1)
            => _variant.TryMatch(out value1);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.TryMatch(global::System.Action{T1})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<T1> value1)
            => _variant.TryMatch(value1);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match(out T1?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out T1? value1)
            => _variant.Match(out value1);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match(global::System.Action{T1})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T1> value1)
            => _variant.Match(value1);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match(global::System.Action{T1}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T1> value1, global::System.Action _)
            => _variant.Match(value1, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match{TResult}(global::System.Func{T1, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T1, TResult> value1)
            => _variant.Match(value1);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match{TResult}(global::System.Func{T1, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T1, TResult> value1, TResult _)
            => _variant.Match(value1, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match{TResult}(global::System.Func{T1, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T1, TResult> value1, global::System.Func<TResult> _)
            => _variant.Match(value1, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.UnsafeGet(global::dotVariant.Accessor._2)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public T2 UnsafeGet(global::dotVariant.Accessor._2 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.TryMatch(out T2?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out T2? value2)
            => _variant.TryMatch(out value2);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.TryMatch(global::System.Action{T2})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<T2> value2)
            => _variant.TryMatch(value2);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match(out T2?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out T2? value2)
            => _variant.Match(out value2);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match(global::System.Action{T2})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T2> value2)
            => _variant.Match(value2);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match(global::System.Action{T2}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T2> value2, global::System.Action _)
            => _variant.Match(value2, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match{TResult}(global::System.Func{T2, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T2, TResult> value2)
            => _variant.Match(value2);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match{TResult}(global::System.Func{T2, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T2, TResult> value2, TResult _)
            => _variant.Match(value2, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Match{TResult}(global::System.Func{T2, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T2, TResult> value2, global::System.Func<TResult> _)
            => _variant.Match(value2, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Visit(global::System.Action{T1}, global::System.Action{T2})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T1> value1, global::System.Action<T2> value2)
            => _variant.Visit(value1, value2);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Visit(global::System.Action{T1}, global::System.Action{T2}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T1> value1, global::System.Action<T2> value2, global::System.Action _)
            => _variant.Visit(value1, value2, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Visit{TResult}(global::System.Func{T1, TResult}, global::System.Func{T2, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2)
            => _variant.Visit(value1, value2);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2}.Visit{TResult}(global::System.Func{T1, TResult}, global::System.Func{T2, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2, global::System.Func<TResult> _)
            => _variant.Visit(value1, value2, _);

        private sealed class __DebuggerTypeProxy
        {
            public object? Value { get; }
            public __DebuggerTypeProxy(Variant<T1, T2> v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default, default);
                #pragma warning restore 8604, 8625
            }
        }
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant<T1, T2>
    {
        private readonly struct Union
        {
            public readonly T1 _1;
            public Union(T1 value)
            {
                _2 = default!;
                _1 = value;
            }
            public readonly T2 _2;
            public Union(T2 value)
            {
                _1 = default!;
                _2 = value;
            }
        }

        private readonly Union _x;

        /// <summary>
        /// The 1-based index of the currently stored type,
        /// counted left-ro-right from the <see cref="global::Foo.Variant{T1, T2}.VariantOf"/> parameter list.
        /// <c>0</c> if the variant is empty.
        /// </summary>
        public readonly byte Index;

        public Variant(T1 value1)
        {
            Index = 1;
            _x = new Union(value1);
        }
        public Variant(T2 value2)
        {
            Index = 2;
            _x = new Union(value2);
        }


        /// <summary>
        /// <see langword="true"/> if Variant was constructed without a value.
        /// </summary>
        public bool IsEmpty => this.Index == 0;

        /// <summary>
        /// The string representation of the stored value's type.
        /// </summary>
        public string TypeString
        {
            get
            {
                switch (this.Index)
                {
                    case 0:
                        return "<empty>";
                    case 1:
                        return "T1";
                    case 2:
                        return "T2";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T1, T2>");
                }
            }
        }

        /// <summary>
        /// The stored value's <see cref="object.ToString()"/> result, or <c>""</c> if empty.
        /// </summary>
        public override string ToString()
        {
            switch (this.Index)
            {
                case 0:
                    return "";
                case 1:
                    return _x._1?.ToString() ?? "null";
                case 2:
                    return _x._2?.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T1, T2>");
            }
        }

        /// <summary>
        /// The stored value cast to type <see cref="object"/>.
        /// </summary>
        public object? AsObject
        {
            get
            {
                switch (this.Index)
                {
                    case 0:
                        return null;
                    case 1:
                        return _x._1;
                    case 2:
                        return _x._2;
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object?>("Foo.Variant<T1, T2>");
                }
            }
        }

        public bool Equals(in Variant<T1, T2> other)
        {
            if (this.Index != other.Index)
            {
                return false;
            }
            switch (Index)
            {
                case 0:
                    return true;
                case 1:
                    return global::System.Collections.Generic.EqualityComparer<T1>.Default.Equals(_x._1, other._x._1);
                case 2:
                    return global::System.Collections.Generic.EqualityComparer<T2>.Default.Equals(_x._2, other._x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant<T1, T2>");
            }
        }

        public override int GetHashCode()
        {
            switch (this.Index)
            {
                case 0:
                    return 0;
                case 1:
                    return global::System.HashCode.Combine(_x._1);
                case 2:
                    return global::System.HashCode.Combine(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant<T1, T2>");
            }
        }

        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="T1"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 1</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public T1 UnsafeGet(global::dotVariant.Accessor._1 _)
            => _x._1;

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T1"/>.
        /// </summary>
        /// <param name="value1">Receives the stored value if it is of type <see cref="T1"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T1"/>.</returns>
        public bool TryMatch(out T1? value1)
        {
            value1 = this.Index == 1 ? _x._1 : default;
            return this.Index == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/>.
        /// </summary>
        /// <param name="value1">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T1"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value1"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<T1> value1)
        {
            if (this.Index == 1)
            {
                value1(_x._1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T1"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value1">Receives the stored value if it is of type <see cref="T1"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T1"/>.</exception>
        public void Match(out T1? value1)
        {
            if (this.Index == 1)
            {
                value1 = _x._1;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant<T1, T2>", "T1", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value1">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T1"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value1"/> is rethrown.</exception>
        public void Match(global::System.Action<T1> value1)
        {
            if (this.Index == 1)
            {
                value1(_x._1);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant<T1, T2>", "T1", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="value1">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value1"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<T1> value1, global::System.Action _)
        {
            if (this.Index == 1)
            {
                value1(_x._1);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value1">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <returns>The value returned from invoking <paramref name="value1"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T1"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value1"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T1, TResult> value1)
        {
            if (this.Index == 1)
            {
                return value1(_x._1);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant<T1, T2>", "T1", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="value1">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="value1"/>, or <paramref name="_"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value1"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T1, TResult> value1, TResult _)
        {
            return this.Index == 1 ? value1(_x._1) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="value1">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value1"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T1, TResult> value1, global::System.Func<TResult> _)
        {
            return this.Index == 1 ? value1(_x._1) : _();
        }
        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="T2"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 2</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public T2 UnsafeGet(global::dotVariant.Accessor._2 _)
            => _x._2;

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T2"/>.
        /// </summary>
        /// <param name="value2">Receives the stored value if it is of type <see cref="T2"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T2"/>.</returns>
        public bool TryMatch(out T2? value2)
        {
            value2 = this.Index == 2 ? _x._2 : default;
            return this.Index == 2;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/>.
        /// </summary>
        /// <param name="value2">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T2"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value2"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<T2> value2)
        {
            if (this.Index == 2)
            {
                value2(_x._2);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T2"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value2">Receives the stored value if it is of type <see cref="T2"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T2"/>.</exception>
        public void Match(out T2? value2)
        {
            if (this.Index == 2)
            {
                value2 = _x._2;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant<T1, T2>", "T2", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value2">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T2"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value2"/> is rethrown.</exception>
        public void Match(global::System.Action<T2> value2)
        {
            if (this.Index == 2)
            {
                value2(_x._2);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant<T1, T2>", "T2", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="value2">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value2"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<T2> value2, global::System.Action _)
        {
            if (this.Index == 2)
            {
                value2(_x._2);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value2">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <returns>The value returned from invoking <paramref name="value2"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T2"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value2"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T2, TResult> value2)
        {
            if (this.Index == 2)
            {
                return value2(_x._2);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant<T1, T2>", "T2", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="value2">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="value2"/>, or <paramref name="_"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value2"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T2, TResult> value2, TResult _)
        {
            return this.Index == 2 ? value2(_x._2) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="value2">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value2"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T2, TResult> value2, global::System.Func<TResult> _)
        {
            return this.Index == 2 ? value2(_x._2) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant,
        /// and invoke a special delegate if Variant is empty.
        /// </summary>
        /// <param name="value1">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T1> value1, global::System.Action<T2> value2, global::System.Action _)
        {
            switch (this.Index)
            {
                case 0:
                    _();
                    break;
                case 1:
                    value1(_x._1);
                    break;
                case 2:
                    value2(_x._2);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="value1">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T1> value1, global::System.Action<T2> value2)
        {
            switch (this.Index)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T1, T2>");
                    break;
                case 1:
                    value1(_x._1);
                    break;
                case 2:
                    value2(_x._2);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant and return the result,
        /// and invoke a special delegate if Variant is empty and return its result.
        /// </summary>
        /// <param name="value1">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2, global::System.Func<TResult> _)
        {
            switch (this.Index)
            {
                case 0:
                    return _();
                case 1:
                    return value1(_x._1);
                case 2:
                    return value2(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2>");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant and return the result,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="value1">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2)
        {
            switch (this.Index)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T1, T2>");
                case 1:
                    return value1(_x._1);
                case 2:
                    return value2(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2>");
            }
        }
    }
}


namespace Foo
{
    /// <summary>
    /// Extensions which allow for easy and powerful integration into `System.Linq`-like queries
    /// on <see cref="global::System.Collections.Generic.IEnumerable{T}" /> sequences, that let you manipulate a stream of variants based on the contained type.
    /// </summary>
    internal static partial class Variant_T1_T2_Ex
    {
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T1"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value1">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T2"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value2">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T2, TResult> value2)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T1"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value1">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T2"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value2">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T2, TResult> value2,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T1"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value1">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T2"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value2">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T2, TResult> value2,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value1">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2)
        {
            foreach (var _variant in _source)
            {
                switch (_variant.Index)
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T1, T2>");
                        yield break;
                    case 1:
                        yield return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        yield return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2>");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value1">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T1, T2>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                switch (_variant.Index)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        yield return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2>");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    /// <summary>
    /// Extensions which allow for easy and powerful integration into `System.Reactive.Linq`-like queries
    /// on <see cref="global::System.IObservable{T}" /> sequences, that let you manipulate an asynchronous stream of variants based on the contained type.
    /// </summary>
    internal static partial class Variant_T1_T2_Ex
    {
        /// <summary>
        /// Projects each <see cref="T1"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value1">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 1),
                _variant => value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1())));
        }
        /// <summary>
        /// Projects each <see cref="T2"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value2">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T2, TResult> value2)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 2),
                _variant => value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2())));
        }

        /// <summary>
        /// Projects each <see cref="T1"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value1">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="T2"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value2">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T2, TResult> value2,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    return _;
                }
            });
        }

        /// <summary>
        /// Projects each <see cref="T1"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value1">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="T2"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="value2">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T2, TResult> value2,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    return _();
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to visit.</param>
        /// <param name="value1">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T1, T2>");
                    case 1:
                        return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    case 2:
                        return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2>");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to visit.</param>
        /// <param name="value1">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="value2">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<T1, TResult> value1, global::System.Func<T2, TResult> value2,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return _();
                    case 1:
                        return value1(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    case 2:
                        return value2(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2>");
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
        /// transforming each sub-sequence by the provided selector, and merges the resulting values into one observable sequence,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>The first sub-sequence to produce an OnError message terminates the resulting sequence with OnError.</item>
        ///     <item>When all sub-sequences terminate with OnCompleted (even before the source does) the resulting sequence terminates.</item>
        /// </list>
        /// </remarks>
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="value1">Transform an observable sequence of <see cref="T1"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="value2">Transform an observable sequence of <see cref="T2"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<TResult>> value1, global::System.Func<global::System.IObservable<T2>, global::System.IObservable<TResult>> value2)
        {
            return VisitMany(_source, (_1, _2) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(value1(_1), value2(_2));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
        /// transforming each sub-sequence by the provided selector, and merges the resulting values into one observable sequence.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>The first sub-sequence to produce an OnError message terminates the resulting sequence with OnError.</item>
        ///     <item>When all sub-sequences terminate with OnCompleted (even before the source does) the resulting sequence terminates.</item>
        /// </list>
        /// </remarks>
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="value1">Transform an observable sequence of <see cref="T1"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="value2">Transform an observable sequence of <see cref="T2"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<TResult>> value1, global::System.Func<global::System.IObservable<T2>, global::System.IObservable<TResult>> value2,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(_source, (_1, _2, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(value1(_1), value2(_2), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
        /// and combines the resulting values into one observable sequence according to the combining selector,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>How termination (successful or error) of sub-sequences affects the resulting sequence depends on the combining operation.</item>
        /// </list>
        /// </remarks>
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<T2>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T1, T2>(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1, _mo.Subject2).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
        /// and combines the resulting values into one observable sequence according to the combining selector.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>How termination (successful or error) of sub-sequences affects the resulting sequence depends on the combining operation.</item>
        /// </list>
        /// </remarks>
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T1, T2>(
                this global::System.IObservable<global::Foo.Variant<T1, T2>> _source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<T2>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T1, T2>(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1, _mo.Subject2, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver<T1, T2>
            : global::System.IObserver<global::Foo.Variant<T1, T2>>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<T1> Subject1 = new global::System.Reactive.Subjects.Subject<T1>();
            public readonly global::System.Reactive.Subjects.Subject<T2> Subject2 = new global::System.Reactive.Subjects.Subject<T2>();
            private readonly bool _accept0;

            public VisitManyObserver(bool _accept0)
            {
                this._accept0 = _accept0;
            }

            public void Dispose()
            {
                Subject1.Dispose();
                Subject2.Dispose();
                Subject0.Dispose();
            }

            public void OnNext(global::Foo.Variant<T1, T2> _variant)
            {
                switch (_variant.Index)
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant<T1, T2>"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        Subject2.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant<T1, T2>"));
                        break;
                }
            }

            public void OnError(global::System.Exception _ex)
            {
                Subject1.OnError(_ex);
                Subject2.OnError(_ex);
                if (_accept0)
                {
                    Subject0.OnError(_ex);
                }
            }

            public void OnCompleted()
            {
                Subject1.OnCompleted();
                Subject2.OnCompleted();
                if (_accept0)
                {
                    Subject0.OnCompleted();
                }
            }
        }

    }
}