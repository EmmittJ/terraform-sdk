using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for posix_user in .
/// Nesting mode: list
/// </summary>
public partial class AwsEfsAccessPointPosixUserBlock() : TerraformBlock("posix_user")
{
    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    [TerraformProperty("gid")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Gid { get; set; }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    [TerraformProperty("secondary_gids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? SecondaryGids { get; set; }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    [TerraformProperty("uid")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Uid { get; set; }

}

/// <summary>
/// Block type for root_directory in .
/// Nesting mode: list
/// </summary>
public partial class AwsEfsAccessPointRootDirectoryBlock() : TerraformBlock("root_directory")
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Manages a aws_efs_access_point resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEfsAccessPoint : TerraformResource
{
    public AwsEfsAccessPoint(string name) : base("aws_efs_access_point", name)
    {
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    [TerraformProperty("file_system_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileSystemId { get; set; }

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
    /// Block for posix_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixUser block(s) allowed")]
    [TerraformProperty("posix_user")]
    public TerraformList<AwsEfsAccessPointPosixUserBlock> PosixUser { get; set; } = new();

    /// <summary>
    /// Block for root_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootDirectory block(s) allowed")]
    [TerraformProperty("root_directory")]
    public TerraformList<AwsEfsAccessPointRootDirectoryBlock> RootDirectory { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformProperty("file_system_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FileSystemArn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

}
