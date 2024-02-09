namespace Chrome.Common;

public interface IChildViewModel
{
    void SetParentViewModel<T>(T viewModel) where T : IParentViewModel;
}