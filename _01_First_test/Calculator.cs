﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Calculator;

public class Calculator
{
    public int Value { get; private set; }

    public Calculator(int value = 0)
    {
        Value = value;
    }

    public void Reset()
    {
        Value = 0;
    }

    public void Add(int addValue)
    {
        Value += addValue;
    }

    public void Substract(int substractValue)
    {
        Value -= substractValue;
    }
}

public record Primitive<TValue>(TValue Value);
public record struct EmailAddress(string Value);


// namespace ValueOf
// {
    public class ValueOf<TValue, TThis> where TThis : ValueOf<TValue, TThis>, new()
    {
        private static readonly Func<TThis> Factory;

        static ValueOf()
        {
            ConstructorInfo ctor = typeof(TThis)
                .GetTypeInfo()
                .DeclaredConstructors
                .First();

            var argsExp = new Expression[0];
            NewExpression newExp = Expression.New(ctor, argsExp);
            LambdaExpression lambda = Expression.Lambda(typeof(Func<TThis>), newExp);

            Factory = (Func<TThis>)lambda.Compile();
        }

        public TValue Value { get; protected set; }

        public static TThis From(TValue item)
        {
            TThis x = Factory();
            x.Value = item;

            return x;
        }

        // public static bool TryFrom(TValue item, out TThis thisValue)
        // {
        //     TThis x = Factory();
        //     x.Value = item;
        //
        //     thisValue = x.TryValidate()
        //        ? x
        //        : null;
        //
        //     return thisValue != null;
        // }

        // protected virtual bool Equals(ValueOf<TValue, TThis> other)
        // {
        //     return EqualityComparer<TValue>.Default.Equals(Value, other.Value);
        // }

        // public override bool Equals(object obj)
        // {
        //     if (obj is null)
        //         return false;
        //
        //     if (ReferenceEquals(this, obj))
        //         return true;
        //
        //     return obj.GetType() == GetType() && Equals((ValueOf<TValue, TThis>)obj);
        // }
        //
        // public override int GetHashCode()
        // {
        //     return EqualityComparer<TValue>.Default.GetHashCode(Value);
        // }
        //
        // public static bool operator ==(ValueOf<TValue, TThis> a, ValueOf<TValue, TThis> b)
        // {
        //     if (a is null && b is null)
        //         return true;
        //
        //     if (a is null || b is null)
        //         return false;
        //
        //     return a.Equals(b);
        // }
        //
        // public static bool operator !=(ValueOf<TValue, TThis> a, ValueOf<TValue, TThis> b)
        // {
        //     return !(a == b);
        // }
        //
        // // Implicit operator removed. See issue #14.

        public override string ToString()
        {
            return Value.ToString();
        }
    }
// }