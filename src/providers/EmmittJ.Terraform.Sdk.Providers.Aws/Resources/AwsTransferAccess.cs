using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for home_directory_mappings in .
/// Nesting mode: list
/// </summary>
public class AwsTransferAccessHomeDirectoryMappingsBlock
{
    /// <summary>
    /// The entry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entry is required")]
    [TerraformPropertyName("entry")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Entry { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformPropertyName("target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Target { get; set; }

}

/// <summary>
/// Block type for posix_profile in .
/// Nesting mode: list
/// </summary>
public class AwsTransferAccessPosixProfileBlock
{
    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    [TerraformPropertyName("gid")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Gid { get; set; }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    [TerraformPropertyName("secondary_gids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<double>? SecondaryGids { get; set; }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    [TerraformPropertyName("uid")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Uid { get; set; }

}

/// <summary>
/// Manages a aws_transfer_access resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTransferAccess : TerraformResource
{
    public AwsTransferAccess(string name) : base("aws_transfer_access", name)
    {
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    [TerraformPropertyName("external_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExternalId { get; set; }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    [TerraformPropertyName("home_directory")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HomeDirectory { get; set; }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    [TerraformPropertyName("home_directory_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HomeDirectoryType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role attribute.
    /// </summary>
    [TerraformPropertyName("role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Role { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// Block for home_directory_mappings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 HomeDirectoryMappings block(s) allowed")]
    [TerraformPropertyName("home_directory_mappings")]
    public TerraformList<TerraformBlock<AwsTransferAccessHomeDirectoryMappingsBlock>>? HomeDirectoryMappings { get; set; }

    /// <summary>
    /// Block for posix_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixProfile block(s) allowed")]
    [TerraformPropertyName("posix_profile")]
    public TerraformList<TerraformBlock<AwsTransferAccessPosixProfileBlock>>? PosixProfile { get; set; }

}
