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

        this.Name = MenuIdentifiers.Uebersicht.UbersichtAktionen;
    }
}