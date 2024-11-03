using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using real_state_fund_iservice;
using real_state_fund_model;

namespace real_state_fund_api.Controller;

[Route("api/fund")]
[ApiController]
public class FundController : ControllerBase
{
    private IFundService fundService;

    public FundController(IFundService fundService)
    {
        this.fundService = fundService;
    }
    
    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    public IList<StateFundModel> GetStateFunds()
    {
        return fundService.FindAllStateFunds();
    }
    
    [HttpGet("{id}")]
    [Produces(MediaTypeNames.Application.Json)]
    public IActionResult GetFund(Guid id)
    {
        var fund = fundService.FindStateFundById(id);

        if (fund == null) return NotFound();
        return Ok(fund);
    }
    
    [HttpPost]
    [Produces(MediaTypeNames.Application.Json)]
    public IActionResult SaveNewFund(StateFundCreateDto stateFund)
    {
        StateFundModel stateFundModel = new StateFundModel
        {
            Name = stateFund.Name,
            cnpj = stateFund.Cnpj,
            Code = stateFund.Code,
            Id = Guid.NewGuid(),
            dat_creation = DateTime.Now,
            dat_update = DateTime.Now,
        };

        fundService.SaveStateFund(stateFundModel);

        return Ok(stateFundModel);
    }

    [HttpDelete]
    public IActionResult DeleteFund(Guid id)
    {
        fundService.DeleteStateFundById(id);
        return NoContent();
    }
}