namespace Chrome.Common.Contracts;

public interface IChildViewModel
{
    void SetParentViewModel<T>(T viewModel) where T : IParentViewModel;
}