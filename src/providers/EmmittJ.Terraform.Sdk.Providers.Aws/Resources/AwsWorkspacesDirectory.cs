using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for active_directory_config in AwsWorkspacesDirectory.
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryActiveDirectoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory_config";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The service_account_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountSecretArn is required")]
    public required TerraformValue<string> ServiceAccountSecretArn
    {
        get => GetArgument<TerraformValue<string>>("service_account_secret_arn");
        set => SetArgument("service_account_secret_arn", value);
    }

}


/// <summary>
/// Block type for certificate_based_auth_properties in AwsWorkspacesDirectory.
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_based_auth_properties";

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateAuthorityArn
    {
        get => GetArgument<TerraformValue<string>>("certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Block type for saml_properties in AwsWorkspacesDirectory.
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectorySamlPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml_properties";

    /// <summary>
    /// The relay_state_parameter_name attribute.
    /// </summary>
    public TerraformValue<string>? RelayStateParameterName
    {
        get => GetArgument<TerraformValue<string>>("relay_state_parameter_name");
        set => SetArgument("relay_state_parameter_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The user_access_url attribute.
    /// </summary>
    public TerraformValue<string>? UserAccessUrl
    {
        get => GetArgument<TerraformValue<string>>("user_access_url");
        set => SetArgument("user_access_url", value);
    }

}


/// <summary>
/// Block type for self_service_permissions in AwsWorkspacesDirectory.
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectorySelfServicePermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "self_service_permissions";

    /// <summary>
    /// The change_compute_type attribute.
    /// </summary>
    public TerraformValue<bool>? ChangeComputeType
    {
        get => GetArgument<TerraformValue<bool>>("change_compute_type");
        set => SetArgument("change_compute_type", value);
    }

    /// <summary>
    /// The increase_volume_size attribute.
    /// </summary>
    public TerraformValue<bool>? IncreaseVolumeSize
    {
        get => GetArgument<TerraformValue<bool>>("increase_volume_size");
        set => SetArgument("increase_volume_size", value);
    }

    /// <summary>
    /// The rebuild_workspace attribute.
    /// </summary>
    public TerraformValue<bool>? RebuildWorkspace
    {
        get => GetArgument<TerraformValue<bool>>("rebuild_workspace");
        set => SetArgument("rebuild_workspace", value);
    }

    /// <summary>
    /// The restart_workspace attribute.
    /// </summary>
    public TerraformValue<bool>? RestartWorkspace
    {
        get => GetArgument<TerraformValue<bool>>("restart_workspace");
        set => SetArgument("restart_workspace", value);
    }

    /// <summary>
    /// The switch_running_mode attribute.
    /// </summary>
    public TerraformValue<bool>? SwitchRunningMode
    {
        get => GetArgument<TerraformValue<bool>>("switch_running_mode");
        set => SetArgument("switch_running_mode", value);
    }

}


/// <summary>
/// Block type for workspace_access_properties in AwsWorkspacesDirectory.
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workspace_access_properties";

    /// <summary>
    /// The device_type_android attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeAndroid
    {
        get => GetArgument<TerraformValue<string>>("device_type_android");
        set => SetArgument("device_type_android", value);
    }

    /// <summary>
    /// The device_type_chromeos attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeChromeos
    {
        get => GetArgument<TerraformValue<string>>("device_type_chromeos");
        set => SetArgument("device_type_chromeos", value);
    }

    /// <summary>
    /// The device_type_ios attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeIos
    {
        get => GetArgument<TerraformValue<string>>("device_type_ios");
        set => SetArgument("device_type_ios", value);
    }

    /// <summary>
    /// The device_type_linux attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeLinux
    {
        get => GetArgument<TerraformValue<string>>("device_type_linux");
        set => SetArgument("device_type_linux", value);
    }

    /// <summary>
    /// The device_type_osx attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeOsx
    {
        get => GetArgument<TerraformValue<string>>("device_type_osx");
        set => SetArgument("device_type_osx", value);
    }

    /// <summary>
    /// The device_type_web attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeWeb
    {
        get => GetArgument<TerraformValue<string>>("device_type_web");
        set => SetArgument("device_type_web", value);
    }

    /// <summary>
    /// The device_type_windows attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeWindows
    {
        get => GetArgument<TerraformValue<string>>("device_type_windows");
        set => SetArgument("device_type_windows", value);
    }

    /// <summary>
    /// The device_type_zeroclient attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeZeroclient
    {
        get => GetArgument<TerraformValue<string>>("device_type_zeroclient");
        set => SetArgument("device_type_zeroclient", value);
    }

}


/// <summary>
/// Block type for workspace_creation_properties in AwsWorkspacesDirectory.
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workspace_creation_properties";

    /// <summary>
    /// The custom_security_group_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomSecurityGroupId
    {
        get => GetArgument<TerraformValue<string>>("custom_security_group_id");
        set => SetArgument("custom_security_group_id", value);
    }

    /// <summary>
    /// The default_ou attribute.
    /// </summary>
    public TerraformValue<string>? DefaultOu
    {
        get => GetArgument<TerraformValue<string>>("default_ou");
        set => SetArgument("default_ou", value);
    }

    /// <summary>
    /// The enable_internet_access attribute.
    /// </summary>
    public TerraformValue<bool>? EnableInternetAccess
    {
        get => GetArgument<TerraformValue<bool>>("enable_internet_access");
        set => SetArgument("enable_internet_access", value);
    }

    /// <summary>
    /// The enable_maintenance_mode attribute.
    /// </summary>
    public TerraformValue<bool>? EnableMaintenanceMode
    {
        get => GetArgument<TerraformValue<bool>>("enable_maintenance_mode");
        set => SetArgument("enable_maintenance_mode", value);
    }

    /// <summary>
    /// The user_enabled_as_local_administrator attribute.
    /// </summary>
    public TerraformValue<bool>? UserEnabledAsLocalAdministrator
    {
        get => GetArgument<TerraformValue<bool>>("user_enabled_as_local_administrator");
        set => SetArgument("user_enabled_as_local_administrator", value);
    }

}


/// <summary>
/// Represents a aws_workspaces_directory Terraform resource.
/// Manages a aws_workspaces_directory resource.
/// </summary>
public partial class AwsWorkspacesDirectory(string name) : TerraformResource("aws_workspaces_directory", name)
{
    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryId
    {
        get => GetArgument<TerraformValue<string>>("directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? IpGroupIds
    {
        get => GetArgument<TerraformSet<string>>("ip_group_ids");
        set => SetArgument("ip_group_ids", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformValue<string>? UserIdentityType
    {
        get => GetArgument<TerraformValue<string>>("user_identity_type");
        set => SetArgument("user_identity_type", value);
    }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceDirectoryDescription
    {
        get => GetArgument<TerraformValue<string>>("workspace_directory_description");
        set => SetArgument("workspace_directory_description", value);
    }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceDirectoryName
    {
        get => GetArgument<TerraformValue<string>>("workspace_directory_name");
        set => SetArgument("workspace_directory_name", value);
    }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceType
    {
        get => GetArgument<TerraformValue<string>>("workspace_type");
        set => SetArgument("workspace_type", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => AsReference("alias");

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    public TerraformValue<string> CustomerUserName
        => AsReference("customer_user_name");

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformValue<string> DirectoryName
        => AsReference("directory_name");

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    public TerraformValue<string> DirectoryType
        => AsReference("directory_type");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> DnsIpAddresses
        => AsReference("dns_ip_addresses");

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    public TerraformValue<string> IamRoleId
        => AsReference("iam_role_id");

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    public TerraformValue<string> RegistrationCode
        => AsReference("registration_code");

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceSecurityGroupId
        => AsReference("workspace_security_group_id");

    /// <summary>
    /// ActiveDirectoryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfig block(s) allowed")]
    public TerraformList<AwsWorkspacesDirectoryActiveDirectoryConfigBlock>? ActiveDirectoryConfig
    {
        get => GetArgument<TerraformList<AwsWorkspacesDirectoryActiveDirectoryConfigBlock>>("active_directory_config");
        set => SetArgument("active_directory_config", value);
    }

    /// <summary>
    /// CertificateBasedAuthProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    public TerraformList<AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock>? CertificateBasedAuthProperties
    {
        get => GetArgument<TerraformList<AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock>>("certificate_based_auth_properties");
        set => SetArgument("certificate_based_auth_properties", value);
    }

    /// <summary>
    /// SamlProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlProperties block(s) allowed")]
    public TerraformList<AwsWorkspacesDirectorySamlPropertiesBlock>? SamlProperties
    {
        get => GetArgument<TerraformList<AwsWorkspacesDirectorySamlPropertiesBlock>>("saml_properties");
        set => SetArgument("saml_properties", value);
    }

    /// <summary>
    /// SelfServicePermissions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfServicePermissions block(s) allowed")]
    public TerraformList<AwsWorkspacesDirectorySelfServicePermissionsBlock>? SelfServicePermissions
    {
        get => GetArgument<TerraformList<AwsWorkspacesDirectorySelfServicePermissionsBlock>>("self_service_permissions");
        set => SetArgument("self_service_permissions", value);
    }

    /// <summary>
    /// WorkspaceAccessProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceAccessProperties block(s) allowed")]
    public TerraformList<AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock>? WorkspaceAccessProperties
    {
        get => GetArgument<TerraformList<AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock>>("workspace_access_properties");
        set => SetArgument("workspace_access_properties", value);
    }

    /// <summary>
    /// WorkspaceCreationProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceCreationProperties block(s) allowed")]
    public TerraformList<AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock>? WorkspaceCreationProperties
    {
        get => GetArgument<TerraformList<AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock>>("workspace_creation_properties");
        set => SetArgument("workspace_creation_properties", value);
    }

}
