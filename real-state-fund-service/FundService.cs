using real_state_fund_iservice;
using real_state_fund_model;

namespace real_state_fund_service;

public class FundService : IFundService
{
    private static IList<StateFundModel> StateFunds = new List<StateFundModel>
    {
        new StateFundModel()
        {
            Id = Guid.Parse("47869474-3186-4cd3-ae43-d40f1f81c471"),
            Code = "AAGR11",
            Name = "ASSET BANK AGRONEGÓCIOS FIAGRO IMOBILIARIO",
            cnpj = "44.585.001/0001-10",
            dat_creation = new DateTime(2024, 11, 1),
            dat_update = new DateTime(2024, 11, 1)
        },
        new StateFundModel()
        {
            Id = Guid.Parse("f63c80e7-5635-4380-bee0-64c4e60303de"),
            Code = "SNME11",
            Name = "Suno Multiestratégia",
            cnpj = "52.227.760/0001-30",
            dat_creation = new DateTime(2024, 11, 1),
            dat_update = new DateTime(2024, 11, 1)
        },
        new StateFundModel()
        {
            Id = Guid.Parse("2bf12b14-c71b-45ef-804c-2658d9b82150"),
            Code = "KNHF11",
            Name = "KNHF11",
            cnpj = "42.754.342/0001-47",
            dat_creation = new DateTime(2024, 11, 1),
            dat_update = new DateTime(2024, 11, 1)
        }
    };
    
    public IList<StateFundModel> FindAllStateFunds()
    {
        return StateFunds;
    }

    public StateFundModel? FindStateFundById(Guid id)
    {
        return StateFunds.FirstOrDefault(fund => fund.Id.Equals(id));
    }

    public StateFundModel SaveStateFund(StateFundModel fund)
    {
        StateFunds.Add(fund);
        return fund;
    }

    public void DeleteStateFundById(Guid id)
    {
        StateFunds.Remove(StateFunds.FirstOrDefault(fund => fund.Id.Equals(id)));
    }
}