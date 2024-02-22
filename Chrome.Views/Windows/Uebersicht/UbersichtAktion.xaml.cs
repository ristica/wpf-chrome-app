﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Chrome.Common.Contracts;
using Chrome.Views.Contracts.Uebersicht;
using Chrome.Views.Helpers;
using Chrome.Views.Windows.ShellUserControls;

namespace Chrome.Views.Windows.Uebersicht;

public partial class UbersichtAktion : UserControl, IUebersichtAktionUserControl
{
    public UbersichtAktion()
    {
        InitializeComponent();
    }

    public IUserControlParentViewModel ViewModel { get; private set; }

    public void SetDataContext<T>(T viewModel) where T : IUserControlParentViewModel
    {
        ViewModel = viewModel;
    }

    #region RESIZING, MOVING

    private int _edgeType;

    private void SetSizing(object sender, MouseButtonEventArgs e)
    {
        var main = this.GetMainUserControlParent() as MainContentUserControl;

        main!.IsSizing = true;
        main.SizingEdgeType = _edgeType;
        main.SizingPanel = this;
    }

    private void RecTop_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        var offset = e.GetPosition(BorderTopBar);
        var offsetX = offset.X;
        var offsetY = offset.Y;

        var main = this.GetMainUserControlParent() as MainContentUserControl;

        main!.IsSizing = true;
        main.SizingEdgeType = 0;
        main.SizingPanel = this;
        main.SizingOffsetX = offsetX;
        main.SizingOffsetY = offsetY;
    }

    private UIElement GetMainUserControlParent()
    {
        var canvasMain = Parent as Canvas;
        var cc = canvasMain!.Parent as ContentControl;
        return (cc!.Parent as MainContentUserControl)!;
    }

    private void MarkerOnMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (sender is not Border marker) return;

        this._edgeType = marker.Name switch
        {
            "MarkerLeftTop" => (int)EdgeTypes.TopLeft,
            "MarkerRightTop" => (int)EdgeTypes.TopRight,
            "MarkerRightBottom" => (int)EdgeTypes.BottomRight,
            "MarkerLeftBottom" => (int)EdgeTypes.BottomLeft,
            _ => (int)EdgeTypes.TopMove
        };

        SetSizing(sender, e);
    }

    private void MarkerOnMouseLeave(object sender, MouseEventArgs e)
    {
        Cursor = Cursors.Arrow;
    }

    #endregion
}