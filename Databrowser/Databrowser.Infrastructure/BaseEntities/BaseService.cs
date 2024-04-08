namespace m.Infrastructure.BaseEntities
{
    using Microsoft.Extensions.Logging;

    public abstract class BaseService
    {
        protected readonly ILogger<BaseService> _logger;

        protected BaseService(ILogger<BaseService> logger)
        {
            _logger = logger;
        }        
    }
}
