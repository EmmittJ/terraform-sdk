using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_device.
/// </summary>
public partial class AwsNetworkmanagerDeviceDataSource : TerraformDataSource
{
    public AwsNetworkmanagerDeviceDataSource(string name) : base("aws_networkmanager_device", name)
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
    /// The aws_location attribute.
    /// </summary>
    [TerraformProperty("aws_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AwsLocation { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Location { get; }

    /// <summary>
    /// The model attribute.
    /// </summary>
    [TerraformProperty("model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Model { get; }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformProperty("serial_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SerialNumber { get; }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformProperty("site_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SiteId { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    [TerraformProperty("vendor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Vendor { get; }

}
