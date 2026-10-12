using Microsoft.AspNetCore.Mvc;
using TravelGuides.Api.Services;
using TravelGuides.Api.ViewModels;

namespace TravelGuides.Api.Controllers;

[ApiController]
[Route("api/guides")]
public class GuidesController : ControllerBase
{
    private readonly GuideService _guideService;

    public GuidesController(GuideService guideService)
    {
        _guideService = guideService;
    }

    [HttpGet]
    public async Task<ActionResult<List<GuideSummaryViewModel>>> GetAll(
        CancellationToken cancellationToken)
    {
        var guides = await _guideService.GetAllAsync(
            cancellationToken);

        return Ok(guides);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<GuideDetailsViewModel>> GetById(
        int id,
        CancellationToken cancellationToken)
    {
        var guide = await _guideService.GetByIdAsync(
            id,
            cancellationToken);

        if (guide is null)
        {
            return NotFound();
        }

        return Ok(guide);
    }
}