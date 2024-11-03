namespace real_state_fund_model;

public class StateFundModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public DateTime dat_creation { get; set; }
    public DateTime dat_update { get; set; }
    public string cnpj { get; set; }
}