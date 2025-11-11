using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_space_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDomainDefaultSpaceSettingsBlock : TerraformBlockBase
{
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

}

/// <summary>
/// Block type for default_user_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDomainDefaultUserSettingsBlock : TerraformBlockBase
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
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DefaultLandingUri { get; set; }

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
/// Block type for domain_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDomainDomainSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The execution_role_identity_config attribute.
    /// </summary>
    [TerraformProperty("execution_role_identity_config")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SecurityGroupIds { get; set; }

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerDomainRetentionPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The home_efs_file_system attribute.
    /// </summary>
    [TerraformProperty("home_efs_file_system")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HomeEfsFileSystem { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerDomain : TerraformResource
{
    public AwsSagemakerDomain(string name) : base("aws_sagemaker_domain", name)
    {
    }

    /// <summary>
    /// The app_network_access_type attribute.
    /// </summary>
    [TerraformProperty("app_network_access_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppNetworkAccessType { get; set; }

    /// <summary>
    /// The app_security_group_management attribute.
    /// </summary>
    [TerraformProperty("app_security_group_management")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppSecurityGroupManagement { get; set; }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    [TerraformProperty("auth_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthMode { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tag_propagation attribute.
    /// </summary>
    [TerraformProperty("tag_propagation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TagPropagation { get; set; }

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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for default_space_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSpaceSettings block(s) allowed")]
    [TerraformProperty("default_space_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainDefaultSpaceSettingsBlock>>? DefaultSpaceSettings { get; set; }

    /// <summary>
    /// Block for default_user_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultUserSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultUserSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUserSettings block(s) allowed")]
    [TerraformProperty("default_user_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainDefaultUserSettingsBlock>>? DefaultUserSettings { get; set; }

    /// <summary>
    /// Block for domain_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainSettings block(s) allowed")]
    [TerraformProperty("domain_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainDomainSettingsBlock>>? DomainSettings { get; set; }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [TerraformProperty("retention_policy")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainRetentionPolicyBlock>>? RetentionPolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The home_efs_file_system_id attribute.
    /// </summary>
    [TerraformProperty("home_efs_file_system_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HomeEfsFileSystemId { get; }

    /// <summary>
    /// The security_group_id_for_domain_boundary attribute.
    /// </summary>
    [TerraformProperty("security_group_id_for_domain_boundary")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecurityGroupIdForDomainBoundary { get; }

    /// <summary>
    /// The single_sign_on_application_arn attribute.
    /// </summary>
    [TerraformProperty("single_sign_on_application_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SingleSignOnApplicationArn { get; }

    /// <summary>
    /// The single_sign_on_managed_application_instance_id attribute.
    /// </summary>
    [TerraformProperty("single_sign_on_managed_application_instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SingleSignOnManagedApplicationInstanceId { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
