using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinTlsVersion { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageAccountDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformPropertyName("access_tier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessTier => new TerraformReference(this, "access_tier");

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformPropertyName("account_kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccountKind => new TerraformReference(this, "account_kind");

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [TerraformPropertyName("account_replication_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccountReplicationType => new TerraformReference(this, "account_replication_type");

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [TerraformPropertyName("account_tier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccountTier => new TerraformReference(this, "account_tier");

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformPropertyName("allow_nested_items_to_be_public")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowNestedItemsToBePublic => new TerraformReference(this, "allow_nested_items_to_be_public");

    /// <summary>
    /// The azure_files_authentication attribute.
    /// </summary>
    [TerraformPropertyName("azure_files_authentication")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AzureFilesAuthentication => new TerraformReference(this, "azure_files_authentication");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomDomain => new TerraformReference(this, "custom_domain");

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("dns_endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsEndpointType => new TerraformReference(this, "dns_endpoint_type");

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("https_traffic_only_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HttpsTrafficOnlyEnabled => new TerraformReference(this, "https_traffic_only_enabled");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> InfrastructureEncryptionEnabled => new TerraformReference(this, "infrastructure_encryption_enabled");

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_hns_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsHnsEnabled => new TerraformReference(this, "is_hns_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformPropertyName("nfsv3_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Nfsv3Enabled => new TerraformReference(this, "nfsv3_enabled");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAccessKey => new TerraformReference(this, "primary_access_key");

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryBlobConnectionString => new TerraformReference(this, "primary_blob_connection_string");

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryBlobEndpoint => new TerraformReference(this, "primary_blob_endpoint");

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryBlobHost => new TerraformReference(this, "primary_blob_host");

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryBlobInternetEndpoint => new TerraformReference(this, "primary_blob_internet_endpoint");

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryBlobInternetHost => new TerraformReference(this, "primary_blob_internet_host");

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryBlobMicrosoftEndpoint => new TerraformReference(this, "primary_blob_microsoft_endpoint");

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryBlobMicrosoftHost => new TerraformReference(this, "primary_blob_microsoft_host");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryConnectionString => new TerraformReference(this, "primary_connection_string");

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryDfsEndpoint => new TerraformReference(this, "primary_dfs_endpoint");

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryDfsHost => new TerraformReference(this, "primary_dfs_host");

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryDfsInternetEndpoint => new TerraformReference(this, "primary_dfs_internet_endpoint");

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryDfsInternetHost => new TerraformReference(this, "primary_dfs_internet_host");

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryDfsMicrosoftEndpoint => new TerraformReference(this, "primary_dfs_microsoft_endpoint");

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryDfsMicrosoftHost => new TerraformReference(this, "primary_dfs_microsoft_host");

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryFileEndpoint => new TerraformReference(this, "primary_file_endpoint");

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryFileHost => new TerraformReference(this, "primary_file_host");

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryFileInternetEndpoint => new TerraformReference(this, "primary_file_internet_endpoint");

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryFileInternetHost => new TerraformReference(this, "primary_file_internet_host");

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryFileMicrosoftEndpoint => new TerraformReference(this, "primary_file_microsoft_endpoint");

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryFileMicrosoftHost => new TerraformReference(this, "primary_file_microsoft_host");

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    [TerraformPropertyName("primary_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryLocation => new TerraformReference(this, "primary_location");

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryQueueEndpoint => new TerraformReference(this, "primary_queue_endpoint");

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryQueueHost => new TerraformReference(this, "primary_queue_host");

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryQueueMicrosoftEndpoint => new TerraformReference(this, "primary_queue_microsoft_endpoint");

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryQueueMicrosoftHost => new TerraformReference(this, "primary_queue_microsoft_host");

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryTableEndpoint => new TerraformReference(this, "primary_table_endpoint");

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryTableHost => new TerraformReference(this, "primary_table_host");

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryTableMicrosoftEndpoint => new TerraformReference(this, "primary_table_microsoft_endpoint");

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryTableMicrosoftHost => new TerraformReference(this, "primary_table_microsoft_host");

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryWebEndpoint => new TerraformReference(this, "primary_web_endpoint");

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryWebHost => new TerraformReference(this, "primary_web_host");

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryWebInternetEndpoint => new TerraformReference(this, "primary_web_internet_endpoint");

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryWebInternetHost => new TerraformReference(this, "primary_web_internet_host");

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryWebMicrosoftEndpoint => new TerraformReference(this, "primary_web_microsoft_endpoint");

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryWebMicrosoftHost => new TerraformReference(this, "primary_web_microsoft_host");

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("queue_encryption_key_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> QueueEncryptionKeyType => new TerraformReference(this, "queue_encryption_key_type");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAccessKey => new TerraformReference(this, "secondary_access_key");

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryBlobConnectionString => new TerraformReference(this, "secondary_blob_connection_string");

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryBlobEndpoint => new TerraformReference(this, "secondary_blob_endpoint");

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryBlobHost => new TerraformReference(this, "secondary_blob_host");

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryBlobInternetEndpoint => new TerraformReference(this, "secondary_blob_internet_endpoint");

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryBlobInternetHost => new TerraformReference(this, "secondary_blob_internet_host");

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryBlobMicrosoftEndpoint => new TerraformReference(this, "secondary_blob_microsoft_endpoint");

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryBlobMicrosoftHost => new TerraformReference(this, "secondary_blob_microsoft_host");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryConnectionString => new TerraformReference(this, "secondary_connection_string");

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryDfsEndpoint => new TerraformReference(this, "secondary_dfs_endpoint");

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryDfsHost => new TerraformReference(this, "secondary_dfs_host");

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryDfsInternetEndpoint => new TerraformReference(this, "secondary_dfs_internet_endpoint");

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryDfsInternetHost => new TerraformReference(this, "secondary_dfs_internet_host");

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryDfsMicrosoftEndpoint => new TerraformReference(this, "secondary_dfs_microsoft_endpoint");

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryDfsMicrosoftHost => new TerraformReference(this, "secondary_dfs_microsoft_host");

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryFileEndpoint => new TerraformReference(this, "secondary_file_endpoint");

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryFileHost => new TerraformReference(this, "secondary_file_host");

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryFileInternetEndpoint => new TerraformReference(this, "secondary_file_internet_endpoint");

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryFileInternetHost => new TerraformReference(this, "secondary_file_internet_host");

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryFileMicrosoftEndpoint => new TerraformReference(this, "secondary_file_microsoft_endpoint");

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryFileMicrosoftHost => new TerraformReference(this, "secondary_file_microsoft_host");

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    [TerraformPropertyName("secondary_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryLocation => new TerraformReference(this, "secondary_location");

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryQueueEndpoint => new TerraformReference(this, "secondary_queue_endpoint");

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryQueueHost => new TerraformReference(this, "secondary_queue_host");

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryQueueMicrosoftEndpoint => new TerraformReference(this, "secondary_queue_microsoft_endpoint");

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryQueueMicrosoftHost => new TerraformReference(this, "secondary_queue_microsoft_host");

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryTableEndpoint => new TerraformReference(this, "secondary_table_endpoint");

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryTableHost => new TerraformReference(this, "secondary_table_host");

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryTableMicrosoftEndpoint => new TerraformReference(this, "secondary_table_microsoft_endpoint");

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryTableMicrosoftHost => new TerraformReference(this, "secondary_table_microsoft_host");

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryWebEndpoint => new TerraformReference(this, "secondary_web_endpoint");

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryWebHost => new TerraformReference(this, "secondary_web_host");

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryWebInternetEndpoint => new TerraformReference(this, "secondary_web_internet_endpoint");

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryWebInternetHost => new TerraformReference(this, "secondary_web_internet_host");

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryWebMicrosoftEndpoint => new TerraformReference(this, "secondary_web_microsoft_endpoint");

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryWebMicrosoftHost => new TerraformReference(this, "secondary_web_microsoft_host");

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("table_encryption_key_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TableEncryptionKeyType => new TerraformReference(this, "table_encryption_key_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
