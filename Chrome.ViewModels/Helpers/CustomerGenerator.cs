using Chrome.Models;

namespace Chrome.ViewModels.Helpers;

public class CustomerGenerator
{
    public static List<CustomerUiModel> Generate()
    {
        return
        [
            new CustomerUiModel
            {
                FirstName = "Aleksandar",
                LastName = "Ristic",
                Id = Guid.NewGuid(),
                Kundennummer = "1"
            },
            new CustomerUiModel
            {
                FirstName = "Pingo",
                LastName = "Profi",
                Id = Guid.NewGuid(),
                Kundennummer = "2"
            }
        ];
    }
}