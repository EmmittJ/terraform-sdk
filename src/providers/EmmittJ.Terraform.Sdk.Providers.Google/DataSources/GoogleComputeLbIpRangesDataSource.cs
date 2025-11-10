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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The http_ssl_tcp_internal attribute.
    /// </summary>
    [TerraformPropertyName("http_ssl_tcp_internal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> HttpSslTcpInternal => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "http_ssl_tcp_internal");

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Network => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "network");

}
