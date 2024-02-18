using System.Windows;
using Chrome.Constants;
using Chrome.Views.Base;
using Chrome.Views.Contracts;

namespace Chrome.Views.Windows;

public partial class UebersichtAktionenView : BaseView, IUebersichtAktionenView
{
    public event EventHandler<WindowState>? WindowStateChanged;
    public event EventHandler? WindowLoaded;

    public WindowState CurrentWindowState => WindowState;

    public UebersichtAktionenView()
    {
        InitializeComponent();
        this.SetWindowName();
    }

    protected sealed override void SetWindowName()
    {
        this.Name = WindowIdentifiers.Uebersicht.Aktionen;
    }
}