using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_connection.
/// </summary>
public class AwsNetworkmanagerConnectionDataSource : TerraformDataSource
{
    public AwsNetworkmanagerConnectionDataSource(string name) : base("aws_networkmanager_connection", name)
    {
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    [TerraformPropertyName("global_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GlobalNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The connected_device_id attribute.
    /// </summary>
    [TerraformPropertyName("connected_device_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectedDeviceId => new TerraformReference(this, "connected_device_id");

    /// <summary>
    /// The connected_link_id attribute.
    /// </summary>
    [TerraformPropertyName("connected_link_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectedLinkId => new TerraformReference(this, "connected_link_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [TerraformPropertyName("device_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeviceId => new TerraformReference(this, "device_id");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [TerraformPropertyName("link_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LinkId => new TerraformReference(this, "link_id");

}
