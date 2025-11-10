using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for component_version in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterComponentVersionBlock : TerraformBlock
{
    /// <summary>
    /// The spark attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spark is required")]
    public required TerraformProperty<string> Spark
    {
        get => GetProperty<TerraformProperty<string>>("spark");
        set => WithProperty("spark", value);
    }

}

/// <summary>
/// Block type for compute_isolation in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterComputeIsolationBlock : TerraformBlock
{
    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ComputeIsolationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("compute_isolation_enabled");
        set => WithProperty("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The host_sku attribute.
    /// </summary>
    public TerraformProperty<string>? HostSku
    {
        get => GetProperty<TerraformProperty<string>>("host_sku");
        set => WithProperty("host_sku", value);
    }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("encryption_algorithm");
        set => WithProperty("encryption_algorithm", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => WithProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_managed_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultManagedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_managed_identity_id");
        set => WithProperty("key_vault_managed_identity_id", value);
    }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterExtensionBlock : TerraformBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    public required TerraformProperty<string> PrimaryKey
    {
        get => GetProperty<TerraformProperty<string>>("primary_key");
        set => WithProperty("primary_key", value);
    }

}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterGatewayBlock : TerraformBlock
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for metastores in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterMetastoresBlock : TerraformBlock
{
}

/// <summary>
/// Block type for monitor in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterMonitorBlock : TerraformBlock
{
    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    public required TerraformProperty<string> PrimaryKey
    {
        get => GetProperty<TerraformProperty<string>>("primary_key");
        set => WithProperty("primary_key", value);
    }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterNetworkBlock : TerraformBlock
{
    /// <summary>
    /// The connection_direction attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionDirection
    {
        get => GetProperty<TerraformProperty<string>>("connection_direction");
        set => WithProperty("connection_direction", value);
    }

    /// <summary>
    /// The private_link_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateLinkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_link_enabled");
        set => WithProperty("private_link_enabled", value);
    }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
        set => WithProperty("group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterSecurityProfileBlock : TerraformBlock
{
    /// <summary>
    /// The aadds_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AaddsResourceId is required")]
    public required TerraformProperty<string> AaddsResourceId
    {
        get => GetProperty<TerraformProperty<string>>("aadds_resource_id");
        set => WithProperty("aadds_resource_id", value);
    }

    /// <summary>
    /// The cluster_users_group_dns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ClusterUsersGroupDns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cluster_users_group_dns");
        set => WithProperty("cluster_users_group_dns", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_user_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUserPassword is required")]
    public required TerraformProperty<string> DomainUserPassword
    {
        get => GetProperty<TerraformProperty<string>>("domain_user_password");
        set => WithProperty("domain_user_password", value);
    }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUsername is required")]
    public required TerraformProperty<string> DomainUsername
    {
        get => GetProperty<TerraformProperty<string>>("domain_username");
        set => WithProperty("domain_username", value);
    }

    /// <summary>
    /// The ldaps_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LdapsUrls is required")]
    public HashSet<TerraformProperty<string>>? LdapsUrls
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ldaps_urls");
        set => WithProperty("ldaps_urls", value);
    }

    /// <summary>
    /// The msi_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MsiResourceId is required")]
    public required TerraformProperty<string> MsiResourceId
    {
        get => GetProperty<TerraformProperty<string>>("msi_resource_id");
        set => WithProperty("msi_resource_id", value);
    }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    public required TerraformProperty<bool> IsDefault
    {
        get => GetProperty<TerraformProperty<bool>>("is_default");
        set => WithProperty("is_default", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    public required TerraformProperty<string> StorageAccountKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_key");
        set => WithProperty("storage_account_key", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    public required TerraformProperty<string> StorageContainerId
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_id");
        set => WithProperty("storage_container_id", value);
    }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageResourceId
    {
        get => GetProperty<TerraformProperty<string>>("storage_resource_id");
        set => WithProperty("storage_resource_id", value);
    }

}

/// <summary>
/// Block type for storage_account_gen2 in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterStorageAccountGen2Block : TerraformBlock
{
    /// <summary>
    /// The filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemId is required")]
    public required TerraformProperty<string> FilesystemId
    {
        get => GetProperty<TerraformProperty<string>>("filesystem_id");
        set => WithProperty("filesystem_id", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    public required TerraformProperty<bool> IsDefault
    {
        get => GetProperty<TerraformProperty<bool>>("is_default");
        set => WithProperty("is_default", value);
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityResourceId is required")]
    public required TerraformProperty<string> ManagedIdentityResourceId
    {
        get => GetProperty<TerraformProperty<string>>("managed_identity_resource_id");
        set => WithProperty("managed_identity_resource_id", value);
    }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageResourceId is required")]
    public required TerraformProperty<string> StorageResourceId
    {
        get => GetProperty<TerraformProperty<string>>("storage_resource_id");
        set => WithProperty("storage_resource_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightSparkClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_hdinsight_spark_cluster resource.
/// </summary>
public class AzurermHdinsightSparkCluster : TerraformResource
{
    public AzurermHdinsightSparkCluster(string name) : base("azurerm_hdinsight_spark_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("https_endpoint");
        this.DeclareOutput("ssh_endpoint");
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    public required TerraformProperty<string> ClusterVersion
    {
        get => GetProperty<TerraformProperty<string>>("cluster_version");
        set => this.WithProperty("cluster_version", value);
    }

    /// <summary>
    /// The encryption_in_transit_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionInTransitEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_in_transit_enabled");
        set => this.WithProperty("encryption_in_transit_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public TerraformProperty<string>? TlsMinVersion
    {
        get => GetProperty<TerraformProperty<string>>("tls_min_version");
        set => this.WithProperty("tls_min_version", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for component_version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComponentVersion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComponentVersion block(s) allowed")]
    public List<AzurermHdinsightSparkClusterComponentVersionBlock>? ComponentVersion
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterComponentVersionBlock>>("component_version");
        set => this.WithProperty("component_version", value);
    }

    /// <summary>
    /// Block for compute_isolation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeIsolation block(s) allowed")]
    public List<AzurermHdinsightSparkClusterComputeIsolationBlock>? ComputeIsolation
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterComputeIsolationBlock>>("compute_isolation");
        set => this.WithProperty("compute_isolation", value);
    }

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermHdinsightSparkClusterDiskEncryptionBlock>? DiskEncryption
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterDiskEncryptionBlock>>("disk_encryption");
        set => this.WithProperty("disk_encryption", value);
    }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extension block(s) allowed")]
    public List<AzurermHdinsightSparkClusterExtensionBlock>? Extension
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterExtensionBlock>>("extension");
        set => this.WithProperty("extension", value);
    }

    /// <summary>
    /// Block for gateway.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Gateway block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    public List<AzurermHdinsightSparkClusterGatewayBlock>? Gateway
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterGatewayBlock>>("gateway");
        set => this.WithProperty("gateway", value);
    }

    /// <summary>
    /// Block for metastores.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metastores block(s) allowed")]
    public List<AzurermHdinsightSparkClusterMetastoresBlock>? Metastores
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterMetastoresBlock>>("metastores");
        set => this.WithProperty("metastores", value);
    }

    /// <summary>
    /// Block for monitor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitor block(s) allowed")]
    public List<AzurermHdinsightSparkClusterMonitorBlock>? Monitor
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterMonitorBlock>>("monitor");
        set => this.WithProperty("monitor", value);
    }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public List<AzurermHdinsightSparkClusterNetworkBlock>? Network
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterNetworkBlock>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// Block for private_link_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLinkConfiguration block(s) allowed")]
    public List<AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock>? PrivateLinkConfiguration
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock>>("private_link_configuration");
        set => this.WithProperty("private_link_configuration", value);
    }

    /// <summary>
    /// Block for roles.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Roles block(s) allowed")]
    public List<AzurermHdinsightSparkClusterRolesBlock>? Roles
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterRolesBlock>>("roles");
        set => this.WithProperty("roles", value);
    }

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public List<AzurermHdinsightSparkClusterSecurityProfileBlock>? SecurityProfile
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterSecurityProfileBlock>>("security_profile");
        set => this.WithProperty("security_profile", value);
    }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermHdinsightSparkClusterStorageAccountBlock>? StorageAccount
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterStorageAccountBlock>>("storage_account");
        set => this.WithProperty("storage_account", value);
    }

    /// <summary>
    /// Block for storage_account_gen2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccountGen2 block(s) allowed")]
    public List<AzurermHdinsightSparkClusterStorageAccountGen2Block>? StorageAccountGen2
    {
        get => GetProperty<List<AzurermHdinsightSparkClusterStorageAccountGen2Block>>("storage_account_gen2");
        set => this.WithProperty("storage_account_gen2", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHdinsightSparkClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermHdinsightSparkClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    public TerraformExpression HttpsEndpoint => this["https_endpoint"];

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    public TerraformExpression SshEndpoint => this["ssh_endpoint"];

}
