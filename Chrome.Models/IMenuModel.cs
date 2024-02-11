using System.Windows.Controls;

namespace Chrome.Models;

public interface IMenuModel
{
    Guid Id { get; }
    int Order { get; set; }
    string Header { get; set; } 
    bool IsChild { get; set; }
    string? ParentId { get; set; }
    bool HasChildren { get; set; }
    string NeedsOneOfRoles { get; set; }
}

public class MenuModel : IMenuModel
{
    public Guid Id { get; private set; }
    public int Order { get; set; }
    public string Header { get; set; } = string.Empty;
    public bool IsChild { get; set; }
    public string? ParentId { get; set; }
    public bool HasChildren { get; set; }
    public string NeedsOneOfRoles { get; set; } = string.Empty;
}