using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public partial class AwsDirectoryServiceSharedDirectoryTargetBlock() : TerraformBlock("target")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDirectoryServiceSharedDirectoryTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_directory_service_shared_directory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDirectoryServiceSharedDirectory : TerraformResource
{
    public AwsDirectoryServiceSharedDirectory(string name) : base("aws_directory_service_shared_directory", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformProperty("directory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [TerraformProperty("method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Method { get; set; }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    [TerraformProperty("notes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformProperty("target")]
    public required TerraformList<AwsDirectoryServiceSharedDirectoryTargetBlock> Target { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDirectoryServiceSharedDirectoryTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The shared_directory_id attribute.
    /// </summary>
    [TerraformProperty("shared_directory_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SharedDirectoryId { get; }

}
