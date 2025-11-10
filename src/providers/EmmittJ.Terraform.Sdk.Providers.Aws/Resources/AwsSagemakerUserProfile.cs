using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_mount_home_efs attribute.
    /// </summary>
    [TerraformPropertyName("auto_mount_home_efs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AutoMountHomeEfs { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "auto_mount_home_efs");

    /// <summary>
    /// The default_landing_uri attribute.
    /// </summary>
    [TerraformPropertyName("default_landing_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultLandingUri { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    [TerraformPropertyName("execution_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExecutionRole { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroups { get; set; }

    /// <summary>
    /// The studio_web_portal attribute.
    /// </summary>
    [TerraformPropertyName("studio_web_portal")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StudioWebPortal { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "studio_web_portal");

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
    /// The single_sign_on_user_identifier attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_user_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SingleSignOnUserIdentifier { get; set; }

    /// <summary>
    /// The single_sign_on_user_value attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_user_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SingleSignOnUserValue { get; set; }

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
    /// The user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserProfileName is required")]
    [TerraformPropertyName("user_profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserProfileName { get; set; }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserSettings block(s) allowed")]
    [TerraformPropertyName("user_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerUserProfileUserSettingsBlock>>? UserSettings { get; set; } = new();

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

}
