using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_storagegateway_local_disk.
/// </summary>
public partial class AwsStoragegatewayLocalDiskDataSource : TerraformDataSource
{
    public AwsStoragegatewayLocalDiskDataSource(string name) : base("aws_storagegateway_local_disk", name)
    {
    }

    /// <summary>
    /// The disk_node attribute.
    /// </summary>
    [TerraformProperty("disk_node")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskNode { get; set; }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    [TerraformProperty("disk_path")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskPath { get; set; }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformProperty("gateway_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GatewayArn { get; set; }

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
    /// The disk_id attribute.
    /// </summary>
    [TerraformProperty("disk_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DiskId { get; }

}
