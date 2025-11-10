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
    public required TerraformProperty<TerraformProperty<string>> DeviceId { get; set; }

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
    /// The aws_location attribute.
    /// </summary>
    [TerraformPropertyName("aws_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AwsLocation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "aws_location");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Location => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "location");

    /// <summary>
    /// The model attribute.
    /// </summary>
    [TerraformPropertyName("model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Model => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "model");

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformPropertyName("serial_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SerialNumber => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "serial_number");

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformPropertyName("site_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SiteId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "site_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    [TerraformPropertyName("vendor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Vendor => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vendor");

}
