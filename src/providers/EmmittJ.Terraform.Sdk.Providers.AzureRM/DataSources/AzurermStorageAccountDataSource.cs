using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageAccountDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_storage_account.
/// </summary>
public partial class AzurermStorageAccountDataSource : TerraformDataSource
{
    public AzurermStorageAccountDataSource(string name) : base("azurerm_storage_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformProperty("min_tls_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageAccountDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformProperty("access_tier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessTier { get; }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformProperty("account_kind")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccountKind { get; }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [TerraformProperty("account_replication_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccountReplicationType { get; }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [TerraformProperty("account_tier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccountTier { get; }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformProperty("allow_nested_items_to_be_public")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowNestedItemsToBePublic { get; }

    /// <summary>
    /// The azure_files_authentication attribute.
    /// </summary>
    [TerraformProperty("azure_files_authentication")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AzureFilesAuthentication { get; }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformProperty("custom_domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CustomDomain { get; }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformProperty("dns_endpoint_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsEndpointType { get; }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformProperty("https_traffic_only_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HttpsTrafficOnlyEnabled { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("infrastructure_encryption_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> InfrastructureEncryptionEnabled { get; }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformProperty("is_hns_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsHnsEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformProperty("nfsv3_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Nfsv3Enabled { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_blob_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryBlobConnectionString { get; }

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_blob_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryBlobEndpoint { get; }

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    [TerraformProperty("primary_blob_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryBlobHost { get; }

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_blob_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryBlobInternetEndpoint { get; }

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_blob_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryBlobInternetHost { get; }

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_blob_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryBlobMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_blob_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryBlobMicrosoftHost { get; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryDfsEndpoint { get; }

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryDfsHost { get; }

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryDfsInternetEndpoint { get; }

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryDfsInternetHost { get; }

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryDfsMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryDfsMicrosoftHost { get; }

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_file_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryFileEndpoint { get; }

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    [TerraformProperty("primary_file_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryFileHost { get; }

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_file_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryFileInternetEndpoint { get; }

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_file_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryFileInternetHost { get; }

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_file_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryFileMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_file_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryFileMicrosoftHost { get; }

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    [TerraformProperty("primary_location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryLocation { get; }

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_queue_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryQueueEndpoint { get; }

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    [TerraformProperty("primary_queue_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryQueueHost { get; }

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_queue_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryQueueMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_queue_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryQueueMicrosoftHost { get; }

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_table_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryTableEndpoint { get; }

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    [TerraformProperty("primary_table_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryTableHost { get; }

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_table_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryTableMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_table_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryTableMicrosoftHost { get; }

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_web_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryWebEndpoint { get; }

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    [TerraformProperty("primary_web_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryWebHost { get; }

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_web_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryWebInternetEndpoint { get; }

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_web_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryWebInternetHost { get; }

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_web_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryWebMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_web_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryWebMicrosoftHost { get; }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformProperty("queue_encryption_key_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QueueEncryptionKeyType { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAccessKey { get; }

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryBlobConnectionString { get; }

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryBlobEndpoint { get; }

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryBlobHost { get; }

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryBlobInternetEndpoint { get; }

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryBlobInternetHost { get; }

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryBlobMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryBlobMicrosoftHost { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryDfsEndpoint { get; }

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryDfsHost { get; }

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryDfsInternetEndpoint { get; }

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryDfsInternetHost { get; }

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryDfsMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryDfsMicrosoftHost { get; }

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_file_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryFileEndpoint { get; }

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    [TerraformProperty("secondary_file_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryFileHost { get; }

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_file_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryFileInternetEndpoint { get; }

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_file_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryFileInternetHost { get; }

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_file_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryFileMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_file_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryFileMicrosoftHost { get; }

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    [TerraformProperty("secondary_location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryLocation { get; }

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryQueueEndpoint { get; }

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryQueueHost { get; }

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryQueueMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryQueueMicrosoftHost { get; }

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_table_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryTableEndpoint { get; }

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    [TerraformProperty("secondary_table_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryTableHost { get; }

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_table_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryTableMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_table_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryTableMicrosoftHost { get; }

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_web_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryWebEndpoint { get; }

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    [TerraformProperty("secondary_web_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryWebHost { get; }

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_web_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryWebInternetEndpoint { get; }

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_web_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryWebInternetHost { get; }

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_web_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryWebMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_web_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryWebMicrosoftHost { get; }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformProperty("table_encryption_key_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TableEncryptionKeyType { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
