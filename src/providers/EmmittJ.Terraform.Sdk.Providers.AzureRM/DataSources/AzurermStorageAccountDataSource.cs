using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageAccountDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformPropertyName("access_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_tier");

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformPropertyName("account_kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountKind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_kind");

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [TerraformPropertyName("account_replication_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountReplicationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_replication_type");

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [TerraformPropertyName("account_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_tier");

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformPropertyName("allow_nested_items_to_be_public")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowNestedItemsToBePublic => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_nested_items_to_be_public");

    /// <summary>
    /// The azure_files_authentication attribute.
    /// </summary>
    [TerraformPropertyName("azure_files_authentication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AzureFilesAuthentication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "azure_files_authentication");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomDomain => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "custom_domain");

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("dns_endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsEndpointType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_endpoint_type");

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("https_traffic_only_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HttpsTrafficOnlyEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "https_traffic_only_enabled");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_encryption_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> InfrastructureEncryptionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "infrastructure_encryption_enabled");

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_hns_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsHnsEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_hns_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformPropertyName("nfsv3_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Nfsv3Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "nfsv3_enabled");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_access_key");

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryBlobConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_blob_connection_string");

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryBlobEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_blob_endpoint");

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryBlobHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_blob_host");

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryBlobInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_blob_internet_endpoint");

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryBlobInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_blob_internet_host");

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryBlobMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_blob_microsoft_endpoint");

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_blob_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryBlobMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_blob_microsoft_host");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string");

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryDfsEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_dfs_endpoint");

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryDfsHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_dfs_host");

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryDfsInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_dfs_internet_endpoint");

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryDfsInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_dfs_internet_host");

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryDfsMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_dfs_microsoft_endpoint");

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_dfs_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryDfsMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_dfs_microsoft_host");

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryFileEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_file_endpoint");

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryFileHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_file_host");

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryFileInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_file_internet_endpoint");

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryFileInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_file_internet_host");

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryFileMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_file_microsoft_endpoint");

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_file_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryFileMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_file_microsoft_host");

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    [TerraformPropertyName("primary_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_location");

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryQueueEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_queue_endpoint");

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryQueueHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_queue_host");

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryQueueMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_queue_microsoft_endpoint");

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_queue_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryQueueMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_queue_microsoft_host");

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryTableEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_table_endpoint");

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryTableHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_table_host");

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryTableMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_table_microsoft_endpoint");

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_table_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryTableMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_table_microsoft_host");

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryWebEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_web_endpoint");

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryWebHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_web_host");

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryWebInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_web_internet_endpoint");

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryWebInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_web_internet_host");

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryWebMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_web_microsoft_endpoint");

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("primary_web_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryWebMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_web_microsoft_host");

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("queue_encryption_key_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QueueEncryptionKeyType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "queue_encryption_key_type");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_access_key");

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryBlobConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_blob_connection_string");

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryBlobEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_blob_endpoint");

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryBlobHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_blob_host");

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryBlobInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_blob_internet_endpoint");

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryBlobInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_blob_internet_host");

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryBlobMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_blob_microsoft_endpoint");

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_blob_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryBlobMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_blob_microsoft_host");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string");

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryDfsEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_dfs_endpoint");

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryDfsHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_dfs_host");

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryDfsInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_dfs_internet_endpoint");

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryDfsInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_dfs_internet_host");

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryDfsMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_dfs_microsoft_endpoint");

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_dfs_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryDfsMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_dfs_microsoft_host");

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryFileEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_file_endpoint");

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryFileHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_file_host");

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryFileInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_file_internet_endpoint");

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryFileInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_file_internet_host");

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryFileMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_file_microsoft_endpoint");

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_file_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryFileMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_file_microsoft_host");

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    [TerraformPropertyName("secondary_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_location");

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryQueueEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_queue_endpoint");

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryQueueHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_queue_host");

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryQueueMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_queue_microsoft_endpoint");

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_queue_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryQueueMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_queue_microsoft_host");

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryTableEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_table_endpoint");

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryTableHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_table_host");

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryTableMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_table_microsoft_endpoint");

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_table_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryTableMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_table_microsoft_host");

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryWebEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_web_endpoint");

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryWebHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_web_host");

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_internet_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryWebInternetEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_web_internet_endpoint");

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_internet_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryWebInternetHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_web_internet_host");

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_microsoft_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryWebMicrosoftEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_web_microsoft_endpoint");

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    [TerraformPropertyName("secondary_web_microsoft_host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryWebMicrosoftHost => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_web_microsoft_host");

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("table_encryption_key_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TableEncryptionKeyType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "table_encryption_key_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
