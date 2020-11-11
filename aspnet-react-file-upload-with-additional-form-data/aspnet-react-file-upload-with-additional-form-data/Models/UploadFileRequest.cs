
using blogs.dhrutara.com.aspnetreactfileupload.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace blogs.dhrutara.com.aspnetreactfileupload.Web.Models {
	public class UploadFileRequest {
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
		public string Version { get; set; }
		public IFormFile File { get; set; }
		public IEnumerable<Author> Authors { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
	}
}
