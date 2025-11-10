using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_space_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformProperty<string> ExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("execution_role");
        set => WithProperty("execution_role", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => WithProperty("security_groups", value);
    }

}

/// <summary>
/// Block type for default_user_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The auto_mount_home_efs attribute.
    /// </summary>
    public TerraformProperty<string>? AutoMountHomeEfs
    {
        get => GetProperty<TerraformProperty<string>>("auto_mount_home_efs");
        set => WithProperty("auto_mount_home_efs", value);
    }

    /// <summary>
    /// The default_landing_uri attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultLandingUri
    {
        get => GetProperty<TerraformProperty<string>>("default_landing_uri");
        set => WithProperty("default_landing_uri", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformProperty<string> ExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("execution_role");
        set => WithProperty("execution_role", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => WithProperty("security_groups", value);
    }

    /// <summary>
    /// The studio_web_portal attribute.
    /// </summary>
    public TerraformProperty<string>? StudioWebPortal
    {
        get => GetProperty<TerraformProperty<string>>("studio_web_portal");
        set => WithProperty("studio_web_portal", value);
    }

}

/// <summary>
/// Block type for domain_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDomainSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The execution_role_identity_config attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleIdentityConfig
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_identity_config");
        set => WithProperty("execution_role_identity_config", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The home_efs_file_system attribute.
    /// </summary>
    public TerraformProperty<string>? HomeEfsFileSystem
    {
        get => GetProperty<TerraformProperty<string>>("home_efs_file_system");
        set => WithProperty("home_efs_file_system", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerDomain : TerraformResource
{
    public AwsSagemakerDomain(string name) : base("aws_sagemaker_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("home_efs_file_system_id");
        this.DeclareOutput("security_group_id_for_domain_boundary");
        this.DeclareOutput("single_sign_on_application_arn");
        this.DeclareOutput("single_sign_on_managed_application_instance_id");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The app_network_access_type attribute.
    /// </summary>
    public TerraformProperty<string>? AppNetworkAccessType
    {
        get => GetProperty<TerraformProperty<string>>("app_network_access_type");
        set => this.WithProperty("app_network_access_type", value);
    }

    /// <summary>
    /// The app_security_group_management attribute.
    /// </summary>
    public TerraformProperty<string>? AppSecurityGroupManagement
    {
        get => GetProperty<TerraformProperty<string>>("app_security_group_management");
        set => this.WithProperty("app_security_group_management", value);
    }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    public required TerraformProperty<string> AuthMode
    {
        get => GetProperty<TerraformProperty<string>>("auth_mode");
        set => this.WithProperty("auth_mode", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tag_propagation attribute.
    /// </summary>
    public TerraformProperty<string>? TagPropagation
    {
        get => GetProperty<TerraformProperty<string>>("tag_propagation");
        set => this.WithProperty("tag_propagation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for default_space_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSpaceSettings block(s) allowed")]
    public List<AwsSagemakerDomainDefaultSpaceSettingsBlock>? DefaultSpaceSettings
    {
        get => GetProperty<List<AwsSagemakerDomainDefaultSpaceSettingsBlock>>("default_space_settings");
        set => this.WithProperty("default_space_settings", value);
    }

    /// <summary>
    /// Block for default_user_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultUserSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUserSettings block(s) allowed")]
    public List<AwsSagemakerDomainDefaultUserSettingsBlock>? DefaultUserSettings
    {
        get => GetProperty<List<AwsSagemakerDomainDefaultUserSettingsBlock>>("default_user_settings");
        set => this.WithProperty("default_user_settings", value);
    }

    /// <summary>
    /// Block for domain_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainSettings block(s) allowed")]
    public List<AwsSagemakerDomainDomainSettingsBlock>? DomainSettings
    {
        get => GetProperty<List<AwsSagemakerDomainDomainSettingsBlock>>("domain_settings");
        set => this.WithProperty("domain_settings", value);
    }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public List<AwsSagemakerDomainRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetProperty<List<AwsSagemakerDomainRetentionPolicyBlock>>("retention_policy");
        set => this.WithProperty("retention_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The home_efs_file_system_id attribute.
    /// </summary>
    public TerraformExpression HomeEfsFileSystemId => this["home_efs_file_system_id"];

    /// <summary>
    /// The security_group_id_for_domain_boundary attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIdForDomainBoundary => this["security_group_id_for_domain_boundary"];

    /// <summary>
    /// The single_sign_on_application_arn attribute.
    /// </summary>
    public TerraformExpression SingleSignOnApplicationArn => this["single_sign_on_application_arn"];

    /// <summary>
    /// The single_sign_on_managed_application_instance_id attribute.
    /// </summary>
    public TerraformExpression SingleSignOnManagedApplicationInstanceId => this["single_sign_on_managed_application_instance_id"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
