using System;
using System.Threading.Tasks;
using blogs.dhrutara.com.aspnetreactfileupload.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace blogs.dhrutara.com.aspnetreactfileupload.Web.Controllers
{
    [ApiController]
	[Route("api/[controller]")]
	public class DocumentController : Controller {
		private readonly ILogger<DocumentController> _logger;

		public DocumentController(ILogger<DocumentController> logger) {
			this._logger = logger;
		}

		[HttpPost]
		[Route("uploaddocument")]
		public async Task<IActionResult> UploadDocumentAsync([FromForm]UploadFileRequest uploadFileRequest) {
            try
            {
				//Process the request
				return new StatusCodeResult(StatusCodes.Status200OK);
            }catch(Exception ex)
            {
				this._logger.LogError(ex, ex.Message);
				return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
		}
	}
}
