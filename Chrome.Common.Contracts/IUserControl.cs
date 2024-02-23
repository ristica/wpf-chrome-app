using System.Windows.Input;

namespace Chrome.Common.Contracts;

public interface IUserControl
{
    IUserControlParentViewModel? ViewModel { get; }
    void SetDataContext<T>(T? viewModel) where T : IUserControlParentViewModel;

    void OnUserControlActivate();
    void OnUserControlMouseLeave();
    void OnMarkerMouseDown(string marker);
    void OnTopBarMouseDown(MouseButtonEventArgs e);
}