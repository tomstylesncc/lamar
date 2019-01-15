﻿namespace LamarCompiler.Model
{
    public interface IServiceVariableSource : IVariableSource
    {
        void ReplaceVariables();
        void StartNewType();
        void StartNewMethod();
    }
}