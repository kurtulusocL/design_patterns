using CQRSPattern.CQRS.mediatR.Commands.LocationCommands;
using CQRSPattern.CQRS.mediatR.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.WebUI.Controllers
{
    public class LocationController : Controller
    {
        private readonly IMediator _mediator;
        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllLocationQuery());
            return View(values);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var value = await _mediator.Send(new GetLocationByIdQuery(id));
            return View(value);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLocationCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var value = await _mediator.Send(new GetLocationByIdForUpdateQuery(id));
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateLocationCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Edit), new { id = command.Id });
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteLocationCommand(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
