using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for posix_user in .
/// Nesting mode: list
/// </summary>
public class AwsEfsAccessPointPosixUserBlock : ITerraformBlock
{
    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    [TerraformPropertyName("gid")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Gid { get; set; }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    [TerraformPropertyName("secondary_gids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? SecondaryGids { get; set; }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    [TerraformPropertyName("uid")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Uid { get; set; }

}

/// <summary>
/// Block type for root_directory in .
/// Nesting mode: list
/// </summary>
public class AwsEfsAccessPointRootDirectoryBlock : ITerraformBlock
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Path { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "path");

}

/// <summary>
/// Manages a aws_efs_access_point resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEfsAccessPoint : TerraformResource
{
    public AwsEfsAccessPoint(string name) : base("aws_efs_access_point", name)
    {
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    [TerraformPropertyName("file_system_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FileSystemId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for posix_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixUser block(s) allowed")]
    [TerraformPropertyName("posix_user")]
    public TerraformList<TerraformBlock<AwsEfsAccessPointPosixUserBlock>>? PosixUser { get; set; } = new();

    /// <summary>
    /// Block for root_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootDirectory block(s) allowed")]
    [TerraformPropertyName("root_directory")]
    public TerraformList<TerraformBlock<AwsEfsAccessPointRootDirectoryBlock>>? RootDirectory { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    [TerraformPropertyName("file_system_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileSystemArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

}
