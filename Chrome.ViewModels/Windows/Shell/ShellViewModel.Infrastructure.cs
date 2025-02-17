﻿using System.Globalization;
using System.Windows;
using Chrome.Common.Contracts;
using Chrome.ViewModels.Contracts;
using Localization.WPF;

namespace Chrome.ViewModels.Windows.Shell;

public partial class ShellViewModel
{
    #region PROPERTIES

    public string CurrentCultureName => LocalizationManager.CurrentCulture.Name;
    public string WindowTitle => "CRM - Light";
    public bool CanClose => true;
    public ResizeMode ResizeMode => ResizeMode.CanMinimize;
    public WindowState CurrentWindowState => _view.CurrentWindowState;

    #endregion

    #region METHODS

    public void CultureChanged(string cultureName)
    {
        OnPropertyChanged(nameof(CurrentCultureName));
        this.SetCarouselItems();
    }

    public void OpenView(string name)
    {
        // allow only one instance of each window to be created !!!
        var found = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.Name.Equals(name));
        if (found is IView view)
        {
            view.ActivateMe();
            return;
        }

        // ToDo: make some algorithm to find a corresponding IXxxxViewModel from the "name" param
        // ...

        this._container.Resolve<IParentViewModel>("IUebersichtAktionenViewModel").GetView().OpenMe();
    }

    public void MaximizeView()
    {
        _view.MaximizeView();
        OnPropertyChanged(nameof(CurrentWindowState));
    }

    public void MinimizeView()
    {
        _view.MinimizeView();
    }

    public void CloseView()
    {
        if (!CanClose) return;

        Dispose();
        _view.CloseMe();
    }

    public void DragWindow()
    {
        _view.DragMe();
    }

    #endregion
}