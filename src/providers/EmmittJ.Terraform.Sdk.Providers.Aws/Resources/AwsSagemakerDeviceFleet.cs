using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDeviceFleetOutputConfigBlock() : TerraformBlock("output_config")
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The s3_output_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputLocation is required")]
    [TerraformProperty("s3_output_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3OutputLocation { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_device_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerDeviceFleet : TerraformResource
{
    public AwsSagemakerDeviceFleet(string name) : base("aws_sagemaker_device_fleet", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The device_fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceFleetName is required")]
    [TerraformProperty("device_fleet_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceFleetName { get; set; }

    /// <summary>
    /// The enable_iot_role_alias attribute.
    /// </summary>
    [TerraformProperty("enable_iot_role_alias")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableIotRoleAlias { get; set; }

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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

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
    /// Block for output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    [TerraformProperty("output_config")]
    public required TerraformList<AwsSagemakerDeviceFleetOutputConfigBlock> OutputConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The iot_role_alias attribute.
    /// </summary>
    [TerraformProperty("iot_role_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IotRoleAlias { get; }

}
