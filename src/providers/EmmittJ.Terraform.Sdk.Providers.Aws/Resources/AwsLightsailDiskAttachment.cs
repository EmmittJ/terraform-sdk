using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_disk_attachment resource.
/// </summary>
public partial class AwsLightsailDiskAttachment : TerraformResource
{
    public AwsLightsailDiskAttachment(string name) : base("aws_lightsail_disk_attachment", name)
    {
    }

    /// <summary>
    /// The disk_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskName is required")]
    [TerraformProperty("disk_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DiskName { get; set; }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskPath is required")]
    [TerraformProperty("disk_path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DiskPath { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformProperty("instance_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

}
