using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_efs_access_point.
/// </summary>
public partial class AwsEfsAccessPointDataSource : TerraformDataSource
{
    public AwsEfsAccessPointDataSource(string name) : base("aws_efs_access_point", name)
    {
    }

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPointId is required")]
    [TerraformProperty("access_point_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessPointId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformProperty("file_system_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FileSystemArn { get; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformProperty("file_system_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FileSystemId { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The posix_user attribute.
    /// </summary>
    [TerraformProperty("posix_user")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PosixUser { get; }

    /// <summary>
    /// The root_directory attribute.
    /// </summary>
    [TerraformProperty("root_directory")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RootDirectory { get; }

}
