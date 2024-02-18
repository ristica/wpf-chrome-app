namespace Chrome.Models;

public class MenuUiItem
{
    public Guid UiId { get; init; } = Guid.NewGuid();
    public MenuModel? Parent { get; set; }
    public List<MenuModel?> Children { get; init; } = new();
}