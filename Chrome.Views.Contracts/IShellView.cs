using Chrome.Common;

namespace Chrome.Views.Contracts
{
    public interface IShellView
    {
        void OpenMe();
        void CloseMe();
        void SetDataContext<T>(T viewModel) where T : IViewModel;
    }
}
