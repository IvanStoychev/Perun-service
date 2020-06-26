using Microsoft.Extensions.Configuration;

namespace Perun_service_WeatherAPI.Controllers
{
    /// <summary>
    /// Orchestrates all API calls for this service.
    /// </summary>
    class MasterController
    {
        IConfigurationRoot configuration;

        /// <summary>
        /// Creates a new instance of the class, using the passed <see cref="IConfigurationRoot"/>
        /// to retrieve parameters for the API calls.
        /// </summary>
        /// <param name="config">
        /// An <see cref="IConfigurationRoot"/> for to the file containing information about the API calls parameters.
        /// </param>
        public MasterController(IConfigurationRoot config) => configuration = config;
    }
}
