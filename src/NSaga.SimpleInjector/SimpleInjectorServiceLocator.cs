﻿using System;
using SimpleInjector;

namespace NSaga.SimpleInjector
{
    public class SimpleInjectorServiceLocator : IServiceLocator
    {
        private readonly Container container;

        public SimpleInjectorServiceLocator(Container container)
        {
            this.container = container;
        }

        public T Resolve<T>() where T : class 
        {
            return container.GetInstance<T>();
        }

        public object Resolve(Type type)
        {
            return container.GetInstance(type);
        }
    }
}