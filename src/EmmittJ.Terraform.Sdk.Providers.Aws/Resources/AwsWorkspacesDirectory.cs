using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for active_directory_config in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryActiveDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The service_account_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountSecretArn is required")]
    public required TerraformProperty<string> ServiceAccountSecretArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_account_secret_arn");
        set => WithProperty("service_account_secret_arn", value);
    }

}

/// <summary>
/// Block type for certificate_based_auth_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateAuthorityArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_authority_arn");
        set => WithProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for saml_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectorySamlPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The relay_state_parameter_name attribute.
    /// </summary>
    public TerraformProperty<string>? RelayStateParameterName
    {
        get => GetProperty<TerraformProperty<string>>("relay_state_parameter_name");
        set => WithProperty("relay_state_parameter_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

    /// <summary>
    /// The user_access_url attribute.
    /// </summary>
    public TerraformProperty<string>? UserAccessUrl
    {
        get => GetProperty<TerraformProperty<string>>("user_access_url");
        set => WithProperty("user_access_url", value);
    }

}

/// <summary>
/// Block type for self_service_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectorySelfServicePermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The change_compute_type attribute.
    /// </summary>
    public TerraformProperty<bool>? ChangeComputeType
    {
        get => GetProperty<TerraformProperty<bool>>("change_compute_type");
        set => WithProperty("change_compute_type", value);
    }

    /// <summary>
    /// The increase_volume_size attribute.
    /// </summary>
    public TerraformProperty<bool>? IncreaseVolumeSize
    {
        get => GetProperty<TerraformProperty<bool>>("increase_volume_size");
        set => WithProperty("increase_volume_size", value);
    }

    /// <summary>
    /// The rebuild_workspace attribute.
    /// </summary>
    public TerraformProperty<bool>? RebuildWorkspace
    {
        get => GetProperty<TerraformProperty<bool>>("rebuild_workspace");
        set => WithProperty("rebuild_workspace", value);
    }

    /// <summary>
    /// The restart_workspace attribute.
    /// </summary>
    public TerraformProperty<bool>? RestartWorkspace
    {
        get => GetProperty<TerraformProperty<bool>>("restart_workspace");
        set => WithProperty("restart_workspace", value);
    }

    /// <summary>
    /// The switch_running_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? SwitchRunningMode
    {
        get => GetProperty<TerraformProperty<bool>>("switch_running_mode");
        set => WithProperty("switch_running_mode", value);
    }

}

/// <summary>
/// Block type for workspace_access_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The device_type_android attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeAndroid
    {
        get => GetProperty<TerraformProperty<string>>("device_type_android");
        set => WithProperty("device_type_android", value);
    }

    /// <summary>
    /// The device_type_chromeos attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeChromeos
    {
        get => GetProperty<TerraformProperty<string>>("device_type_chromeos");
        set => WithProperty("device_type_chromeos", value);
    }

    /// <summary>
    /// The device_type_ios attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeIos
    {
        get => GetProperty<TerraformProperty<string>>("device_type_ios");
        set => WithProperty("device_type_ios", value);
    }

    /// <summary>
    /// The device_type_linux attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeLinux
    {
        get => GetProperty<TerraformProperty<string>>("device_type_linux");
        set => WithProperty("device_type_linux", value);
    }

    /// <summary>
    /// The device_type_osx attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeOsx
    {
        get => GetProperty<TerraformProperty<string>>("device_type_osx");
        set => WithProperty("device_type_osx", value);
    }

    /// <summary>
    /// The device_type_web attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeWeb
    {
        get => GetProperty<TerraformProperty<string>>("device_type_web");
        set => WithProperty("device_type_web", value);
    }

    /// <summary>
    /// The device_type_windows attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeWindows
    {
        get => GetProperty<TerraformProperty<string>>("device_type_windows");
        set => WithProperty("device_type_windows", value);
    }

    /// <summary>
    /// The device_type_zeroclient attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeZeroclient
    {
        get => GetProperty<TerraformProperty<string>>("device_type_zeroclient");
        set => WithProperty("device_type_zeroclient", value);
    }

}

/// <summary>
/// Block type for workspace_creation_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The custom_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("custom_security_group_id");
        set => WithProperty("custom_security_group_id", value);
    }

    /// <summary>
    /// The default_ou attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultOu
    {
        get => GetProperty<TerraformProperty<string>>("default_ou");
        set => WithProperty("default_ou", value);
    }

    /// <summary>
    /// The enable_internet_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableInternetAccess
    {
        get => GetProperty<TerraformProperty<bool>>("enable_internet_access");
        set => WithProperty("enable_internet_access", value);
    }

    /// <summary>
    /// The enable_maintenance_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableMaintenanceMode
    {
        get => GetProperty<TerraformProperty<bool>>("enable_maintenance_mode");
        set => WithProperty("enable_maintenance_mode", value);
    }

    /// <summary>
    /// The user_enabled_as_local_administrator attribute.
    /// </summary>
    public TerraformProperty<bool>? UserEnabledAsLocalAdministrator
    {
        get => GetProperty<TerraformProperty<bool>>("user_enabled_as_local_administrator");
        set => WithProperty("user_enabled_as_local_administrator", value);
    }

}

/// <summary>
/// Manages a aws_workspaces_directory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWorkspacesDirectory : TerraformResource
{
    public AwsWorkspacesDirectory(string name) : base("aws_workspaces_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alias");
        this.DeclareOutput("customer_user_name");
        this.DeclareOutput("directory_name");
        this.DeclareOutput("directory_type");
        this.DeclareOutput("dns_ip_addresses");
        this.DeclareOutput("iam_role_id");
        this.DeclareOutput("registration_code");
        this.DeclareOutput("workspace_security_group_id");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
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
    /// The ip_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ip_group_ids");
        set => this.WithProperty("ip_group_ids", value);
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
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformProperty<string>? UserIdentityType
    {
        get => GetProperty<TerraformProperty<string>>("user_identity_type");
        set => this.WithProperty("user_identity_type", value);
    }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceDirectoryDescription
    {
        get => GetProperty<TerraformProperty<string>>("workspace_directory_description");
        set => this.WithProperty("workspace_directory_description", value);
    }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceDirectoryName
    {
        get => GetProperty<TerraformProperty<string>>("workspace_directory_name");
        set => this.WithProperty("workspace_directory_name", value);
    }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceType
    {
        get => GetProperty<TerraformProperty<string>>("workspace_type");
        set => this.WithProperty("workspace_type", value);
    }

    /// <summary>
    /// Block for active_directory_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfig block(s) allowed")]
    public List<AwsWorkspacesDirectoryActiveDirectoryConfigBlock>? ActiveDirectoryConfig
    {
        get => GetProperty<List<AwsWorkspacesDirectoryActiveDirectoryConfigBlock>>("active_directory_config");
        set => this.WithProperty("active_directory_config", value);
    }

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    public List<AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock>? CertificateBasedAuthProperties
    {
        get => GetProperty<List<AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock>>("certificate_based_auth_properties");
        set => this.WithProperty("certificate_based_auth_properties", value);
    }

    /// <summary>
    /// Block for saml_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlProperties block(s) allowed")]
    public List<AwsWorkspacesDirectorySamlPropertiesBlock>? SamlProperties
    {
        get => GetProperty<List<AwsWorkspacesDirectorySamlPropertiesBlock>>("saml_properties");
        set => this.WithProperty("saml_properties", value);
    }

    /// <summary>
    /// Block for self_service_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfServicePermissions block(s) allowed")]
    public List<AwsWorkspacesDirectorySelfServicePermissionsBlock>? SelfServicePermissions
    {
        get => GetProperty<List<AwsWorkspacesDirectorySelfServicePermissionsBlock>>("self_service_permissions");
        set => this.WithProperty("self_service_permissions", value);
    }

    /// <summary>
    /// Block for workspace_access_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceAccessProperties block(s) allowed")]
    public List<AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock>? WorkspaceAccessProperties
    {
        get => GetProperty<List<AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock>>("workspace_access_properties");
        set => this.WithProperty("workspace_access_properties", value);
    }

    /// <summary>
    /// Block for workspace_creation_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceCreationProperties block(s) allowed")]
    public List<AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock>? WorkspaceCreationProperties
    {
        get => GetProperty<List<AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock>>("workspace_creation_properties");
        set => this.WithProperty("workspace_creation_properties", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    public TerraformExpression CustomerUserName => this["customer_user_name"];

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformExpression DirectoryName => this["directory_name"];

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    public TerraformExpression DirectoryType => this["directory_type"];

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformExpression DnsIpAddresses => this["dns_ip_addresses"];

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    public TerraformExpression IamRoleId => this["iam_role_id"];

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    public TerraformExpression RegistrationCode => this["registration_code"];

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceSecurityGroupId => this["workspace_security_group_id"];

}
