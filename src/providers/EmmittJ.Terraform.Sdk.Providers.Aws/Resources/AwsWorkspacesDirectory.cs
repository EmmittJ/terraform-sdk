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
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The service_account_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountSecretArn is required")]
    public required TerraformProperty<string> ServiceAccountSecretArn
    {
        set => SetProperty("service_account_secret_arn", value);
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
        set => SetProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
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
        set => SetProperty("relay_state_parameter_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The user_access_url attribute.
    /// </summary>
    public TerraformProperty<string>? UserAccessUrl
    {
        set => SetProperty("user_access_url", value);
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
        set => SetProperty("change_compute_type", value);
    }

    /// <summary>
    /// The increase_volume_size attribute.
    /// </summary>
    public TerraformProperty<bool>? IncreaseVolumeSize
    {
        set => SetProperty("increase_volume_size", value);
    }

    /// <summary>
    /// The rebuild_workspace attribute.
    /// </summary>
    public TerraformProperty<bool>? RebuildWorkspace
    {
        set => SetProperty("rebuild_workspace", value);
    }

    /// <summary>
    /// The restart_workspace attribute.
    /// </summary>
    public TerraformProperty<bool>? RestartWorkspace
    {
        set => SetProperty("restart_workspace", value);
    }

    /// <summary>
    /// The switch_running_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? SwitchRunningMode
    {
        set => SetProperty("switch_running_mode", value);
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
        set => SetProperty("device_type_android", value);
    }

    /// <summary>
    /// The device_type_chromeos attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeChromeos
    {
        set => SetProperty("device_type_chromeos", value);
    }

    /// <summary>
    /// The device_type_ios attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeIos
    {
        set => SetProperty("device_type_ios", value);
    }

    /// <summary>
    /// The device_type_linux attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeLinux
    {
        set => SetProperty("device_type_linux", value);
    }

    /// <summary>
    /// The device_type_osx attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeOsx
    {
        set => SetProperty("device_type_osx", value);
    }

    /// <summary>
    /// The device_type_web attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeWeb
    {
        set => SetProperty("device_type_web", value);
    }

    /// <summary>
    /// The device_type_windows attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeWindows
    {
        set => SetProperty("device_type_windows", value);
    }

    /// <summary>
    /// The device_type_zeroclient attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTypeZeroclient
    {
        set => SetProperty("device_type_zeroclient", value);
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
        set => SetProperty("custom_security_group_id", value);
    }

    /// <summary>
    /// The default_ou attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultOu
    {
        set => SetProperty("default_ou", value);
    }

    /// <summary>
    /// The enable_internet_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableInternetAccess
    {
        set => SetProperty("enable_internet_access", value);
    }

    /// <summary>
    /// The enable_maintenance_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableMaintenanceMode
    {
        set => SetProperty("enable_maintenance_mode", value);
    }

    /// <summary>
    /// The user_enabled_as_local_administrator attribute.
    /// </summary>
    public TerraformProperty<bool>? UserEnabledAsLocalAdministrator
    {
        set => SetProperty("user_enabled_as_local_administrator", value);
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
        SetOutput("alias");
        SetOutput("customer_user_name");
        SetOutput("directory_name");
        SetOutput("directory_type");
        SetOutput("dns_ip_addresses");
        SetOutput("iam_role_id");
        SetOutput("registration_code");
        SetOutput("workspace_security_group_id");
        SetOutput("directory_id");
        SetOutput("id");
        SetOutput("ip_group_ids");
        SetOutput("region");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_identity_type");
        SetOutput("workspace_directory_description");
        SetOutput("workspace_directory_name");
        SetOutput("workspace_type");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string> DirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_id");
        set => SetProperty("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IpGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ip_group_ids");
        set => SetProperty("ip_group_ids", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformProperty<string> UserIdentityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_identity_type");
        set => SetProperty("user_identity_type", value);
    }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformProperty<string> WorkspaceDirectoryDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_directory_description");
        set => SetProperty("workspace_directory_description", value);
    }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformProperty<string> WorkspaceDirectoryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_directory_name");
        set => SetProperty("workspace_directory_name", value);
    }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformProperty<string> WorkspaceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_type");
        set => SetProperty("workspace_type", value);
    }

    /// <summary>
    /// Block for active_directory_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfig block(s) allowed")]
    public List<AwsWorkspacesDirectoryActiveDirectoryConfigBlock>? ActiveDirectoryConfig
    {
        set => SetProperty("active_directory_config", value);
    }

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    public List<AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock>? CertificateBasedAuthProperties
    {
        set => SetProperty("certificate_based_auth_properties", value);
    }

    /// <summary>
    /// Block for saml_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlProperties block(s) allowed")]
    public List<AwsWorkspacesDirectorySamlPropertiesBlock>? SamlProperties
    {
        set => SetProperty("saml_properties", value);
    }

    /// <summary>
    /// Block for self_service_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfServicePermissions block(s) allowed")]
    public List<AwsWorkspacesDirectorySelfServicePermissionsBlock>? SelfServicePermissions
    {
        set => SetProperty("self_service_permissions", value);
    }

    /// <summary>
    /// Block for workspace_access_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceAccessProperties block(s) allowed")]
    public List<AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock>? WorkspaceAccessProperties
    {
        set => SetProperty("workspace_access_properties", value);
    }

    /// <summary>
    /// Block for workspace_creation_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceCreationProperties block(s) allowed")]
    public List<AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock>? WorkspaceCreationProperties
    {
        set => SetProperty("workspace_creation_properties", value);
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
