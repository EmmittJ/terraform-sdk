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
        SetOutput("uptime_check_ips");
        SetOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The uptime_check_ips attribute.
    /// </summary>
    public TerraformExpression UptimeCheckIps => this["uptime_check_ips"];

}
