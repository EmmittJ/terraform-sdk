using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_lb_ip_ranges Terraform data source.
/// Retrieves information about a google_compute_lb_ip_ranges.
/// </summary>
public partial class GoogleComputeLbIpRangesDataSource(string name) : TerraformDataSource("google_compute_lb_ip_ranges", name)
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
    /// The http_ssl_tcp_internal attribute.
    /// </summary>
    public TerraformList<string> HttpSslTcpInternal
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "http_ssl_tcp_internal").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformList<string> Network
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network").ResolveNodes(ctx));
    }

}
