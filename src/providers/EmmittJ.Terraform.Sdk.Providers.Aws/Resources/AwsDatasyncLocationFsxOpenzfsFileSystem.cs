using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protocol in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlock() : TerraformBlock("protocol")
{
}

/// <summary>
/// Manages a aws_datasync_location_fsx_openzfs_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDatasyncLocationFsxOpenzfsFileSystem : TerraformResource
{
    public AwsDatasyncLocationFsxOpenzfsFileSystem(string name) : base("aws_datasync_location_fsx_openzfs_file_system", name)
    {
    }

    /// <summary>
    /// The fsx_filesystem_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FsxFilesystemArn is required")]
    [TerraformProperty("fsx_filesystem_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FsxFilesystemArn { get; set; }

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
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    [TerraformProperty("security_group_arns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SecurityGroupArns { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformProperty("subdirectory")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Subdirectory { get; set; }

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
    /// Block for protocol.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Protocol block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocol block(s) allowed")]
    [TerraformProperty("protocol")]
    public required TerraformList<AwsDatasyncLocationFsxOpenzfsFileSystemProtocolBlock> Protocol { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uri { get; }

}
