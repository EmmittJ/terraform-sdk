using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for aws_location in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerDeviceAwsLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [TerraformProperty("subnet_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetArn { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

}

/// <summary>
/// Block type for location in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerDeviceLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformProperty("address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Address { get; set; }

    /// <summary>
    /// The latitude attribute.
    /// </summary>
    [TerraformProperty("latitude")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Latitude { get; set; }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    [TerraformProperty("longitude")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Longitude { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkmanagerDeviceTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_device resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNetworkmanagerDevice : TerraformResource
{
    public AwsNetworkmanagerDevice(string name) : base("aws_networkmanager_device", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    /// The model attribute.
    /// </summary>
    [TerraformProperty("model")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformProperty("serial_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SerialNumber { get; set; }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformProperty("site_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SiteId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    [TerraformProperty("vendor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Vendor { get; set; }

    /// <summary>
    /// Block for aws_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsLocation block(s) allowed")]
    [TerraformProperty("aws_location")]
    public partial TerraformList<TerraformBlock<AwsNetworkmanagerDeviceAwsLocationBlock>>? AwsLocation { get; set; }

    /// <summary>
    /// Block for location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    [TerraformProperty("location")]
    public partial TerraformList<TerraformBlock<AwsNetworkmanagerDeviceLocationBlock>>? Location { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsNetworkmanagerDeviceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
