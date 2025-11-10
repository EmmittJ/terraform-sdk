using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_account.
/// </summary>
public class AzurermStorageAccountDataSource : TerraformDataSource
{
    public AzurermStorageAccountDataSource(string name) : base("azurerm_storage_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_tier");
        this.WithOutput("account_kind");
        this.WithOutput("account_replication_type");
        this.WithOutput("account_tier");
        this.WithOutput("allow_nested_items_to_be_public");
        this.WithOutput("azure_files_authentication");
        this.WithOutput("custom_domain");
        this.WithOutput("dns_endpoint_type");
        this.WithOutput("https_traffic_only_enabled");
        this.WithOutput("identity");
        this.WithOutput("infrastructure_encryption_enabled");
        this.WithOutput("is_hns_enabled");
        this.WithOutput("location");
        this.WithOutput("nfsv3_enabled");
        this.WithOutput("primary_access_key");
        this.WithOutput("primary_blob_connection_string");
        this.WithOutput("primary_blob_endpoint");
        this.WithOutput("primary_blob_host");
        this.WithOutput("primary_blob_internet_endpoint");
        this.WithOutput("primary_blob_internet_host");
        this.WithOutput("primary_blob_microsoft_endpoint");
        this.WithOutput("primary_blob_microsoft_host");
        this.WithOutput("primary_connection_string");
        this.WithOutput("primary_dfs_endpoint");
        this.WithOutput("primary_dfs_host");
        this.WithOutput("primary_dfs_internet_endpoint");
        this.WithOutput("primary_dfs_internet_host");
        this.WithOutput("primary_dfs_microsoft_endpoint");
        this.WithOutput("primary_dfs_microsoft_host");
        this.WithOutput("primary_file_endpoint");
        this.WithOutput("primary_file_host");
        this.WithOutput("primary_file_internet_endpoint");
        this.WithOutput("primary_file_internet_host");
        this.WithOutput("primary_file_microsoft_endpoint");
        this.WithOutput("primary_file_microsoft_host");
        this.WithOutput("primary_location");
        this.WithOutput("primary_queue_endpoint");
        this.WithOutput("primary_queue_host");
        this.WithOutput("primary_queue_microsoft_endpoint");
        this.WithOutput("primary_queue_microsoft_host");
        this.WithOutput("primary_table_endpoint");
        this.WithOutput("primary_table_host");
        this.WithOutput("primary_table_microsoft_endpoint");
        this.WithOutput("primary_table_microsoft_host");
        this.WithOutput("primary_web_endpoint");
        this.WithOutput("primary_web_host");
        this.WithOutput("primary_web_internet_endpoint");
        this.WithOutput("primary_web_internet_host");
        this.WithOutput("primary_web_microsoft_endpoint");
        this.WithOutput("primary_web_microsoft_host");
        this.WithOutput("queue_encryption_key_type");
        this.WithOutput("secondary_access_key");
        this.WithOutput("secondary_blob_connection_string");
        this.WithOutput("secondary_blob_endpoint");
        this.WithOutput("secondary_blob_host");
        this.WithOutput("secondary_blob_internet_endpoint");
        this.WithOutput("secondary_blob_internet_host");
        this.WithOutput("secondary_blob_microsoft_endpoint");
        this.WithOutput("secondary_blob_microsoft_host");
        this.WithOutput("secondary_connection_string");
        this.WithOutput("secondary_dfs_endpoint");
        this.WithOutput("secondary_dfs_host");
        this.WithOutput("secondary_dfs_internet_endpoint");
        this.WithOutput("secondary_dfs_internet_host");
        this.WithOutput("secondary_dfs_microsoft_endpoint");
        this.WithOutput("secondary_dfs_microsoft_host");
        this.WithOutput("secondary_file_endpoint");
        this.WithOutput("secondary_file_host");
        this.WithOutput("secondary_file_internet_endpoint");
        this.WithOutput("secondary_file_internet_host");
        this.WithOutput("secondary_file_microsoft_endpoint");
        this.WithOutput("secondary_file_microsoft_host");
        this.WithOutput("secondary_location");
        this.WithOutput("secondary_queue_endpoint");
        this.WithOutput("secondary_queue_host");
        this.WithOutput("secondary_queue_microsoft_endpoint");
        this.WithOutput("secondary_queue_microsoft_host");
        this.WithOutput("secondary_table_endpoint");
        this.WithOutput("secondary_table_host");
        this.WithOutput("secondary_table_microsoft_endpoint");
        this.WithOutput("secondary_table_microsoft_host");
        this.WithOutput("secondary_web_endpoint");
        this.WithOutput("secondary_web_host");
        this.WithOutput("secondary_web_internet_endpoint");
        this.WithOutput("secondary_web_internet_host");
        this.WithOutput("secondary_web_microsoft_endpoint");
        this.WithOutput("secondary_web_microsoft_host");
        this.WithOutput("table_encryption_key_type");
        this.WithOutput("tags");
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
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_tls_version");
        set => this.WithProperty("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageAccountDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformExpression AccessTier => this["access_tier"];

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public TerraformExpression AccountKind => this["account_kind"];

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    public TerraformExpression AccountReplicationType => this["account_replication_type"];

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    public TerraformExpression AccountTier => this["account_tier"];

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public TerraformExpression AllowNestedItemsToBePublic => this["allow_nested_items_to_be_public"];

    /// <summary>
    /// The azure_files_authentication attribute.
    /// </summary>
    public TerraformExpression AzureFilesAuthentication => this["azure_files_authentication"];

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformExpression CustomDomain => this["custom_domain"];

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public TerraformExpression DnsEndpointType => this["dns_endpoint_type"];

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public TerraformExpression HttpsTrafficOnlyEnabled => this["https_traffic_only_enabled"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformExpression InfrastructureEncryptionEnabled => this["infrastructure_encryption_enabled"];

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public TerraformExpression IsHnsEnabled => this["is_hns_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public TerraformExpression Nfsv3Enabled => this["nfsv3_enabled"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryBlobConnectionString => this["primary_blob_connection_string"];

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryBlobEndpoint => this["primary_blob_endpoint"];

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    public TerraformExpression PrimaryBlobHost => this["primary_blob_host"];

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryBlobInternetEndpoint => this["primary_blob_internet_endpoint"];

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    public TerraformExpression PrimaryBlobInternetHost => this["primary_blob_internet_host"];

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryBlobMicrosoftEndpoint => this["primary_blob_microsoft_endpoint"];

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformExpression PrimaryBlobMicrosoftHost => this["primary_blob_microsoft_host"];

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryDfsEndpoint => this["primary_dfs_endpoint"];

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    public TerraformExpression PrimaryDfsHost => this["primary_dfs_host"];

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryDfsInternetEndpoint => this["primary_dfs_internet_endpoint"];

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    public TerraformExpression PrimaryDfsInternetHost => this["primary_dfs_internet_host"];

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryDfsMicrosoftEndpoint => this["primary_dfs_microsoft_endpoint"];

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformExpression PrimaryDfsMicrosoftHost => this["primary_dfs_microsoft_host"];

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryFileEndpoint => this["primary_file_endpoint"];

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    public TerraformExpression PrimaryFileHost => this["primary_file_host"];

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryFileInternetEndpoint => this["primary_file_internet_endpoint"];

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    public TerraformExpression PrimaryFileInternetHost => this["primary_file_internet_host"];

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryFileMicrosoftEndpoint => this["primary_file_microsoft_endpoint"];

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    public TerraformExpression PrimaryFileMicrosoftHost => this["primary_file_microsoft_host"];

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    public TerraformExpression PrimaryLocation => this["primary_location"];

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryQueueEndpoint => this["primary_queue_endpoint"];

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    public TerraformExpression PrimaryQueueHost => this["primary_queue_host"];

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryQueueMicrosoftEndpoint => this["primary_queue_microsoft_endpoint"];

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformExpression PrimaryQueueMicrosoftHost => this["primary_queue_microsoft_host"];

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryTableEndpoint => this["primary_table_endpoint"];

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    public TerraformExpression PrimaryTableHost => this["primary_table_host"];

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryTableMicrosoftEndpoint => this["primary_table_microsoft_endpoint"];

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    public TerraformExpression PrimaryTableMicrosoftHost => this["primary_table_microsoft_host"];

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryWebEndpoint => this["primary_web_endpoint"];

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    public TerraformExpression PrimaryWebHost => this["primary_web_host"];

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryWebInternetEndpoint => this["primary_web_internet_endpoint"];

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    public TerraformExpression PrimaryWebInternetHost => this["primary_web_internet_host"];

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression PrimaryWebMicrosoftEndpoint => this["primary_web_microsoft_endpoint"];

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    public TerraformExpression PrimaryWebMicrosoftHost => this["primary_web_microsoft_host"];

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public TerraformExpression QueueEncryptionKeyType => this["queue_encryption_key_type"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryBlobConnectionString => this["secondary_blob_connection_string"];

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryBlobEndpoint => this["secondary_blob_endpoint"];

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    public TerraformExpression SecondaryBlobHost => this["secondary_blob_host"];

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryBlobInternetEndpoint => this["secondary_blob_internet_endpoint"];

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    public TerraformExpression SecondaryBlobInternetHost => this["secondary_blob_internet_host"];

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryBlobMicrosoftEndpoint => this["secondary_blob_microsoft_endpoint"];

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformExpression SecondaryBlobMicrosoftHost => this["secondary_blob_microsoft_host"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryDfsEndpoint => this["secondary_dfs_endpoint"];

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    public TerraformExpression SecondaryDfsHost => this["secondary_dfs_host"];

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryDfsInternetEndpoint => this["secondary_dfs_internet_endpoint"];

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    public TerraformExpression SecondaryDfsInternetHost => this["secondary_dfs_internet_host"];

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryDfsMicrosoftEndpoint => this["secondary_dfs_microsoft_endpoint"];

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformExpression SecondaryDfsMicrosoftHost => this["secondary_dfs_microsoft_host"];

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryFileEndpoint => this["secondary_file_endpoint"];

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    public TerraformExpression SecondaryFileHost => this["secondary_file_host"];

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryFileInternetEndpoint => this["secondary_file_internet_endpoint"];

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    public TerraformExpression SecondaryFileInternetHost => this["secondary_file_internet_host"];

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryFileMicrosoftEndpoint => this["secondary_file_microsoft_endpoint"];

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    public TerraformExpression SecondaryFileMicrosoftHost => this["secondary_file_microsoft_host"];

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    public TerraformExpression SecondaryLocation => this["secondary_location"];

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryQueueEndpoint => this["secondary_queue_endpoint"];

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    public TerraformExpression SecondaryQueueHost => this["secondary_queue_host"];

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryQueueMicrosoftEndpoint => this["secondary_queue_microsoft_endpoint"];

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformExpression SecondaryQueueMicrosoftHost => this["secondary_queue_microsoft_host"];

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryTableEndpoint => this["secondary_table_endpoint"];

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    public TerraformExpression SecondaryTableHost => this["secondary_table_host"];

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryTableMicrosoftEndpoint => this["secondary_table_microsoft_endpoint"];

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    public TerraformExpression SecondaryTableMicrosoftHost => this["secondary_table_microsoft_host"];

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryWebEndpoint => this["secondary_web_endpoint"];

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    public TerraformExpression SecondaryWebHost => this["secondary_web_host"];

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryWebInternetEndpoint => this["secondary_web_internet_endpoint"];

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    public TerraformExpression SecondaryWebInternetHost => this["secondary_web_internet_host"];

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformExpression SecondaryWebMicrosoftEndpoint => this["secondary_web_microsoft_endpoint"];

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    public TerraformExpression SecondaryWebMicrosoftHost => this["secondary_web_microsoft_host"];

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public TerraformExpression TableEncryptionKeyType => this["table_encryption_key_type"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
