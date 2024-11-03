using real_state_fund_model;

namespace real_state_fund_iservice;

public interface IFundService
{
    IList<StateFundModel> FindAllStateFunds();
    
    StateFundModel FindStateFundById(Guid id);
    
    StateFundModel SaveStateFund(StateFundModel fund);
    
    void DeleteStateFundById(Guid id);
}