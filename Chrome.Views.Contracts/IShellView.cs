using Chrome.Common;

namespace Chrome.Views.Contracts;

public interface IShellView
{
    IParentViewModel ViewModel { get; }
    void OpenMe();
    void CloseMe();
    void MaximizeView();
    void MinimizeView();
    void SetDataContext<T>(T viewModel) where T : IParentViewModel;
}