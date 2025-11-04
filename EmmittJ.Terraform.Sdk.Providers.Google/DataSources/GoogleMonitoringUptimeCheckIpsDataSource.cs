using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_uptime_check_ips.
/// </summary>
public class GoogleMonitoringUptimeCheckIpsDataSource : TerraformDataSource
{
    public GoogleMonitoringUptimeCheckIpsDataSource(string name) : base("google_monitoring_uptime_check_ips", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("uptime_check_ips");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The uptime_check_ips attribute.
    /// </summary>
    public TerraformExpression UptimeCheckIps => this["uptime_check_ips"];

}
