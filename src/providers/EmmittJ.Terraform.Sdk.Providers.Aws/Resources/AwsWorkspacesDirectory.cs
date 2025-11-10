using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for active_directory_config in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryActiveDirectoryConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The service_account_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountSecretArn is required")]
    [TerraformPropertyName("service_account_secret_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAccountSecretArn { get; set; }

}

/// <summary>
/// Block type for certificate_based_auth_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_authority_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Status { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "status");

}

/// <summary>
/// Block type for saml_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectorySamlPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The relay_state_parameter_name attribute.
    /// </summary>
    [TerraformPropertyName("relay_state_parameter_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RelayStateParameterName { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The user_access_url attribute.
    /// </summary>
    [TerraformPropertyName("user_access_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAccessUrl { get; set; }

}

/// <summary>
/// Block type for self_service_permissions in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectorySelfServicePermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// The change_compute_type attribute.
    /// </summary>
    [TerraformPropertyName("change_compute_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ChangeComputeType { get; set; }

    /// <summary>
    /// The increase_volume_size attribute.
    /// </summary>
    [TerraformPropertyName("increase_volume_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncreaseVolumeSize { get; set; }

    /// <summary>
    /// The rebuild_workspace attribute.
    /// </summary>
    [TerraformPropertyName("rebuild_workspace")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RebuildWorkspace { get; set; }

    /// <summary>
    /// The restart_workspace attribute.
    /// </summary>
    [TerraformPropertyName("restart_workspace")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RestartWorkspace { get; set; }

    /// <summary>
    /// The switch_running_mode attribute.
    /// </summary>
    [TerraformPropertyName("switch_running_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SwitchRunningMode { get; set; }

}

/// <summary>
/// Block type for workspace_access_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The device_type_android attribute.
    /// </summary>
    [TerraformPropertyName("device_type_android")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeAndroid { get; set; }

    /// <summary>
    /// The device_type_chromeos attribute.
    /// </summary>
    [TerraformPropertyName("device_type_chromeos")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeChromeos { get; set; }

    /// <summary>
    /// The device_type_ios attribute.
    /// </summary>
    [TerraformPropertyName("device_type_ios")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeIos { get; set; }

    /// <summary>
    /// The device_type_linux attribute.
    /// </summary>
    [TerraformPropertyName("device_type_linux")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeLinux { get; set; }

    /// <summary>
    /// The device_type_osx attribute.
    /// </summary>
    [TerraformPropertyName("device_type_osx")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeOsx { get; set; }

    /// <summary>
    /// The device_type_web attribute.
    /// </summary>
    [TerraformPropertyName("device_type_web")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeWeb { get; set; }

    /// <summary>
    /// The device_type_windows attribute.
    /// </summary>
    [TerraformPropertyName("device_type_windows")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeWindows { get; set; }

    /// <summary>
    /// The device_type_zeroclient attribute.
    /// </summary>
    [TerraformPropertyName("device_type_zeroclient")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeviceTypeZeroclient { get; set; }

}

/// <summary>
/// Block type for workspace_creation_properties in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_security_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomSecurityGroupId { get; set; }

    /// <summary>
    /// The default_ou attribute.
    /// </summary>
    [TerraformPropertyName("default_ou")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultOu { get; set; }

    /// <summary>
    /// The enable_internet_access attribute.
    /// </summary>
    [TerraformPropertyName("enable_internet_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableInternetAccess { get; set; }

    /// <summary>
    /// The enable_maintenance_mode attribute.
    /// </summary>
    [TerraformPropertyName("enable_maintenance_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableMaintenanceMode { get; set; }

    /// <summary>
    /// The user_enabled_as_local_administrator attribute.
    /// </summary>
    [TerraformPropertyName("user_enabled_as_local_administrator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UserEnabledAsLocalAdministrator { get; set; }

}

/// <summary>
/// Manages a aws_workspaces_directory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWorkspacesDirectory : TerraformResource
{
    public AwsWorkspacesDirectory(string name) : base("aws_workspaces_directory", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DirectoryId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("ip_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> IpGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ip_group_ids");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

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
    /// The user_identity_type attribute.
    /// </summary>
    [TerraformPropertyName("user_identity_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UserIdentityType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_identity_type");

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    [TerraformPropertyName("workspace_directory_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkspaceDirectoryDescription { get; set; }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    [TerraformPropertyName("workspace_directory_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkspaceDirectoryName { get; set; }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    [TerraformPropertyName("workspace_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkspaceType { get; set; }

    /// <summary>
    /// Block for active_directory_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfig block(s) allowed")]
    [TerraformPropertyName("active_directory_config")]
    public TerraformList<TerraformBlock<AwsWorkspacesDirectoryActiveDirectoryConfigBlock>>? ActiveDirectoryConfig { get; set; } = new();

    /// <summary>
    /// Block for certificate_based_auth_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateBasedAuthProperties block(s) allowed")]
    [TerraformPropertyName("certificate_based_auth_properties")]
    public TerraformList<TerraformBlock<AwsWorkspacesDirectoryCertificateBasedAuthPropertiesBlock>>? CertificateBasedAuthProperties { get; set; } = new();

    /// <summary>
    /// Block for saml_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlProperties block(s) allowed")]
    [TerraformPropertyName("saml_properties")]
    public TerraformList<TerraformBlock<AwsWorkspacesDirectorySamlPropertiesBlock>>? SamlProperties { get; set; } = new();

    /// <summary>
    /// Block for self_service_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfServicePermissions block(s) allowed")]
    [TerraformPropertyName("self_service_permissions")]
    public TerraformList<TerraformBlock<AwsWorkspacesDirectorySelfServicePermissionsBlock>>? SelfServicePermissions { get; set; } = new();

    /// <summary>
    /// Block for workspace_access_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceAccessProperties block(s) allowed")]
    [TerraformPropertyName("workspace_access_properties")]
    public TerraformList<TerraformBlock<AwsWorkspacesDirectoryWorkspaceAccessPropertiesBlock>>? WorkspaceAccessProperties { get; set; } = new();

    /// <summary>
    /// Block for workspace_creation_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceCreationProperties block(s) allowed")]
    [TerraformPropertyName("workspace_creation_properties")]
    public TerraformList<TerraformBlock<AwsWorkspacesDirectoryWorkspaceCreationPropertiesBlock>>? WorkspaceCreationProperties { get; set; } = new();

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Alias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alias");

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    [TerraformPropertyName("customer_user_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerUserName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_user_name");

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformPropertyName("directory_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DirectoryName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_name");

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [TerraformPropertyName("directory_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DirectoryType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_type");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("dns_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DnsIpAddresses => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "dns_ip_addresses");

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IamRoleId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_role_id");

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    [TerraformPropertyName("registration_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistrationCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registration_code");

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_security_group_id");

}
