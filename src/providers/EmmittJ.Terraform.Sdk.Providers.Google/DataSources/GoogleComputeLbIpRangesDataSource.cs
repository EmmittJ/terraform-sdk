using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_lb_ip_ranges.
/// </summary>
public class GoogleComputeLbIpRangesDataSource : TerraformDataSource
{
    public GoogleComputeLbIpRangesDataSource(string name) : base("google_compute_lb_ip_ranges", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("http_ssl_tcp_internal");
        SetOutput("network");
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
    /// The http_ssl_tcp_internal attribute.
    /// </summary>
    public TerraformExpression HttpSslTcpInternal => this["http_ssl_tcp_internal"];

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformExpression Network => this["network"];

}
