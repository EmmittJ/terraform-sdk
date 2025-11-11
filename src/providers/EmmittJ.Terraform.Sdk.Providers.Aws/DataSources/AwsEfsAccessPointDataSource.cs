using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_access_point.
/// </summary>
public class AwsEfsAccessPointDataSource : TerraformDataSource
{
    public AwsEfsAccessPointDataSource(string name) : base("aws_efs_access_point", name)
    {
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPointId is required")]
    [TerraformPropertyName("access_point_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccessPointId { get; set; }

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
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformPropertyName("file_system_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FileSystemArn => new TerraformReference(this, "file_system_arn");

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("file_system_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FileSystemId => new TerraformReference(this, "file_system_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The posix_user attribute.
    /// </summary>
    [TerraformPropertyName("posix_user")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PosixUser => new TerraformReference(this, "posix_user");

    /// <summary>
    /// The root_directory attribute.
    /// </summary>
    [TerraformPropertyName("root_directory")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RootDirectory => new TerraformReference(this, "root_directory");

}
