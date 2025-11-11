using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_networking_peered_dns_domain.
/// </summary>
public partial class GoogleServiceNetworkingPeeredDnsDomainDataSource : TerraformDataSource
{
    public GoogleServiceNetworkingPeeredDnsDomainDataSource(string name) : base("google_service_networking_peered_dns_domain", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformProperty("dns_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsSuffix { get; }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [TerraformProperty("parent")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Parent { get; }

}
