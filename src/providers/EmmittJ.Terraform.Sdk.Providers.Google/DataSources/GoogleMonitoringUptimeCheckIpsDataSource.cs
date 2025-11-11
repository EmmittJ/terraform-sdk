using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_uptime_check_ips.
/// </summary>
public class GoogleMonitoringUptimeCheckIpsDataSource : TerraformDataSource
{
    public GoogleMonitoringUptimeCheckIpsDataSource(string name) : base("google_monitoring_uptime_check_ips", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The uptime_check_ips attribute.
    /// </summary>
    [TerraformPropertyName("uptime_check_ips")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UptimeCheckIps => new TerraformReference(this, "uptime_check_ips");

}
