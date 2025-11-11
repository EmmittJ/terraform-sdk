using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlock
{
    /// <summary>
    /// The auto_mount_home_efs attribute.
    /// </summary>
    [TerraformPropertyName("auto_mount_home_efs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AutoMountHomeEfs { get; set; } = default!;

    /// <summary>
    /// The default_landing_uri attribute.
    /// </summary>
    [TerraformPropertyName("default_landing_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultLandingUri { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    [TerraformPropertyName("execution_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExecutionRole { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The studio_web_portal attribute.
    /// </summary>
    [TerraformPropertyName("studio_web_portal")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StudioWebPortal { get; set; } = default!;

}

/// <summary>
/// Manages a aws_sagemaker_user_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerUserProfile : TerraformResource
{
    public AwsSagemakerUserProfile(string name) : base("aws_sagemaker_user_profile", name)
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
    /// The single_sign_on_user_identifier attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_user_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SingleSignOnUserIdentifier { get; set; }

    /// <summary>
    /// The single_sign_on_user_value attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_user_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SingleSignOnUserValue { get; set; }

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
    /// The user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserProfileName is required")]
    [TerraformPropertyName("user_profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserProfileName { get; set; }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserSettings block(s) allowed")]
    [TerraformPropertyName("user_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerUserProfileUserSettingsBlock>>? UserSettings { get; set; }

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

}
