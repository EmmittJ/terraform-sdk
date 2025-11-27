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
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The service_account_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountSecretArn is required")]
    public required TerraformValue<string> ServiceAccountSecretArn
    {
        get => new TerraformReference<string>(this, "service_account_secret_arn");
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
        get => new TerraformReference<string>(this, "certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
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
        get => new TerraformReference<string>(this, "relay_state_parameter_name");
        set => SetArgument("relay_state_parameter_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The user_access_url attribute.
    /// </summary>
    public TerraformValue<string>? UserAccessUrl
    {
        get => new TerraformReference<string>(this, "user_access_url");
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
        get => new TerraformReference<bool>(this, "change_compute_type");
        set => SetArgument("change_compute_type", value);
    }

    /// <summary>
    /// The increase_volume_size attribute.
    /// </summary>
    public TerraformValue<bool>? IncreaseVolumeSize
    {
        get => new TerraformReference<bool>(this, "increase_volume_size");
        set => SetArgument("increase_volume_size", value);
    }

    /// <summary>
    /// The rebuild_workspace attribute.
    /// </summary>
    public TerraformValue<bool>? RebuildWorkspace
    {
        get => new TerraformReference<bool>(this, "rebuild_workspace");
        set => SetArgument("rebuild_workspace", value);
    }

    /// <summary>
    /// The restart_workspace attribute.
    /// </summary>
    public TerraformValue<bool>? RestartWorkspace
    {
        get => new TerraformReference<bool>(this, "restart_workspace");
        set => SetArgument("restart_workspace", value);
    }

    /// <summary>
    /// The switch_running_mode attribute.
    /// </summary>
    public TerraformValue<bool>? SwitchRunningMode
    {
        get => new TerraformReference<bool>(this, "switch_running_mode");
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
        get => new TerraformReference<string>(this, "device_type_android");
        set => SetArgument("device_type_android", value);
    }

    /// <summary>
    /// The device_type_chromeos attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeChromeos
    {
        get => new TerraformReference<string>(this, "device_type_chromeos");
        set => SetArgument("device_type_chromeos", value);
    }

    /// <summary>
    /// The device_type_ios attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeIos
    {
        get => new TerraformReference<string>(this, "device_type_ios");
        set => SetArgument("device_type_ios", value);
    }

    /// <summary>
    /// The device_type_linux attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeLinux
    {
        get => new TerraformReference<string>(this, "device_type_linux");
        set => SetArgument("device_type_linux", value);
    }

    /// <summary>
    /// The device_type_osx attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeOsx
    {
        get => new TerraformReference<string>(this, "device_type_osx");
        set => SetArgument("device_type_osx", value);
    }

    /// <summary>
    /// The device_type_web attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeWeb
    {
        get => new TerraformReference<string>(this, "device_type_web");
        set => SetArgument("device_type_web", value);
    }

    /// <summary>
    /// The device_type_windows attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeWindows
    {
        get => new TerraformReference<string>(this, "device_type_windows");
        set => SetArgument("device_type_windows", value);
    }

    /// <summary>
    /// The device_type_zeroclient attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTypeZeroclient
    {
        get => new TerraformReference<string>(this, "device_type_zeroclient");
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
        get => new TerraformReference<string>(this, "custom_security_group_id");
        set => SetArgument("custom_security_group_id", value);
    }

    /// <summary>
    /// The default_ou attribute.
    /// </summary>
    public TerraformValue<string>? DefaultOu
    {
        get => new TerraformReference<string>(this, "default_ou");
        set => SetArgument("default_ou", value);
    }

    /// <summary>
    /// The enable_internet_access attribute.
    /// </summary>
    public TerraformValue<bool>? EnableInternetAccess
    {
        get => new TerraformReference<bool>(this, "enable_internet_access");
        set => SetArgument("enable_internet_access", value);
    }

    /// <summary>
    /// The enable_maintenance_mode attribute.
    /// </summary>
    public TerraformValue<bool>? EnableMaintenanceMode
    {
        get => new TerraformReference<bool>(this, "enable_maintenance_mode");
        set => SetArgument("enable_maintenance_mode", value);
    }

    /// <summary>
    /// The user_enabled_as_local_administrator attribute.
    /// </summary>
    public TerraformValue<bool>? UserEnabledAsLocalAdministrator
    {
        get => new TerraformReference<bool>(this, "user_enabled_as_local_administrator");
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
    public TerraformValue<string> DirectoryId
    {
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    public TerraformSet<string> IpGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_group_ids").ResolveNodes(ctx));
        set => SetArgument("ip_group_ids", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformValue<string> UserIdentityType
    {
        get => new TerraformReference<string>(this, "user_identity_type");
        set => SetArgument("user_identity_type", value);
    }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceDirectoryDescription
    {
        get => new TerraformReference<string>(this, "workspace_directory_description");
        set => SetArgument("workspace_directory_description", value);
    }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceDirectoryName
    {
        get => new TerraformReference<string>(this, "workspace_directory_name");
        set => SetArgument("workspace_directory_name", value);
    }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceType
    {
        get => new TerraformReference<string>(this, "workspace_type");
        set => SetArgument("workspace_type", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
    }

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    public TerraformValue<string> CustomerUserName
    {
        get => new TerraformReference<string>(this, "customer_user_name");
    }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformValue<string> DirectoryName
    {
        get => new TerraformReference<string>(this, "directory_name");
    }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    public TerraformValue<string> DirectoryType
    {
        get => new TerraformReference<string>(this, "directory_type");
    }

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> DnsIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "dns_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    public TerraformValue<string> IamRoleId
    {
        get => new TerraformReference<string>(this, "iam_role_id");
    }

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    public TerraformValue<string> RegistrationCode
    {
        get => new TerraformReference<string>(this, "registration_code");
    }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceSecurityGroupId
    {
        get => new TerraformReference<string>(this, "workspace_security_group_id");
    }

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
