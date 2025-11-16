using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for component_version in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterComponentVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component_version";

    /// <summary>
    /// The interactive_hive attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InteractiveHive is required")]
    public required TerraformValue<string> InteractiveHive
    {
        get => new TerraformReference<string>(this, "interactive_hive");
        set => SetArgument("interactive_hive", value);
    }

}

/// <summary>
/// Block type for compute_isolation in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterComputeIsolationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_isolation";

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ComputeIsolationEnabled
    {
        get => new TerraformReference<bool>(this, "compute_isolation_enabled");
        set => SetArgument("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The host_sku attribute.
    /// </summary>
    public TerraformValue<string>? HostSku
    {
        get => new TerraformReference<string>(this, "host_sku");
        set => SetArgument("host_sku", value);
    }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption";

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionAlgorithm
    {
        get => new TerraformReference<string>(this, "encryption_algorithm");
        set => SetArgument("encryption_algorithm", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_managed_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultManagedIdentityId
    {
        get => new TerraformReference<string>(this, "key_vault_managed_identity_id");
        set => SetArgument("key_vault_managed_identity_id", value);
    }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension";

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    public required TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
        set => SetArgument("primary_key", value);
    }

}

/// <summary>
/// Block type for gateway in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for metastores in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterMetastoresBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metastores";

}

/// <summary>
/// Block type for monitor in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterMonitorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor";

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    public required TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
        set => SetArgument("primary_key", value);
    }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network";

    /// <summary>
    /// The connection_direction attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionDirection
    {
        get => new TerraformReference<string>(this, "connection_direction");
        set => SetArgument("connection_direction", value);
    }

    /// <summary>
    /// The private_link_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateLinkEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_enabled");
        set => SetArgument("private_link_enabled", value);
    }

}

/// <summary>
/// Block type for private_link_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterPrivateLinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_link_configuration";

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformValue<string> GroupId
    {
        get => new TerraformReference<string>(this, "group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterRolesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "roles";

}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterSecurityProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_profile";

    /// <summary>
    /// The aadds_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AaddsResourceId is required")]
    public required TerraformValue<string> AaddsResourceId
    {
        get => new TerraformReference<string>(this, "aadds_resource_id");
        set => SetArgument("aadds_resource_id", value);
    }

    /// <summary>
    /// The cluster_users_group_dns attribute.
    /// </summary>
    public TerraformSet<string>? ClusterUsersGroupDns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cluster_users_group_dns").ResolveNodes(ctx));
        set => SetArgument("cluster_users_group_dns", value);
    }

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
    /// The domain_user_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUserPassword is required")]
    public required TerraformValue<string> DomainUserPassword
    {
        get => new TerraformReference<string>(this, "domain_user_password");
        set => SetArgument("domain_user_password", value);
    }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUsername is required")]
    public required TerraformValue<string> DomainUsername
    {
        get => new TerraformReference<string>(this, "domain_username");
        set => SetArgument("domain_username", value);
    }

    /// <summary>
    /// The ldaps_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LdapsUrls is required")]
    public required TerraformSet<string> LdapsUrls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ldaps_urls").ResolveNodes(ctx));
        set => SetArgument("ldaps_urls", value);
    }

    /// <summary>
    /// The msi_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MsiResourceId is required")]
    public required TerraformValue<string> MsiResourceId
    {
        get => new TerraformReference<string>(this, "msi_resource_id");
        set => SetArgument("msi_resource_id", value);
    }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account";

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    public required TerraformValue<bool> IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    public required TerraformValue<string> StorageAccountKey
    {
        get => new TerraformReference<string>(this, "storage_account_key");
        set => SetArgument("storage_account_key", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    public required TerraformValue<string> StorageContainerId
    {
        get => new TerraformReference<string>(this, "storage_container_id");
        set => SetArgument("storage_container_id", value);
    }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageResourceId
    {
        get => new TerraformReference<string>(this, "storage_resource_id");
        set => SetArgument("storage_resource_id", value);
    }

}

/// <summary>
/// Block type for storage_account_gen2 in .
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterStorageAccountGen2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account_gen2";

    /// <summary>
    /// The filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemId is required")]
    public required TerraformValue<string> FilesystemId
    {
        get => new TerraformReference<string>(this, "filesystem_id");
        set => SetArgument("filesystem_id", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    public required TerraformValue<bool> IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityResourceId is required")]
    public required TerraformValue<string> ManagedIdentityResourceId
    {
        get => new TerraformReference<string>(this, "managed_identity_resource_id");
        set => SetArgument("managed_identity_resource_id", value);
    }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageResourceId is required")]
    public required TerraformValue<string> StorageResourceId
    {
        get => new TerraformReference<string>(this, "storage_resource_id");
        set => SetArgument("storage_resource_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightInteractiveQueryClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_hdinsight_interactive_query_cluster Terraform resource.
/// Manages a azurerm_hdinsight_interactive_query_cluster resource.
/// </summary>
public partial class AzurermHdinsightInteractiveQueryCluster(string name) : TerraformResource("azurerm_hdinsight_interactive_query_cluster", name)
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    public required TerraformValue<string> ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The encryption_in_transit_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionInTransitEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_in_transit_enabled");
        set => SetArgument("encryption_in_transit_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public TerraformValue<string>? TlsMinVersion
    {
        get => new TerraformReference<string>(this, "tls_min_version");
        set => SetArgument("tls_min_version", value);
    }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    public TerraformValue<string> HttpsEndpoint
    {
        get => new TerraformReference<string>(this, "https_endpoint");
    }

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SshEndpoint
    {
        get => new TerraformReference<string>(this, "ssh_endpoint");
    }

    /// <summary>
    /// ComponentVersion block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentVersion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComponentVersion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComponentVersion block(s) allowed")]
    public required TerraformList<AzurermHdinsightInteractiveQueryClusterComponentVersionBlock> ComponentVersion
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterComponentVersionBlock>>("component_version");
        set => SetArgument("component_version", value);
    }

    /// <summary>
    /// ComputeIsolation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeIsolation block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterComputeIsolationBlock>? ComputeIsolation
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterComputeIsolationBlock>>("compute_isolation");
        set => SetArgument("compute_isolation", value);
    }

    /// <summary>
    /// DiskEncryption block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightInteractiveQueryClusterDiskEncryptionBlock>? DiskEncryption
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterDiskEncryptionBlock>>("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// Extension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extension block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterExtensionBlock>? Extension
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterExtensionBlock>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// Gateway block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Gateway block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    public required TerraformList<AzurermHdinsightInteractiveQueryClusterGatewayBlock> Gateway
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterGatewayBlock>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// Metastores block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metastores block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterMetastoresBlock>? Metastores
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterMetastoresBlock>>("metastores");
        set => SetArgument("metastores", value);
    }

    /// <summary>
    /// Monitor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitor block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterMonitorBlock>? Monitor
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterMonitorBlock>>("monitor");
        set => SetArgument("monitor", value);
    }

    /// <summary>
    /// Network block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterNetworkBlock>? Network
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterNetworkBlock>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// PrivateLinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLinkConfiguration block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterPrivateLinkConfigurationBlock>? PrivateLinkConfiguration
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterPrivateLinkConfigurationBlock>>("private_link_configuration");
        set => SetArgument("private_link_configuration", value);
    }

    /// <summary>
    /// Roles block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Roles block(s) allowed")]
    public required TerraformList<AzurermHdinsightInteractiveQueryClusterRolesBlock> Roles
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterRolesBlock>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// SecurityProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterSecurityProfileBlock>? SecurityProfile
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterSecurityProfileBlock>>("security_profile");
        set => SetArgument("security_profile", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightInteractiveQueryClusterStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// StorageAccountGen2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccountGen2 block(s) allowed")]
    public TerraformList<AzurermHdinsightInteractiveQueryClusterStorageAccountGen2Block>? StorageAccountGen2
    {
        get => GetArgument<TerraformList<AzurermHdinsightInteractiveQueryClusterStorageAccountGen2Block>>("storage_account_gen2");
        set => SetArgument("storage_account_gen2", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHdinsightInteractiveQueryClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHdinsightInteractiveQueryClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
