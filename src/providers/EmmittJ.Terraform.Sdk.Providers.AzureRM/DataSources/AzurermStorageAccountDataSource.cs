using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_account.
/// </summary>
public class AzurermStorageAccountDataSource : TerraformDataSource
{
    public AzurermStorageAccountDataSource(string name) : base("azurerm_storage_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformArgument("min_tls_version")]
    public TerraformValue<string>? MinTlsVersion
    {
        get => new TerraformReference<string>(this, "min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageAccountDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformArgument("access_tier")]
    public TerraformValue<string> AccessTier
    {
        get => new TerraformReference<string>(this, "access_tier");
    }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformArgument("account_kind")]
    public TerraformValue<string> AccountKind
    {
        get => new TerraformReference<string>(this, "account_kind");
    }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [TerraformArgument("account_replication_type")]
    public TerraformValue<string> AccountReplicationType
    {
        get => new TerraformReference<string>(this, "account_replication_type");
    }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [TerraformArgument("account_tier")]
    public TerraformValue<string> AccountTier
    {
        get => new TerraformReference<string>(this, "account_tier");
    }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformArgument("allow_nested_items_to_be_public")]
    public TerraformValue<bool> AllowNestedItemsToBePublic
    {
        get => new TerraformReference<bool>(this, "allow_nested_items_to_be_public");
    }

    /// <summary>
    /// The azure_files_authentication attribute.
    /// </summary>
    [TerraformArgument("azure_files_authentication")]
    public TerraformList<object> AzureFilesAuthentication
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "azure_files_authentication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformArgument("custom_domain")]
    public TerraformList<object> CustomDomain
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "custom_domain").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformArgument("dns_endpoint_type")]
    public TerraformValue<string> DnsEndpointType
    {
        get => new TerraformReference<string>(this, "dns_endpoint_type");
    }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformArgument("https_traffic_only_enabled")]
    public TerraformValue<bool> HttpsTrafficOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "https_traffic_only_enabled");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("infrastructure_encryption_enabled")]
    public TerraformValue<bool> InfrastructureEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "infrastructure_encryption_enabled");
    }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformArgument("is_hns_enabled")]
    public TerraformValue<bool> IsHnsEnabled
    {
        get => new TerraformReference<bool>(this, "is_hns_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformArgument("nfsv3_enabled")]
    public TerraformValue<bool> Nfsv3Enabled
    {
        get => new TerraformReference<bool>(this, "nfsv3_enabled");
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformArgument("primary_access_key")]
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_blob_connection_string")]
    public TerraformValue<string> PrimaryBlobConnectionString
    {
        get => new TerraformReference<string>(this, "primary_blob_connection_string");
    }

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_blob_endpoint")]
    public TerraformValue<string> PrimaryBlobEndpoint
    {
        get => new TerraformReference<string>(this, "primary_blob_endpoint");
    }

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    [TerraformArgument("primary_blob_host")]
    public TerraformValue<string> PrimaryBlobHost
    {
        get => new TerraformReference<string>(this, "primary_blob_host");
    }

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_blob_internet_endpoint")]
    public TerraformValue<string> PrimaryBlobInternetEndpoint
    {
        get => new TerraformReference<string>(this, "primary_blob_internet_endpoint");
    }

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    [TerraformArgument("primary_blob_internet_host")]
    public TerraformValue<string> PrimaryBlobInternetHost
    {
        get => new TerraformReference<string>(this, "primary_blob_internet_host");
    }

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_blob_microsoft_endpoint")]
    public TerraformValue<string> PrimaryBlobMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "primary_blob_microsoft_endpoint");
    }

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("primary_blob_microsoft_host")]
    public TerraformValue<string> PrimaryBlobMicrosoftHost
    {
        get => new TerraformReference<string>(this, "primary_blob_microsoft_host");
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_connection_string")]
    public TerraformValue<string> PrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "primary_connection_string");
    }

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_dfs_endpoint")]
    public TerraformValue<string> PrimaryDfsEndpoint
    {
        get => new TerraformReference<string>(this, "primary_dfs_endpoint");
    }

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    [TerraformArgument("primary_dfs_host")]
    public TerraformValue<string> PrimaryDfsHost
    {
        get => new TerraformReference<string>(this, "primary_dfs_host");
    }

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_dfs_internet_endpoint")]
    public TerraformValue<string> PrimaryDfsInternetEndpoint
    {
        get => new TerraformReference<string>(this, "primary_dfs_internet_endpoint");
    }

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    [TerraformArgument("primary_dfs_internet_host")]
    public TerraformValue<string> PrimaryDfsInternetHost
    {
        get => new TerraformReference<string>(this, "primary_dfs_internet_host");
    }

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_dfs_microsoft_endpoint")]
    public TerraformValue<string> PrimaryDfsMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "primary_dfs_microsoft_endpoint");
    }

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("primary_dfs_microsoft_host")]
    public TerraformValue<string> PrimaryDfsMicrosoftHost
    {
        get => new TerraformReference<string>(this, "primary_dfs_microsoft_host");
    }

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_file_endpoint")]
    public TerraformValue<string> PrimaryFileEndpoint
    {
        get => new TerraformReference<string>(this, "primary_file_endpoint");
    }

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    [TerraformArgument("primary_file_host")]
    public TerraformValue<string> PrimaryFileHost
    {
        get => new TerraformReference<string>(this, "primary_file_host");
    }

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_file_internet_endpoint")]
    public TerraformValue<string> PrimaryFileInternetEndpoint
    {
        get => new TerraformReference<string>(this, "primary_file_internet_endpoint");
    }

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    [TerraformArgument("primary_file_internet_host")]
    public TerraformValue<string> PrimaryFileInternetHost
    {
        get => new TerraformReference<string>(this, "primary_file_internet_host");
    }

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_file_microsoft_endpoint")]
    public TerraformValue<string> PrimaryFileMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "primary_file_microsoft_endpoint");
    }

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("primary_file_microsoft_host")]
    public TerraformValue<string> PrimaryFileMicrosoftHost
    {
        get => new TerraformReference<string>(this, "primary_file_microsoft_host");
    }

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    [TerraformArgument("primary_location")]
    public TerraformValue<string> PrimaryLocation
    {
        get => new TerraformReference<string>(this, "primary_location");
    }

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_queue_endpoint")]
    public TerraformValue<string> PrimaryQueueEndpoint
    {
        get => new TerraformReference<string>(this, "primary_queue_endpoint");
    }

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    [TerraformArgument("primary_queue_host")]
    public TerraformValue<string> PrimaryQueueHost
    {
        get => new TerraformReference<string>(this, "primary_queue_host");
    }

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_queue_microsoft_endpoint")]
    public TerraformValue<string> PrimaryQueueMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "primary_queue_microsoft_endpoint");
    }

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("primary_queue_microsoft_host")]
    public TerraformValue<string> PrimaryQueueMicrosoftHost
    {
        get => new TerraformReference<string>(this, "primary_queue_microsoft_host");
    }

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_table_endpoint")]
    public TerraformValue<string> PrimaryTableEndpoint
    {
        get => new TerraformReference<string>(this, "primary_table_endpoint");
    }

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    [TerraformArgument("primary_table_host")]
    public TerraformValue<string> PrimaryTableHost
    {
        get => new TerraformReference<string>(this, "primary_table_host");
    }

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_table_microsoft_endpoint")]
    public TerraformValue<string> PrimaryTableMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "primary_table_microsoft_endpoint");
    }

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("primary_table_microsoft_host")]
    public TerraformValue<string> PrimaryTableMicrosoftHost
    {
        get => new TerraformReference<string>(this, "primary_table_microsoft_host");
    }

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_web_endpoint")]
    public TerraformValue<string> PrimaryWebEndpoint
    {
        get => new TerraformReference<string>(this, "primary_web_endpoint");
    }

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    [TerraformArgument("primary_web_host")]
    public TerraformValue<string> PrimaryWebHost
    {
        get => new TerraformReference<string>(this, "primary_web_host");
    }

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_web_internet_endpoint")]
    public TerraformValue<string> PrimaryWebInternetEndpoint
    {
        get => new TerraformReference<string>(this, "primary_web_internet_endpoint");
    }

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    [TerraformArgument("primary_web_internet_host")]
    public TerraformValue<string> PrimaryWebInternetHost
    {
        get => new TerraformReference<string>(this, "primary_web_internet_host");
    }

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("primary_web_microsoft_endpoint")]
    public TerraformValue<string> PrimaryWebMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "primary_web_microsoft_endpoint");
    }

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("primary_web_microsoft_host")]
    public TerraformValue<string> PrimaryWebMicrosoftHost
    {
        get => new TerraformReference<string>(this, "primary_web_microsoft_host");
    }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformArgument("queue_encryption_key_type")]
    public TerraformValue<string> QueueEncryptionKeyType
    {
        get => new TerraformReference<string>(this, "queue_encryption_key_type");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformArgument("secondary_access_key")]
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_blob_connection_string")]
    public TerraformValue<string> SecondaryBlobConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_blob_connection_string");
    }

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_blob_endpoint")]
    public TerraformValue<string> SecondaryBlobEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_blob_endpoint");
    }

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    [TerraformArgument("secondary_blob_host")]
    public TerraformValue<string> SecondaryBlobHost
    {
        get => new TerraformReference<string>(this, "secondary_blob_host");
    }

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_blob_internet_endpoint")]
    public TerraformValue<string> SecondaryBlobInternetEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_blob_internet_endpoint");
    }

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    [TerraformArgument("secondary_blob_internet_host")]
    public TerraformValue<string> SecondaryBlobInternetHost
    {
        get => new TerraformReference<string>(this, "secondary_blob_internet_host");
    }

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_blob_microsoft_endpoint")]
    public TerraformValue<string> SecondaryBlobMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_blob_microsoft_endpoint");
    }

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("secondary_blob_microsoft_host")]
    public TerraformValue<string> SecondaryBlobMicrosoftHost
    {
        get => new TerraformReference<string>(this, "secondary_blob_microsoft_host");
    }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_connection_string")]
    public TerraformValue<string> SecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_connection_string");
    }

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_dfs_endpoint")]
    public TerraformValue<string> SecondaryDfsEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_dfs_endpoint");
    }

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    [TerraformArgument("secondary_dfs_host")]
    public TerraformValue<string> SecondaryDfsHost
    {
        get => new TerraformReference<string>(this, "secondary_dfs_host");
    }

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_dfs_internet_endpoint")]
    public TerraformValue<string> SecondaryDfsInternetEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_dfs_internet_endpoint");
    }

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    [TerraformArgument("secondary_dfs_internet_host")]
    public TerraformValue<string> SecondaryDfsInternetHost
    {
        get => new TerraformReference<string>(this, "secondary_dfs_internet_host");
    }

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_dfs_microsoft_endpoint")]
    public TerraformValue<string> SecondaryDfsMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_dfs_microsoft_endpoint");
    }

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("secondary_dfs_microsoft_host")]
    public TerraformValue<string> SecondaryDfsMicrosoftHost
    {
        get => new TerraformReference<string>(this, "secondary_dfs_microsoft_host");
    }

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_file_endpoint")]
    public TerraformValue<string> SecondaryFileEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_file_endpoint");
    }

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    [TerraformArgument("secondary_file_host")]
    public TerraformValue<string> SecondaryFileHost
    {
        get => new TerraformReference<string>(this, "secondary_file_host");
    }

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_file_internet_endpoint")]
    public TerraformValue<string> SecondaryFileInternetEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_file_internet_endpoint");
    }

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    [TerraformArgument("secondary_file_internet_host")]
    public TerraformValue<string> SecondaryFileInternetHost
    {
        get => new TerraformReference<string>(this, "secondary_file_internet_host");
    }

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_file_microsoft_endpoint")]
    public TerraformValue<string> SecondaryFileMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_file_microsoft_endpoint");
    }

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("secondary_file_microsoft_host")]
    public TerraformValue<string> SecondaryFileMicrosoftHost
    {
        get => new TerraformReference<string>(this, "secondary_file_microsoft_host");
    }

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    [TerraformArgument("secondary_location")]
    public TerraformValue<string> SecondaryLocation
    {
        get => new TerraformReference<string>(this, "secondary_location");
    }

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_queue_endpoint")]
    public TerraformValue<string> SecondaryQueueEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_queue_endpoint");
    }

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    [TerraformArgument("secondary_queue_host")]
    public TerraformValue<string> SecondaryQueueHost
    {
        get => new TerraformReference<string>(this, "secondary_queue_host");
    }

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_queue_microsoft_endpoint")]
    public TerraformValue<string> SecondaryQueueMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_queue_microsoft_endpoint");
    }

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("secondary_queue_microsoft_host")]
    public TerraformValue<string> SecondaryQueueMicrosoftHost
    {
        get => new TerraformReference<string>(this, "secondary_queue_microsoft_host");
    }

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_table_endpoint")]
    public TerraformValue<string> SecondaryTableEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_table_endpoint");
    }

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    [TerraformArgument("secondary_table_host")]
    public TerraformValue<string> SecondaryTableHost
    {
        get => new TerraformReference<string>(this, "secondary_table_host");
    }

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_table_microsoft_endpoint")]
    public TerraformValue<string> SecondaryTableMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_table_microsoft_endpoint");
    }

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("secondary_table_microsoft_host")]
    public TerraformValue<string> SecondaryTableMicrosoftHost
    {
        get => new TerraformReference<string>(this, "secondary_table_microsoft_host");
    }

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_web_endpoint")]
    public TerraformValue<string> SecondaryWebEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_web_endpoint");
    }

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    [TerraformArgument("secondary_web_host")]
    public TerraformValue<string> SecondaryWebHost
    {
        get => new TerraformReference<string>(this, "secondary_web_host");
    }

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_web_internet_endpoint")]
    public TerraformValue<string> SecondaryWebInternetEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_web_internet_endpoint");
    }

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    [TerraformArgument("secondary_web_internet_host")]
    public TerraformValue<string> SecondaryWebInternetHost
    {
        get => new TerraformReference<string>(this, "secondary_web_internet_host");
    }

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformArgument("secondary_web_microsoft_endpoint")]
    public TerraformValue<string> SecondaryWebMicrosoftEndpoint
    {
        get => new TerraformReference<string>(this, "secondary_web_microsoft_endpoint");
    }

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    [TerraformArgument("secondary_web_microsoft_host")]
    public TerraformValue<string> SecondaryWebMicrosoftHost
    {
        get => new TerraformReference<string>(this, "secondary_web_microsoft_host");
    }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformArgument("table_encryption_key_type")]
    public TerraformValue<string> TableEncryptionKeyType
    {
        get => new TerraformReference<string>(this, "table_encryption_key_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
