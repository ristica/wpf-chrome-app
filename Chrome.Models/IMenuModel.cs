using System.ComponentModel;

namespace Chrome.Models;

public interface IMenuModel : INotifyPropertyChanged
{
    Guid Id { get; }
    int Order { get; set; }
    string HeaderDe { get; set; }
    string? HeaderEn { get; set; }
    bool IsChild { get; set; }
    string? ParentIdDe { get; set; }
    string? ParentIdEn { get; set; }
    bool HasChildren { get; set; }
    string NeedsOneOfRoles { get; set; }
}