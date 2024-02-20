namespace Chrome.Common.Contracts;

public interface IUserControlParentViewModel
{
    void SetDataContext(IUserControlParentViewModel viewModel);
    IUserControl? GetUserControl();
}