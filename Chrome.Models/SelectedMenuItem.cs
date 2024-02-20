using System.Windows;

namespace Chrome.Models;

public class SelectedMenuItem
{
    public required MenuUiItem MenuUiItem { get; init; }
    public required Point Position { get; init; }
}