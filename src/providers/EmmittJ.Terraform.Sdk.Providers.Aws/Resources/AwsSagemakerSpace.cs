using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ownership_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceOwnershipSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The owner_user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerUserProfileName is required")]
    [TerraformPropertyName("owner_user_profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OwnerUserProfileName { get; set; }

}

/// <summary>
/// Block type for space_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The app_type attribute.
    /// </summary>
    [TerraformPropertyName("app_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppType { get; set; }

}

/// <summary>
/// Block type for space_sharing_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSharingSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The sharing_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharingType is required")]
    [TerraformPropertyName("sharing_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SharingType { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_space resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerSpace : TerraformResource
{
    public AwsSagemakerSpace(string name) : base("aws_sagemaker_space", name)
    {
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformPropertyName("domain_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainId { get; set; }

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
    /// The space_display_name attribute.
    /// </summary>
    [TerraformPropertyName("space_display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpaceDisplayName { get; set; }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    [TerraformPropertyName("space_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SpaceName { get; set; }

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
    /// Block for ownership_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OwnershipSettings block(s) allowed")]
    [TerraformPropertyName("ownership_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceOwnershipSettingsBlock>>? OwnershipSettings { get; set; } = new();

    /// <summary>
    /// Block for space_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSettings block(s) allowed")]
    [TerraformPropertyName("space_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceSpaceSettingsBlock>>? SpaceSettings { get; set; } = new();

    /// <summary>
    /// Block for space_sharing_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSharingSettings block(s) allowed")]
    [TerraformPropertyName("space_sharing_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceSpaceSharingSettingsBlock>>? SpaceSharingSettings { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The home_efs_file_system_uid attribute.
    /// </summary>
    [TerraformPropertyName("home_efs_file_system_uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HomeEfsFileSystemUid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "home_efs_file_system_uid");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
