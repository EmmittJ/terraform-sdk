using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerLinkAssociationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_link_association resource.
/// </summary>
public partial class AwsNetworkmanagerLinkAssociation : TerraformResource
{
    public AwsNetworkmanagerLinkAssociation(string name) : base("aws_networkmanager_link_association", name)
    {
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    [TerraformProperty("device_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceId { get; set; }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    [TerraformProperty("global_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GlobalNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkId is required")]
    [TerraformProperty("link_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsNetworkmanagerLinkAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
