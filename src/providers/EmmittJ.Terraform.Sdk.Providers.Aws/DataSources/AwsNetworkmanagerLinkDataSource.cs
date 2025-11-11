using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_link.
/// </summary>
public partial class AwsNetworkmanagerLinkDataSource : TerraformDataSource
{
    public AwsNetworkmanagerLinkDataSource(string name) : base("aws_networkmanager_link", name)
    {
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    [TerraformProperty("global_network_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GlobalNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    [TerraformProperty("link_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LinkId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [TerraformProperty("bandwidth")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Bandwidth { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProviderName { get; }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformProperty("site_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SiteId { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
