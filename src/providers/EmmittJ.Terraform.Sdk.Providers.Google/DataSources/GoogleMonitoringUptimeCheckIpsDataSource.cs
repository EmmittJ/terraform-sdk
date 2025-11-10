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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The uptime_check_ips attribute.
    /// </summary>
    [TerraformPropertyName("uptime_check_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UptimeCheckIps => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "uptime_check_ips");

}
