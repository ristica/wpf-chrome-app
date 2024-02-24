namespace Chrome.Common.Contracts;

public interface IUserControlParentViewModel
{
    IUserControl? GetUserControl();
    void DisposeMe();
    string WindowTitle { get; set; }
    string WindowIdentifier { get; set; }
}