using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ownership_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerSpaceOwnershipSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The owner_user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerUserProfileName is required")]
    [TerraformProperty("owner_user_profile_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OwnerUserProfileName { get; set; }

}

/// <summary>
/// Block type for space_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerSpaceSpaceSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The app_type attribute.
    /// </summary>
    [TerraformProperty("app_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppType { get; set; }

}

/// <summary>
/// Block type for space_sharing_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerSpaceSpaceSharingSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The sharing_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharingType is required")]
    [TerraformProperty("sharing_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SharingType { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_space resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerSpace : TerraformResource
{
    public AwsSagemakerSpace(string name) : base("aws_sagemaker_space", name)
    {
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformProperty("domain_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainId { get; set; }

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
    /// The space_display_name attribute.
    /// </summary>
    [TerraformProperty("space_display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SpaceDisplayName { get; set; }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    [TerraformProperty("space_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SpaceName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for ownership_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OwnershipSettings block(s) allowed")]
    [TerraformProperty("ownership_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceOwnershipSettingsBlock>>? OwnershipSettings { get; set; }

    /// <summary>
    /// Block for space_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSettings block(s) allowed")]
    [TerraformProperty("space_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceSpaceSettingsBlock>>? SpaceSettings { get; set; }

    /// <summary>
    /// Block for space_sharing_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSharingSettings block(s) allowed")]
    [TerraformProperty("space_sharing_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerSpaceSpaceSharingSettingsBlock>>? SpaceSharingSettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The home_efs_file_system_uid attribute.
    /// </summary>
    [TerraformProperty("home_efs_file_system_uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HomeEfsFileSystemUid { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
