﻿using Chrome.Dependencies.Contracts;

namespace Chrome.Dependencies.Builder;

public sealed class DependencyContainerFactory
{
    private static IDependencyContainer _container;

    public static IDependencyContainer Container
    {
        get => _container ?? throw new NotImplementedException("Container was not instantiated!");
        private set => _container = value;
    }

    public static IDependencyContainer Init()
    {
        return Container = new DependencyContainer();
    }
}