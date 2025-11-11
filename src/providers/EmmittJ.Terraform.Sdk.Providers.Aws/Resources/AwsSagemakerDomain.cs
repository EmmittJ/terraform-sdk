using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_space_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlock
{
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

}

/// <summary>
/// Block type for default_user_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlock
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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DefaultLandingUri { get; set; } = default!;

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
/// Block type for domain_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDomainSettingsBlock
{
    /// <summary>
    /// The execution_role_identity_config attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_identity_config")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionRoleIdentityConfig { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainRetentionPolicyBlock
{
    /// <summary>
    /// The home_efs_file_system attribute.
    /// </summary>
    [TerraformPropertyName("home_efs_file_system")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HomeEfsFileSystem { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerDomain : TerraformResource
{
    public AwsSagemakerDomain(string name) : base("aws_sagemaker_domain", name)
    {
    }

    /// <summary>
    /// The app_network_access_type attribute.
    /// </summary>
    [TerraformPropertyName("app_network_access_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AppNetworkAccessType { get; set; }

    /// <summary>
    /// The app_security_group_management attribute.
    /// </summary>
    [TerraformPropertyName("app_security_group_management")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AppSecurityGroupManagement { get; set; }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    [TerraformPropertyName("auth_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthMode { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tag_propagation attribute.
    /// </summary>
    [TerraformPropertyName("tag_propagation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TagPropagation { get; set; }

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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for default_space_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSpaceSettings block(s) allowed")]
    [TerraformPropertyName("default_space_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainDefaultSpaceSettingsBlock>>? DefaultSpaceSettings { get; set; }

    /// <summary>
    /// Block for default_user_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultUserSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultUserSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUserSettings block(s) allowed")]
    [TerraformPropertyName("default_user_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainDefaultUserSettingsBlock>>? DefaultUserSettings { get; set; }

    /// <summary>
    /// Block for domain_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainSettings block(s) allowed")]
    [TerraformPropertyName("domain_settings")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainDomainSettingsBlock>>? DomainSettings { get; set; }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [TerraformPropertyName("retention_policy")]
    public TerraformList<TerraformBlock<AwsSagemakerDomainRetentionPolicyBlock>>? RetentionPolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The home_efs_file_system_id attribute.
    /// </summary>
    [TerraformPropertyName("home_efs_file_system_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HomeEfsFileSystemId => new TerraformReference(this, "home_efs_file_system_id");

    /// <summary>
    /// The security_group_id_for_domain_boundary attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id_for_domain_boundary")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityGroupIdForDomainBoundary => new TerraformReference(this, "security_group_id_for_domain_boundary");

    /// <summary>
    /// The single_sign_on_application_arn attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_application_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SingleSignOnApplicationArn => new TerraformReference(this, "single_sign_on_application_arn");

    /// <summary>
    /// The single_sign_on_managed_application_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_managed_application_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SingleSignOnManagedApplicationInstanceId => new TerraformReference(this, "single_sign_on_managed_application_instance_id");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
