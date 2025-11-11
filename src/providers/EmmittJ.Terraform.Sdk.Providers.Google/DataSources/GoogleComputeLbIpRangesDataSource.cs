using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_lb_ip_ranges.
/// </summary>
public partial class GoogleComputeLbIpRangesDataSource : TerraformDataSource
{
    public GoogleComputeLbIpRangesDataSource(string name) : base("google_compute_lb_ip_ranges", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The http_ssl_tcp_internal attribute.
    /// </summary>
    [TerraformProperty("http_ssl_tcp_internal")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> HttpSslTcpInternal { get; }

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Network { get; }

}
