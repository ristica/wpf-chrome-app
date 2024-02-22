﻿using System.Windows;
using System.Windows.Input;
using Chrome.Common.Contracts;

namespace Chrome.ViewModels.Commands.Common;

public class MinimizeWindowCommand(IParentViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }


    public void Execute(object? parameter)
    {
    }

    public event EventHandler? CanExecuteChanged;
}