using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageAccountDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_storage_account Terraform data source.
/// Retrieves information about a azurerm_storage_account.
/// </summary>
public partial class AzurermStorageAccountDataSource(string name) : TerraformDataSource("azurerm_storage_account", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformValue<string> AccessTier
        => CreateReference("access_tier");

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public TerraformValue<string> AccountKind
        => CreateReference("account_kind");

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    public TerraformValue<string> AccountReplicationType
        => CreateReference("account_replication_type");

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    public TerraformValue<string> AccountTier
        => CreateReference("account_tier");

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public TerraformValue<bool> AllowNestedItemsToBePublic
        => CreateReference("allow_nested_items_to_be_public");

    /// <summary>
    /// The azure_files_authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureFilesAuthentication
        => CreateReference("azure_files_authentication");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomDomain
        => CreateReference("custom_domain");

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> DnsEndpointType
        => CreateReference("dns_endpoint_type");

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HttpsTrafficOnlyEnabled
        => CreateReference("https_traffic_only_enabled");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InfrastructureEncryptionEnabled
        => CreateReference("infrastructure_encryption_enabled");

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IsHnsEnabled
        => CreateReference("is_hns_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Nfsv3Enabled
        => CreateReference("nfsv3_enabled");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => CreateReference("primary_access_key");

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobConnectionString
        => CreateReference("primary_blob_connection_string");

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobEndpoint
        => CreateReference("primary_blob_endpoint");

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobHost
        => CreateReference("primary_blob_host");

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobInternetEndpoint
        => CreateReference("primary_blob_internet_endpoint");

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobInternetHost
        => CreateReference("primary_blob_internet_host");

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobMicrosoftEndpoint
        => CreateReference("primary_blob_microsoft_endpoint");

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobMicrosoftHost
        => CreateReference("primary_blob_microsoft_host");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => CreateReference("primary_connection_string");

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsEndpoint
        => CreateReference("primary_dfs_endpoint");

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsHost
        => CreateReference("primary_dfs_host");

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsInternetEndpoint
        => CreateReference("primary_dfs_internet_endpoint");

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsInternetHost
        => CreateReference("primary_dfs_internet_host");

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsMicrosoftEndpoint
        => CreateReference("primary_dfs_microsoft_endpoint");

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsMicrosoftHost
        => CreateReference("primary_dfs_microsoft_host");

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileEndpoint
        => CreateReference("primary_file_endpoint");

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileHost
        => CreateReference("primary_file_host");

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileInternetEndpoint
        => CreateReference("primary_file_internet_endpoint");

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileInternetHost
        => CreateReference("primary_file_internet_host");

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileMicrosoftEndpoint
        => CreateReference("primary_file_microsoft_endpoint");

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileMicrosoftHost
        => CreateReference("primary_file_microsoft_host");

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    public TerraformValue<string> PrimaryLocation
        => CreateReference("primary_location");

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueEndpoint
        => CreateReference("primary_queue_endpoint");

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueHost
        => CreateReference("primary_queue_host");

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueMicrosoftEndpoint
        => CreateReference("primary_queue_microsoft_endpoint");

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueMicrosoftHost
        => CreateReference("primary_queue_microsoft_host");

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableEndpoint
        => CreateReference("primary_table_endpoint");

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableHost
        => CreateReference("primary_table_host");

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableMicrosoftEndpoint
        => CreateReference("primary_table_microsoft_endpoint");

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableMicrosoftHost
        => CreateReference("primary_table_microsoft_host");

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebEndpoint
        => CreateReference("primary_web_endpoint");

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebHost
        => CreateReference("primary_web_host");

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebInternetEndpoint
        => CreateReference("primary_web_internet_endpoint");

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebInternetHost
        => CreateReference("primary_web_internet_host");

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebMicrosoftEndpoint
        => CreateReference("primary_web_microsoft_endpoint");

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebMicrosoftHost
        => CreateReference("primary_web_microsoft_host");

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string> QueueEncryptionKeyType
        => CreateReference("queue_encryption_key_type");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => CreateReference("secondary_access_key");

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobConnectionString
        => CreateReference("secondary_blob_connection_string");

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobEndpoint
        => CreateReference("secondary_blob_endpoint");

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobHost
        => CreateReference("secondary_blob_host");

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobInternetEndpoint
        => CreateReference("secondary_blob_internet_endpoint");

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobInternetHost
        => CreateReference("secondary_blob_internet_host");

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobMicrosoftEndpoint
        => CreateReference("secondary_blob_microsoft_endpoint");

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobMicrosoftHost
        => CreateReference("secondary_blob_microsoft_host");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => CreateReference("secondary_connection_string");

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsEndpoint
        => CreateReference("secondary_dfs_endpoint");

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsHost
        => CreateReference("secondary_dfs_host");

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsInternetEndpoint
        => CreateReference("secondary_dfs_internet_endpoint");

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsInternetHost
        => CreateReference("secondary_dfs_internet_host");

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsMicrosoftEndpoint
        => CreateReference("secondary_dfs_microsoft_endpoint");

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsMicrosoftHost
        => CreateReference("secondary_dfs_microsoft_host");

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileEndpoint
        => CreateReference("secondary_file_endpoint");

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileHost
        => CreateReference("secondary_file_host");

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileInternetEndpoint
        => CreateReference("secondary_file_internet_endpoint");

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileInternetHost
        => CreateReference("secondary_file_internet_host");

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileMicrosoftEndpoint
        => CreateReference("secondary_file_microsoft_endpoint");

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileMicrosoftHost
        => CreateReference("secondary_file_microsoft_host");

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    public TerraformValue<string> SecondaryLocation
        => CreateReference("secondary_location");

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueEndpoint
        => CreateReference("secondary_queue_endpoint");

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueHost
        => CreateReference("secondary_queue_host");

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueMicrosoftEndpoint
        => CreateReference("secondary_queue_microsoft_endpoint");

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueMicrosoftHost
        => CreateReference("secondary_queue_microsoft_host");

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableEndpoint
        => CreateReference("secondary_table_endpoint");

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableHost
        => CreateReference("secondary_table_host");

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableMicrosoftEndpoint
        => CreateReference("secondary_table_microsoft_endpoint");

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableMicrosoftHost
        => CreateReference("secondary_table_microsoft_host");

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebEndpoint
        => CreateReference("secondary_web_endpoint");

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebHost
        => CreateReference("secondary_web_host");

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebInternetEndpoint
        => CreateReference("secondary_web_internet_endpoint");

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebInternetHost
        => CreateReference("secondary_web_internet_host");

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebMicrosoftEndpoint
        => CreateReference("secondary_web_microsoft_endpoint");

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebMicrosoftHost
        => CreateReference("secondary_web_microsoft_host");

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string> TableEncryptionKeyType
        => CreateReference("table_encryption_key_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
