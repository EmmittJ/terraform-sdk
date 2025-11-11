using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ownership_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceOwnershipSettingsBlock
{
    /// <summary>
    /// The owner_user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerUserProfileName is required")]
    [TerraformPropertyName("owner_user_profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OwnerUserProfileName { get; set; }

}

/// <summary>
/// Block type for space_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlock
{
    /// <summary>
    /// The app_type attribute.
    /// </summary>
    [TerraformPropertyName("app_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AppType { get; set; }

}

/// <summary>
/// Block type for space_sharing_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSharingSettingsBlock
{
    /// <summary>
    /// The sharing_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharingType is required")]
    [TerraformPropertyName("sharing_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SharingType { get; set; }

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
    public required TerraformValue<string> DomainId { get; set; }

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
    /// The space_display_name attribute.
    /// </summary>
    [TerraformPropertyName("space_display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SpaceDisplayName { get; set; }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    [TerraformPropertyName("space_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SpaceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for ownership_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OwnershipSettings block(s) allowed")]
    [TerraformPropertyName("ownership_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceOwnershipSettingsBlock>>? OwnershipSettings { get; set; }

    /// <summary>
    /// Block for space_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSettings block(s) allowed")]
    [TerraformPropertyName("space_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceSpaceSettingsBlock>>? SpaceSettings { get; set; }

    /// <summary>
    /// Block for space_sharing_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSharingSettings block(s) allowed")]
    [TerraformPropertyName("space_sharing_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceSpaceSharingSettingsBlock>>? SpaceSharingSettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The home_efs_file_system_uid attribute.
    /// </summary>
    [TerraformPropertyName("home_efs_file_system_uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HomeEfsFileSystemUid => new TerraformReference(this, "home_efs_file_system_uid");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
