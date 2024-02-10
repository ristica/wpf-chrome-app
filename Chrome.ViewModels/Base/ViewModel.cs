﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chrome.ViewModels.Base;

public abstract class ViewModel : INotifyPropertyChanged, IDisposable
{
    #region IDisposable

    public void Dispose()
    {
        this.DisposeViewModel();
    }

    protected abstract void DisposeViewModel();

    #endregion

    #region INotifyPropertyChanged 

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}