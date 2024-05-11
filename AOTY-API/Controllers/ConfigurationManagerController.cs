using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.Enums;
using Services.DataServices;

namespace AOTY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationManagerController : ControllerBase
    {
        #region Properties / Attributes

        private readonly ILogger<ConfigurationManagerController> _logger;
        private readonly IGenresDataService _genresDataService;

        #endregion Properties / Attributes

        #region _CTOR_

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationManagerController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="genresDataService">The genres data service.</param>
        public ConfigurationManagerController(ILogger<ConfigurationManagerController> logger, IGenresDataService genresDataService)
        {
            _logger = logger;
            _genresDataService = genresDataService;
        }

        #endregion

        [HttpPost("JustForTest", Name = "JustForTest")]
        public async Task<IActionResult> UpdateGenres()
        {
            try
            {
                var newGenre = new GenresDto
                {
                    GenreCode = "CodeTest",
                    GenreName = "GenreName"
                };
                await _genresDataService.AddNewGenre(newGenre);

                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding Emitter");
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
