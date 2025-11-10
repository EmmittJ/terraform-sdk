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
    public required TerraformProperty<TerraformProperty<string>> ConnectionId { get; set; }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    [TerraformPropertyName("global_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GlobalNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The connected_device_id attribute.
    /// </summary>
    [TerraformPropertyName("connected_device_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectedDeviceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connected_device_id");

    /// <summary>
    /// The connected_link_id attribute.
    /// </summary>
    [TerraformPropertyName("connected_link_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectedLinkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connected_link_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [TerraformPropertyName("device_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeviceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "device_id");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [TerraformPropertyName("link_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LinkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "link_id");

}
