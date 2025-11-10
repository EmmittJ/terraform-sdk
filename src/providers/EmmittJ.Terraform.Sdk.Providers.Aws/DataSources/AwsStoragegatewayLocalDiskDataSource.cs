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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskNode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_node");

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    [TerraformPropertyName("disk_path")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskPath { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_path");

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformPropertyName("gateway_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GatewayArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_id");

}
