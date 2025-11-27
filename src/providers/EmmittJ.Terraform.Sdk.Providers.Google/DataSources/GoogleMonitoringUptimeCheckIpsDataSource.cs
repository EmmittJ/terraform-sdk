using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_monitoring_uptime_check_ips Terraform data source.
/// Retrieves information about a google_monitoring_uptime_check_ips.
/// </summary>
public partial class GoogleMonitoringUptimeCheckIpsDataSource(string name) : TerraformDataSource("google_monitoring_uptime_check_ips", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The uptime_check_ips attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UptimeCheckIps
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "uptime_check_ips").ResolveNodes(ctx));
    }

}
