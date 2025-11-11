using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerUserProfileUserSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_mount_home_efs attribute.
    /// </summary>
    [TerraformProperty("auto_mount_home_efs")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AutoMountHomeEfs { get; set; }

    /// <summary>
    /// The default_landing_uri attribute.
    /// </summary>
    [TerraformProperty("default_landing_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultLandingUri { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    [TerraformProperty("execution_role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExecutionRole { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The studio_web_portal attribute.
    /// </summary>
    [TerraformProperty("studio_web_portal")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StudioWebPortal { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_user_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerUserProfile : TerraformResource
{
    public AwsSagemakerUserProfile(string name) : base("aws_sagemaker_user_profile", name)
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
    /// The single_sign_on_user_identifier attribute.
    /// </summary>
    [TerraformProperty("single_sign_on_user_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SingleSignOnUserIdentifier { get; set; }

    /// <summary>
    /// The single_sign_on_user_value attribute.
    /// </summary>
    [TerraformProperty("single_sign_on_user_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SingleSignOnUserValue { get; set; }

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
    /// The user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserProfileName is required")]
    [TerraformProperty("user_profile_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserProfileName { get; set; }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserSettings block(s) allowed")]
    [TerraformProperty("user_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerUserProfileUserSettingsBlock>>? UserSettings { get; set; }

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

}
