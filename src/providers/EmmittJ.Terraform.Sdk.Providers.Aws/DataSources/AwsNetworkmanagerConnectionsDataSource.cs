using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_connections.
/// </summary>
public partial class AwsNetworkmanagerConnectionsDataSource : TerraformDataSource
{
    public AwsNetworkmanagerConnectionsDataSource(string name) : base("aws_networkmanager_connections", name)
    {
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [TerraformProperty("device_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformProperty("ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Ids { get; }

}
