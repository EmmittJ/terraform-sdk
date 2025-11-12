using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for active_directory_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspacesDirectoryActiveDirectoryConfigBlock() : TerraformBlock("active_directory_config")
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The service_account_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountSecretArn is required")]
    [TerraformProperty("service_account_secret_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceAccountSecretArn { get; set; }

}

/// <summary>
/// Block type for certificate_based_auth_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock() : TerraformBlock("certificate_based_auth_properties")
{
    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_authority_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Block type for saml_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspacesDirectorySamlPropertiesBlock() : TerraformBlock("saml_properties")
{
    /// <summary>
    /// The relay_state_parameter_name attribute.
    /// </summary>
    [TerraformProperty("relay_state_parameter_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RelayStateParameterName { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The user_access_url attribute.
    /// </summary>
    [TerraformProperty("user_access_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAccessUrl { get; set; }

}

/// <summary>
/// Block type for self_service_permissions in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspacesDirectorySelfServicePermissionsBlock() : TerraformBlock("self_service_permissions")
{
    /// <summary>
    /// The change_compute_type attribute.
    /// </summary>
    [TerraformProperty("change_compute_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ChangeComputeType { get; set; }

    /// <summary>
    /// The increase_volume_size attribute.
    /// </summary>
    [TerraformProperty("increase_volume_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncreaseVolumeSize { get; set; }

    /// <summary>
    /// The rebuild_workspace attribute.
    /// </summary>
    [TerraformProperty("rebuild_workspace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RebuildWorkspace { get; set; }

    /// <summary>
    /// The restart_workspace attribute.
    /// </summary>
    [TerraformProperty("restart_workspace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RestartWorkspace { get; set; }

    /// <summary>
    /// The switch_running_mode attribute.
    /// </summary>
    [TerraformProperty("switch_running_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SwitchRunningMode { get; set; }

}

/// <summary>
/// Block type for workspace_access_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock() : TerraformBlock("workspace_access_properties")
{
    /// <summary>
    /// The device_type_android attribute.
    /// </summary>
    [TerraformProperty("device_type_android")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeAndroid { get; set; }

    /// <summary>
    /// The device_type_chromeos attribute.
    /// </summary>
    [TerraformProperty("device_type_chromeos")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeChromeos { get; set; }

    /// <summary>
    /// The device_type_ios attribute.
    /// </summary>
    [TerraformProperty("device_type_ios")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeIos { get; set; }

    /// <summary>
    /// The device_type_linux attribute.
    /// </summary>
    [TerraformProperty("device_type_linux")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeLinux { get; set; }

    /// <summary>
    /// The device_type_osx attribute.
    /// </summary>
    [TerraformProperty("device_type_osx")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeOsx { get; set; }

    /// <summary>
    /// The device_type_web attribute.
    /// </summary>
    [TerraformProperty("device_type_web")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeWeb { get; set; }

    /// <summary>
    /// The device_type_windows attribute.
    /// </summary>
    [TerraformProperty("device_type_windows")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeWindows { get; set; }

    /// <summary>
    /// The device_type_zeroclient attribute.
    /// </summary>
    [TerraformProperty("device_type_zeroclient")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTypeZeroclient { get; set; }

}

/// <summary>
/// Block type for workspace_creation_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock() : TerraformBlock("workspace_creation_properties")
{
    /// <summary>
    /// The custom_security_group_id attribute.
    /// </summary>
    [TerraformProperty("custom_security_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomSecurityGroupId { get; set; }

    /// <summary>
    /// The default_ou attribute.
    /// </summary>
    [TerraformProperty("default_ou")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultOu { get; set; }

    /// <summary>
    /// The enable_internet_access attribute.
    /// </summary>
    [TerraformProperty("enable_internet_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableInternetAccess { get; set; }

    /// <summary>
    /// The enable_maintenance_mode attribute.
    /// </summary>
    [TerraformProperty("enable_maintenance_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableMaintenanceMode { get; set; }

    /// <summary>
    /// The user_enabled_as_local_administrator attribute.
    /// </summary>
    [TerraformProperty("user_enabled_as_local_administrator")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UserEnabledAsLocalAdministrator { get; set; }

}

/// <summary>
/// Manages a aws_workspaces_directory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsWorkspacesDirectory : TerraformResource
{
    public AwsWorkspacesDirectory(string name) : base("aws_workspaces_directory", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformProperty("directory_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    [TerraformProperty("ip_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> IpGroupIds { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    [TerraformProperty("user_identity_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserIdentityType { get; set; }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    [TerraformProperty("workspace_directory_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkspaceDirectoryDescription { get; set; }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    [TerraformProperty("workspace_directory_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkspaceDirectoryName { get; set; }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    [TerraformProperty("workspace_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkspaceType { get; set; }

    /// <summary>
    /// Block for active_directory_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfig block(s) allowed")]
    [TerraformProperty("active_directory_config")]
    public TerraformList<AwsWorkspacesDirectoryActiveDirectoryConfigBlock> ActiveDirectoryConfig { get; set; } = new();

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    [TerraformProperty("certificate_based_auth_properties")]
    public TerraformList<AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock> CertificateBasedAuthProperties { get; set; } = new();

    /// <summary>
    /// Block for saml_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlProperties block(s) allowed")]
    [TerraformProperty("saml_properties")]
    public TerraformList<AwsWorkspacesDirectorySamlPropertiesBlock> SamlProperties { get; set; } = new();

    /// <summary>
    /// Block for self_service_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfServicePermissions block(s) allowed")]
    [TerraformProperty("self_service_permissions")]
    public TerraformList<AwsWorkspacesDirectorySelfServicePermissionsBlock> SelfServicePermissions { get; set; } = new();

    /// <summary>
    /// Block for workspace_access_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceAccessProperties block(s) allowed")]
    [TerraformProperty("workspace_access_properties")]
    public TerraformList<AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock> WorkspaceAccessProperties { get; set; } = new();

    /// <summary>
    /// Block for workspace_creation_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceCreationProperties block(s) allowed")]
    [TerraformProperty("workspace_creation_properties")]
    public TerraformList<AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock> WorkspaceCreationProperties { get; set; } = new();

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Alias { get; }

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    [TerraformProperty("customer_user_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerUserName { get; }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformProperty("directory_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DirectoryName { get; }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [TerraformProperty("directory_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DirectoryType { get; }

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("dns_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> DnsIpAddresses { get; }

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    [TerraformProperty("iam_role_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IamRoleId { get; }

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    [TerraformProperty("registration_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistrationCode { get; }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [TerraformProperty("workspace_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceSecurityGroupId { get; }

}
