using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_device.
/// </summary>
public class AwsNetworkmanagerDeviceDataSource : TerraformDataSource
{
    public AwsNetworkmanagerDeviceDataSource(string name) : base("aws_networkmanager_device", name)
    {
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    [TerraformPropertyName("device_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeviceId { get; set; }

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
    /// The aws_location attribute.
    /// </summary>
    [TerraformPropertyName("aws_location")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AwsLocation => new TerraformReference(this, "aws_location");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The model attribute.
    /// </summary>
    [TerraformPropertyName("model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Model => new TerraformReference(this, "model");

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformPropertyName("serial_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SerialNumber => new TerraformReference(this, "serial_number");

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformPropertyName("site_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SiteId => new TerraformReference(this, "site_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    [TerraformPropertyName("vendor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Vendor => new TerraformReference(this, "vendor");

}
