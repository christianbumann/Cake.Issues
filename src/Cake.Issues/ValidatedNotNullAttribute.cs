﻿// ReSharper disable RedundantTypeDeclarationBody
namespace Cake.Issues
{
    using System;

    /// <summary>
    /// Indicates to code analysis that a method validates a particular parameter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}
