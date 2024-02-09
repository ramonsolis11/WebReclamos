namespace WebReclamos.Services
{
    public class SapServiceLayerClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<SapServiceLayerClient> _logger;

        public SapServiceLayerClient(HttpClient httpClient, IConfiguration configuration, ILogger<SapServiceLayerClient> logger)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            var sapServiceLayerUrl = _configuration["SapServiceLayer:Url"];
            var sapServiceLayerCompany = _configuration["SapServiceLayer:Company"];
            var sapServiceLayerUsername = _configuration["SapServiceLayer:Username"];
            var sapServiceLayerPassword = _configuration["SapServiceLayer:Password"];

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("CompanyDB", sapServiceLayerCompany);
            _httpClient.DefaultRequestHeaders.Add("UserName", sapServiceLayerUsername);
            _httpClient.DefaultRequestHeaders.Add("Password", sapServiceLayerPassword);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.PostAsync($"{sapServiceLayerUrl}/{requestUri}", content);
            return response;
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            var sapServiceLayerUrl = _configuration["SapServiceLayer:Url"];
            var sapServiceLayerCompany = _configuration["SapServiceLayer:Company"];
            var sapServiceLayerUsername = _configuration["SapServiceLayer:Username"];
            var sapServiceLayerPassword = _configuration["SapServiceLayer:Password"];

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("CompanyDB", sapServiceLayerCompany);
            _httpClient.DefaultRequestHeaders.Add("UserName", sapServiceLayerUsername);
            _httpClient.DefaultRequestHeaders.Add("Password", sapServiceLayerPassword);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"{sapServiceLayerUrl}/{requestUri}");
            return response;
        }

        public async Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content)
        {
            var sapServiceLayerUrl = _configuration["SapServiceLayer:Url"];
            var sapServiceLayerCompany = _configuration["SapServiceLayer:Company"];
            var sapServiceLayerUsername = _configuration["SapServiceLayer:Username"];
            var sapServiceLayerPassword = _configuration["SapServiceLayer:Password"];

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("CompanyDB", sapServiceLayerCompany);
            _httpClient.DefaultRequestHeaders.Add("UserName", sapServiceLayerUsername);
            _httpClient.DefaultRequestHeaders.Add("Password", sapServiceLayerPassword);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.PatchAsync($"{sapServiceLayerUrl}/{requestUri}", content);
            return response;
        }
    }
}
