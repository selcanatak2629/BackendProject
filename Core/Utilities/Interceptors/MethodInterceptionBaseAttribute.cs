﻿using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }       // attribute öncelik 
        //try - catch => hata alma yakalama için kullanılır
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
