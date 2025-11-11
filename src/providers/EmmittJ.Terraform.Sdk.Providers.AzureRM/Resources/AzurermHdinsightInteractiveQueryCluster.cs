using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for component_version in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterComponentVersionBlock
{
    /// <summary>
    /// The interactive_hive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InteractiveHive is required")]
    [TerraformPropertyName("interactive_hive")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InteractiveHive { get; set; }

}

/// <summary>
/// Block type for compute_isolation in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterComputeIsolationBlock
{
    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("compute_isolation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ComputeIsolationEnabled { get; set; }

    /// <summary>
    /// The host_sku attribute.
    /// </summary>
    [TerraformPropertyName("host_sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostSku { get; set; }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterDiskEncryptionBlock
{
    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("encryption_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_host_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The key_vault_managed_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_managed_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultManagedIdentityId { get; set; }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterExtensionBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    [TerraformPropertyName("primary_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrimaryKey { get; set; }

}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterGatewayBlock
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for metastores in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterMetastoresBlock
{
}

/// <summary>
/// Block type for monitor in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterMonitorBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    [TerraformPropertyName("primary_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrimaryKey { get; set; }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterNetworkBlock
{
    /// <summary>
    /// The connection_direction attribute.
    /// </summary>
    [TerraformPropertyName("connection_direction")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionDirection { get; set; }

    /// <summary>
    /// The private_link_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_link_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateLinkEnabled { get; set; }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterPrivateLinkConfigurationBlock
{
    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformPropertyName("group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GroupId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterRolesBlock
{
}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterSecurityProfileBlock
{
    /// <summary>
    /// The aadds_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AaddsResourceId is required")]
    [TerraformPropertyName("aadds_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AaddsResourceId { get; set; }

    /// <summary>
    /// The cluster_users_group_dns attribute.
    /// </summary>
    [TerraformPropertyName("cluster_users_group_dns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_user_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUserPassword is required")]
    [TerraformPropertyName("domain_user_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainUserPassword { get; set; }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUsername is required")]
    [TerraformPropertyName("domain_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainUsername { get; set; }

    /// <summary>
    /// The ldaps_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LdapsUrls is required")]
    [TerraformPropertyName("ldaps_urls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> LdapsUrls { get; set; }

    /// <summary>
    /// The msi_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MsiResourceId is required")]
    [TerraformPropertyName("msi_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MsiResourceId { get; set; }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterStorageAccountBlock
{
    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    [TerraformPropertyName("is_default")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> IsDefault { get; set; }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    [TerraformPropertyName("storage_account_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountKey { get; set; }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    [TerraformPropertyName("storage_container_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageContainerId { get; set; }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageResourceId { get; set; }

}

/// <summary>
/// Block type for storage_account_gen2 in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterStorageAccountGen2Block
{
    /// <summary>
    /// The filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemId is required")]
    [TerraformPropertyName("filesystem_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FilesystemId { get; set; }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    [TerraformPropertyName("is_default")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> IsDefault { get; set; }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityResourceId is required")]
    [TerraformPropertyName("managed_identity_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ManagedIdentityResourceId { get; set; }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageResourceId is required")]
    [TerraformPropertyName("storage_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageResourceId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_hdinsight_interactive_query_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHdinsightInteractiveQueryCluster : TerraformResource
{
    public AzurermHdinsightInteractiveQueryCluster(string name) : base("azurerm_hdinsight_interactive_query_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    [TerraformPropertyName("cluster_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterVersion { get; set; }

    /// <summary>
    /// The encryption_in_transit_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_in_transit_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EncryptionInTransitEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformPropertyName("tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    [TerraformPropertyName("tls_min_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TlsMinVersion { get; set; }

    /// <summary>
    /// Block for component_version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentVersion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComponentVersion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComponentVersion block(s) allowed")]
    [TerraformPropertyName("component_version")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterComponentVersionBlock>>? ComponentVersion { get; set; }

    /// <summary>
    /// Block for compute_isolation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeIsolation block(s) allowed")]
    [TerraformPropertyName("compute_isolation")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterComputeIsolationBlock>>? ComputeIsolation { get; set; }

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("disk_encryption")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterDiskEncryptionBlock>>? DiskEncryption { get; set; }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extension block(s) allowed")]
    [TerraformPropertyName("extension")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterExtensionBlock>>? Extension { get; set; }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Gateway block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    [TerraformPropertyName("gateway")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterGatewayBlock>>? Gateway { get; set; }

    /// <summary>
    /// Block for metastores.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metastores block(s) allowed")]
    [TerraformPropertyName("metastores")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterMetastoresBlock>>? Metastores { get; set; }

    /// <summary>
    /// Block for monitor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitor block(s) allowed")]
    [TerraformPropertyName("monitor")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterMonitorBlock>>? Monitor { get; set; }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformPropertyName("network")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterNetworkBlock>>? Network { get; set; }

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLinkConfiguration block(s) allowed")]
    [TerraformPropertyName("private_link_configuration")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterPrivateLinkConfigurationBlock>>? PrivateLinkConfiguration { get; set; }

    /// <summary>
    /// Block for roles.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Roles block(s) allowed")]
    [TerraformPropertyName("roles")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterRolesBlock>>? Roles { get; set; }

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    [TerraformPropertyName("security_profile")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterSecurityProfileBlock>>? SecurityProfile { get; set; }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("storage_account")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterStorageAccountBlock>>? StorageAccount { get; set; }

    /// <summary>
    /// Block for storage_account_gen2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccountGen2 block(s) allowed")]
    [TerraformPropertyName("storage_account_gen2")]
    public TerraformList<TerraformBlock<AzurermHdinsightInteractiveQueryClusterStorageAccountGen2Block>>? StorageAccountGen2 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHdinsightInteractiveQueryClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("https_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HttpsEndpoint => new TerraformReference(this, "https_endpoint");

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("ssh_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SshEndpoint => new TerraformReference(this, "ssh_endpoint");

}
