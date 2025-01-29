using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManager.HealthCheck
{
    public class SampleHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            // Perform health check logic here
            bool healthCheckResultHealthy = true; // Replace with actual health check logic

            if (healthCheckResultHealthy)
            {
                return Task.FromResult(HealthCheckResult.Healthy("The check indicates a healthy result."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("The check indicates an unhealthy result."));
        }
    }
}
