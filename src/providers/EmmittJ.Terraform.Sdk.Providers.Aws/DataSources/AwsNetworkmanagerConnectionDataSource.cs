using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_connection.
/// </summary>
public partial class AwsNetworkmanagerConnectionDataSource : TerraformDataSource
{
    public AwsNetworkmanagerConnectionDataSource(string name) : base("aws_networkmanager_connection", name)
    {
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionId { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The connected_device_id attribute.
    /// </summary>
    [TerraformProperty("connected_device_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectedDeviceId { get; }

    /// <summary>
    /// The connected_link_id attribute.
    /// </summary>
    [TerraformProperty("connected_link_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectedLinkId { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [TerraformProperty("device_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeviceId { get; }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [TerraformProperty("link_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LinkId { get; }

}
