using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_lb_ip_ranges.
/// </summary>
public class GoogleComputeLbIpRangesDataSource : TerraformDataSource
{
    public GoogleComputeLbIpRangesDataSource(string name) : base("google_compute_lb_ip_ranges", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The http_ssl_tcp_internal attribute.
    /// </summary>
    [TerraformPropertyName("http_ssl_tcp_internal")]
    // Output-only attribute - read-only reference
    public TerraformList<string> HttpSslTcpInternal => new TerraformReference(this, "http_ssl_tcp_internal");

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Network => new TerraformReference(this, "network");

}
