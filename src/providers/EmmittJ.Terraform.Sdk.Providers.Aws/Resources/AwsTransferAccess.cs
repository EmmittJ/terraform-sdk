using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for home_directory_mappings in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferAccessHomeDirectoryMappingsBlock() : TerraformBlock("home_directory_mappings")
{
    /// <summary>
    /// The entry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entry is required")]
    [TerraformProperty("entry")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Entry { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformProperty("target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Target { get; set; }

}

/// <summary>
/// Block type for posix_profile in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferAccessPosixProfileBlock() : TerraformBlock("posix_profile")
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
/// Manages a aws_transfer_access resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsTransferAccess : TerraformResource
{
    public AwsTransferAccess(string name) : base("aws_transfer_access", name)
    {
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    [TerraformProperty("external_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExternalId { get; set; }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    [TerraformProperty("home_directory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HomeDirectory { get; set; }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    [TerraformProperty("home_directory_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HomeDirectoryType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [TerraformProperty("role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Role { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// Block for home_directory_mappings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 HomeDirectoryMappings block(s) allowed")]
    [TerraformProperty("home_directory_mappings")]
    public TerraformList<AwsTransferAccessHomeDirectoryMappingsBlock> HomeDirectoryMappings { get; set; } = new();

    /// <summary>
    /// Block for posix_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixProfile block(s) allowed")]
    [TerraformProperty("posix_profile")]
    public TerraformList<AwsTransferAccessPosixProfileBlock> PosixProfile { get; set; } = new();

}
