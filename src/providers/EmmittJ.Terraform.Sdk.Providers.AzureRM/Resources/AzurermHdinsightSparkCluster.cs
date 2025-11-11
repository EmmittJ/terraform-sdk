using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for component_version in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterComponentVersionBlock : TerraformBlockBase
{
    /// <summary>
    /// The spark attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spark is required")]
    [TerraformProperty("spark")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Spark { get; set; }

}

/// <summary>
/// Block type for compute_isolation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterComputeIsolationBlock : TerraformBlockBase
{
    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    [TerraformProperty("compute_isolation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ComputeIsolationEnabled { get; set; }

    /// <summary>
    /// The host_sku attribute.
    /// </summary>
    [TerraformProperty("host_sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostSku { get; set; }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterDiskEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [TerraformProperty("encryption_algorithm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_at_host_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The key_vault_managed_identity_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_managed_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultManagedIdentityId { get; set; }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterExtensionBlock : TerraformBlockBase
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    [TerraformProperty("primary_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrimaryKey { get; set; }

}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterGatewayBlock : TerraformBlockBase
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for metastores in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterMetastoresBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for monitor in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterMonitorBlock : TerraformBlockBase
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    [TerraformProperty("primary_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrimaryKey { get; set; }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterNetworkBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_direction attribute.
    /// </summary>
    [TerraformProperty("connection_direction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionDirection { get; set; }

    /// <summary>
    /// The private_link_enabled attribute.
    /// </summary>
    [TerraformProperty("private_link_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateLinkEnabled { get; set; }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformProperty("group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterRolesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterSecurityProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The aadds_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AaddsResourceId is required")]
    [TerraformProperty("aadds_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AaddsResourceId { get; set; }

    /// <summary>
    /// The cluster_users_group_dns attribute.
    /// </summary>
    [TerraformProperty("cluster_users_group_dns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ClusterUsersGroupDns { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_user_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUserPassword is required")]
    [TerraformProperty("domain_user_password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainUserPassword { get; set; }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUsername is required")]
    [TerraformProperty("domain_username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainUsername { get; set; }

    /// <summary>
    /// The ldaps_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LdapsUrls is required")]
    [TerraformProperty("ldaps_urls")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> LdapsUrls { get; set; }

    /// <summary>
    /// The msi_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MsiResourceId is required")]
    [TerraformProperty("msi_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MsiResourceId { get; set; }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterStorageAccountBlock : TerraformBlockBase
{
    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    [TerraformProperty("is_default")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsDefault { get; set; }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    [TerraformProperty("storage_account_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountKey { get; set; }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    [TerraformProperty("storage_container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageContainerId { get; set; }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    [TerraformProperty("storage_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageResourceId { get; set; }

}

/// <summary>
/// Block type for storage_account_gen2 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHdinsightSparkClusterStorageAccountGen2Block : TerraformBlockBase
{
    /// <summary>
    /// The filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemId is required")]
    [TerraformProperty("filesystem_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FilesystemId { get; set; }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    [TerraformProperty("is_default")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsDefault { get; set; }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityResourceId is required")]
    [TerraformProperty("managed_identity_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedIdentityResourceId { get; set; }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageResourceId is required")]
    [TerraformProperty("storage_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageResourceId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHdinsightSparkClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_hdinsight_spark_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermHdinsightSparkCluster : TerraformResource
{
    public AzurermHdinsightSparkCluster(string name) : base("azurerm_hdinsight_spark_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    [TerraformProperty("cluster_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterVersion { get; set; }

    /// <summary>
    /// The encryption_in_transit_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_in_transit_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionInTransitEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    [TerraformProperty("tls_min_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TlsMinVersion { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for component_version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentVersion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComponentVersion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComponentVersion block(s) allowed")]
    [TerraformProperty("component_version")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterComponentVersionBlock>>? ComponentVersion { get; set; }

    /// <summary>
    /// Block for compute_isolation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeIsolation block(s) allowed")]
    [TerraformProperty("compute_isolation")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterComputeIsolationBlock>>? ComputeIsolation { get; set; }

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("disk_encryption")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterDiskEncryptionBlock>>? DiskEncryption { get; set; }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extension block(s) allowed")]
    [TerraformProperty("extension")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterExtensionBlock>>? Extension { get; set; }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Gateway block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    [TerraformProperty("gateway")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterGatewayBlock>>? Gateway { get; set; }

    /// <summary>
    /// Block for metastores.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metastores block(s) allowed")]
    [TerraformProperty("metastores")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterMetastoresBlock>>? Metastores { get; set; }

    /// <summary>
    /// Block for monitor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitor block(s) allowed")]
    [TerraformProperty("monitor")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterMonitorBlock>>? Monitor { get; set; }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformProperty("network")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterNetworkBlock>>? Network { get; set; }

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLinkConfiguration block(s) allowed")]
    [TerraformProperty("private_link_configuration")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock>>? PrivateLinkConfiguration { get; set; }

    /// <summary>
    /// Block for roles.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Roles block(s) allowed")]
    [TerraformProperty("roles")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterRolesBlock>>? Roles { get; set; }

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    [TerraformProperty("security_profile")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterSecurityProfileBlock>>? SecurityProfile { get; set; }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("storage_account")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterStorageAccountBlock>>? StorageAccount { get; set; }

    /// <summary>
    /// Block for storage_account_gen2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccountGen2 block(s) allowed")]
    [TerraformProperty("storage_account_gen2")]
    public partial TerraformList<TerraformBlock<AzurermHdinsightSparkClusterStorageAccountGen2Block>>? StorageAccountGen2 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermHdinsightSparkClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    [TerraformProperty("https_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HttpsEndpoint { get; }

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    [TerraformProperty("ssh_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SshEndpoint { get; }

}
