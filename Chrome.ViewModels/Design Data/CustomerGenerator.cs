using Chrome.Models;

namespace Chrome.ViewModels.Design_Data;

public static class CustomerGenerator
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
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Pingo",
                LastName = "Profi",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "John",
                LastName = "Doe",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Donald",
                LastName = "Duck",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Bugs",
                LastName = "Bunny",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Henry",
                LastName = "Ford",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Malcolm",
                LastName = "McLaren",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Johnny",
                LastName = "Cash",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Elvis",
                LastName = "Presley",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Mark",
                LastName = "Spitz",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Franz",
                LastName = "Mustermann",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Hans",
                LastName = "Krankl",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Herbert",
                LastName = "Prohaska",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Brad",
                LastName = "Pitt",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            },
            new CustomerUiModel
            {
                FirstName = "Henry",
                LastName = "Mancini",
                Id = Guid.NewGuid(),
                Kundennummer = new Random().Next(100000, 999999).ToString()
            }
        ];
    }
}