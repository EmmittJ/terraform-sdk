using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_storagegateway_local_disk.
/// </summary>
public class AwsStoragegatewayLocalDiskDataSource : TerraformDataSource
{
    public AwsStoragegatewayLocalDiskDataSource(string name) : base("aws_storagegateway_local_disk", name)
    {
    }

    /// <summary>
    /// The disk_node attribute.
    /// </summary>
    [TerraformPropertyName("disk_node")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskNode { get; set; } = default!;

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    [TerraformPropertyName("disk_path")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskPath { get; set; } = default!;

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformPropertyName("gateway_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GatewayArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiskId => new TerraformReference(this, "disk_id");

}
