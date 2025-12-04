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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformValue<string> AccessTier
        => AsReference("access_tier");

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public TerraformValue<string> AccountKind
        => AsReference("account_kind");

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    public TerraformValue<string> AccountReplicationType
        => AsReference("account_replication_type");

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    public TerraformValue<string> AccountTier
        => AsReference("account_tier");

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public TerraformValue<bool> AllowNestedItemsToBePublic
        => AsReference("allow_nested_items_to_be_public");

    /// <summary>
    /// The azure_files_authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureFilesAuthentication
        => AsReference("azure_files_authentication");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomDomain
        => AsReference("custom_domain");

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> DnsEndpointType
        => AsReference("dns_endpoint_type");

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HttpsTrafficOnlyEnabled
        => AsReference("https_traffic_only_enabled");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InfrastructureEncryptionEnabled
        => AsReference("infrastructure_encryption_enabled");

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IsHnsEnabled
        => AsReference("is_hns_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Nfsv3Enabled
        => AsReference("nfsv3_enabled");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobConnectionString
        => AsReference("primary_blob_connection_string");

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobEndpoint
        => AsReference("primary_blob_endpoint");

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobHost
        => AsReference("primary_blob_host");

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobInternetEndpoint
        => AsReference("primary_blob_internet_endpoint");

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobInternetHost
        => AsReference("primary_blob_internet_host");

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobMicrosoftEndpoint
        => AsReference("primary_blob_microsoft_endpoint");

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobMicrosoftHost
        => AsReference("primary_blob_microsoft_host");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsEndpoint
        => AsReference("primary_dfs_endpoint");

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsHost
        => AsReference("primary_dfs_host");

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsInternetEndpoint
        => AsReference("primary_dfs_internet_endpoint");

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsInternetHost
        => AsReference("primary_dfs_internet_host");

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsMicrosoftEndpoint
        => AsReference("primary_dfs_microsoft_endpoint");

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsMicrosoftHost
        => AsReference("primary_dfs_microsoft_host");

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileEndpoint
        => AsReference("primary_file_endpoint");

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileHost
        => AsReference("primary_file_host");

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileInternetEndpoint
        => AsReference("primary_file_internet_endpoint");

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileInternetHost
        => AsReference("primary_file_internet_host");

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileMicrosoftEndpoint
        => AsReference("primary_file_microsoft_endpoint");

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileMicrosoftHost
        => AsReference("primary_file_microsoft_host");

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    public TerraformValue<string> PrimaryLocation
        => AsReference("primary_location");

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueEndpoint
        => AsReference("primary_queue_endpoint");

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueHost
        => AsReference("primary_queue_host");

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueMicrosoftEndpoint
        => AsReference("primary_queue_microsoft_endpoint");

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueMicrosoftHost
        => AsReference("primary_queue_microsoft_host");

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableEndpoint
        => AsReference("primary_table_endpoint");

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableHost
        => AsReference("primary_table_host");

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableMicrosoftEndpoint
        => AsReference("primary_table_microsoft_endpoint");

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableMicrosoftHost
        => AsReference("primary_table_microsoft_host");

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebEndpoint
        => AsReference("primary_web_endpoint");

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebHost
        => AsReference("primary_web_host");

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebInternetEndpoint
        => AsReference("primary_web_internet_endpoint");

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebInternetHost
        => AsReference("primary_web_internet_host");

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebMicrosoftEndpoint
        => AsReference("primary_web_microsoft_endpoint");

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebMicrosoftHost
        => AsReference("primary_web_microsoft_host");

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string> QueueEncryptionKeyType
        => AsReference("queue_encryption_key_type");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobConnectionString
        => AsReference("secondary_blob_connection_string");

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobEndpoint
        => AsReference("secondary_blob_endpoint");

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobHost
        => AsReference("secondary_blob_host");

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobInternetEndpoint
        => AsReference("secondary_blob_internet_endpoint");

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobInternetHost
        => AsReference("secondary_blob_internet_host");

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobMicrosoftEndpoint
        => AsReference("secondary_blob_microsoft_endpoint");

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobMicrosoftHost
        => AsReference("secondary_blob_microsoft_host");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsEndpoint
        => AsReference("secondary_dfs_endpoint");

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsHost
        => AsReference("secondary_dfs_host");

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsInternetEndpoint
        => AsReference("secondary_dfs_internet_endpoint");

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsInternetHost
        => AsReference("secondary_dfs_internet_host");

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsMicrosoftEndpoint
        => AsReference("secondary_dfs_microsoft_endpoint");

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsMicrosoftHost
        => AsReference("secondary_dfs_microsoft_host");

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileEndpoint
        => AsReference("secondary_file_endpoint");

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileHost
        => AsReference("secondary_file_host");

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileInternetEndpoint
        => AsReference("secondary_file_internet_endpoint");

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileInternetHost
        => AsReference("secondary_file_internet_host");

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileMicrosoftEndpoint
        => AsReference("secondary_file_microsoft_endpoint");

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileMicrosoftHost
        => AsReference("secondary_file_microsoft_host");

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    public TerraformValue<string> SecondaryLocation
        => AsReference("secondary_location");

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueEndpoint
        => AsReference("secondary_queue_endpoint");

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueHost
        => AsReference("secondary_queue_host");

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueMicrosoftEndpoint
        => AsReference("secondary_queue_microsoft_endpoint");

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueMicrosoftHost
        => AsReference("secondary_queue_microsoft_host");

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableEndpoint
        => AsReference("secondary_table_endpoint");

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableHost
        => AsReference("secondary_table_host");

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableMicrosoftEndpoint
        => AsReference("secondary_table_microsoft_endpoint");

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableMicrosoftHost
        => AsReference("secondary_table_microsoft_host");

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebEndpoint
        => AsReference("secondary_web_endpoint");

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebHost
        => AsReference("secondary_web_host");

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebInternetEndpoint
        => AsReference("secondary_web_internet_endpoint");

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebInternetHost
        => AsReference("secondary_web_internet_host");

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebMicrosoftEndpoint
        => AsReference("secondary_web_microsoft_endpoint");

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebMicrosoftHost
        => AsReference("secondary_web_microsoft_host");

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string> TableEncryptionKeyType
        => AsReference("table_encryption_key_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
