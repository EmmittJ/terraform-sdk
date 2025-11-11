using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for device in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDeviceDeviceBlock : TerraformBlockBase
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// The iot_thing_name attribute.
    /// </summary>
    [TerraformProperty("iot_thing_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IotThingName { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_device resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerDevice : TerraformResource
{
    public AwsSagemakerDevice(string name) : base("aws_sagemaker_device", name)
    {
    }

    /// <summary>
    /// The device_fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceFleetName is required")]
    [TerraformProperty("device_fleet_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceFleetName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Device is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Device block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Device block(s) allowed")]
    [TerraformProperty("device")]
    public partial TerraformList<TerraformBlock<AwsSagemakerDeviceDeviceBlock>>? Device { get; set; }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformProperty("agent_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentVersion { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
