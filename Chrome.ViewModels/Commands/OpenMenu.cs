using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using Chrome.ViewModels.Contracts;
using System.Windows.Input;
using Chrome.Models;

namespace Chrome.ViewModels.Commands;

public class OpenMenu(IShellViewModel viewModel) : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        var grid = parameter as Grid;

        if (grid?.DataContext is not MenuUiItem dc) return;
        if (viewModel.SearchByFilteredItems != null && dc == viewModel.SelectedMenu?.MenuUiItem) return;

        viewModel.SelectedMenu = new SelectedMenuItem
        {
            MenuUiItem = dc,
            Position = grid.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0)),
            MenuWidth = grid.ActualWidth
        };

        Debug.Print($"\t*** header: {dc.Parent?.HeaderDe} - margin: {grid.Margin.Left}");
    }

    public event EventHandler? CanExecuteChanged;
}