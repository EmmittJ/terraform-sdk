using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_account resource.
/// </summary>
public class AzurermStorageAccount : TerraformResource
{
    public AzurermStorageAccount(string name) : base("azurerm_storage_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("primary_blob_connection_string");
        this.DeclareOutput("primary_blob_endpoint");
        this.DeclareOutput("primary_blob_host");
        this.DeclareOutput("primary_blob_internet_endpoint");
        this.DeclareOutput("primary_blob_internet_host");
        this.DeclareOutput("primary_blob_microsoft_endpoint");
        this.DeclareOutput("primary_blob_microsoft_host");
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("primary_dfs_endpoint");
        this.DeclareOutput("primary_dfs_host");
        this.DeclareOutput("primary_dfs_internet_endpoint");
        this.DeclareOutput("primary_dfs_internet_host");
        this.DeclareOutput("primary_dfs_microsoft_endpoint");
        this.DeclareOutput("primary_dfs_microsoft_host");
        this.DeclareOutput("primary_file_endpoint");
        this.DeclareOutput("primary_file_host");
        this.DeclareOutput("primary_file_internet_endpoint");
        this.DeclareOutput("primary_file_internet_host");
        this.DeclareOutput("primary_file_microsoft_endpoint");
        this.DeclareOutput("primary_file_microsoft_host");
        this.DeclareOutput("primary_location");
        this.DeclareOutput("primary_queue_endpoint");
        this.DeclareOutput("primary_queue_host");
        this.DeclareOutput("primary_queue_microsoft_endpoint");
        this.DeclareOutput("primary_queue_microsoft_host");
        this.DeclareOutput("primary_table_endpoint");
        this.DeclareOutput("primary_table_host");
        this.DeclareOutput("primary_table_microsoft_endpoint");
        this.DeclareOutput("primary_table_microsoft_host");
        this.DeclareOutput("primary_web_endpoint");
        this.DeclareOutput("primary_web_host");
        this.DeclareOutput("primary_web_internet_endpoint");
        this.DeclareOutput("primary_web_internet_host");
        this.DeclareOutput("primary_web_microsoft_endpoint");
        this.DeclareOutput("primary_web_microsoft_host");
        this.DeclareOutput("secondary_access_key");
        this.DeclareOutput("secondary_blob_connection_string");
        this.DeclareOutput("secondary_blob_endpoint");
        this.DeclareOutput("secondary_blob_host");
        this.DeclareOutput("secondary_blob_internet_endpoint");
        this.DeclareOutput("secondary_blob_internet_host");
        this.DeclareOutput("secondary_blob_microsoft_endpoint");
        this.DeclareOutput("secondary_blob_microsoft_host");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("secondary_dfs_endpoint");
        this.DeclareOutput("secondary_dfs_host");
        this.DeclareOutput("secondary_dfs_internet_endpoint");
        this.DeclareOutput("secondary_dfs_internet_host");
        this.DeclareOutput("secondary_dfs_microsoft_endpoint");
        this.DeclareOutput("secondary_dfs_microsoft_host");
        this.DeclareOutput("secondary_file_endpoint");
        this.DeclareOutput("secondary_file_host");
        this.DeclareOutput("secondary_file_internet_endpoint");
        this.DeclareOutput("secondary_file_internet_host");
        this.DeclareOutput("secondary_file_microsoft_endpoint");
        this.DeclareOutput("secondary_file_microsoft_host");
        this.DeclareOutput("secondary_location");
        this.DeclareOutput("secondary_queue_endpoint");
        this.DeclareOutput("secondary_queue_host");
        this.DeclareOutput("secondary_queue_microsoft_endpoint");
        this.DeclareOutput("secondary_queue_microsoft_host");
        this.DeclareOutput("secondary_table_endpoint");
        this.DeclareOutput("secondary_table_host");
        this.DeclareOutput("secondary_table_microsoft_endpoint");
        this.DeclareOutput("secondary_table_microsoft_host");
        this.DeclareOutput("secondary_web_endpoint");
        this.DeclareOutput("secondary_web_host");
        this.DeclareOutput("secondary_web_internet_endpoint");
        this.DeclareOutput("secondary_web_internet_host");
        this.DeclareOutput("secondary_web_microsoft_endpoint");
        this.DeclareOutput("secondary_web_microsoft_host");
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public string? AccessTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_tier")?.Value;
        set => this.WithProperty("access_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public string? AccountKind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_kind")?.Value;
        set => this.WithProperty("account_kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    public string? AccountReplicationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_replication_type")?.Value;
        set => this.WithProperty("account_replication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    public string? AccountTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_tier")?.Value;
        set => this.WithProperty("account_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public bool? AllowNestedItemsToBePublic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_nested_items_to_be_public")?.Value;
        set => this.WithProperty("allow_nested_items_to_be_public", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    public string? AllowedCopyScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allowed_copy_scope")?.Value;
        set => this.WithProperty("allowed_copy_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    public bool? CrossTenantReplicationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cross_tenant_replication_enabled")?.Value;
        set => this.WithProperty("cross_tenant_replication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    public bool? DefaultToOauthAuthentication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_to_oauth_authentication")?.Value;
        set => this.WithProperty("default_to_oauth_authentication", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public string? DnsEndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_endpoint_type")?.Value;
        set => this.WithProperty("dns_endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public string? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone")?.Value;
        set => this.WithProperty("edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public bool? HttpsTrafficOnlyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_traffic_only_enabled")?.Value;
        set => this.WithProperty("https_traffic_only_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public bool? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("infrastructure_encryption_enabled")?.Value;
        set => this.WithProperty("infrastructure_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public bool? IsHnsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_hns_enabled")?.Value;
        set => this.WithProperty("is_hns_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    public bool? LargeFileShareEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("large_file_share_enabled")?.Value;
        set => this.WithProperty("large_file_share_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    public bool? LocalUserEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_user_enabled")?.Value;
        set => this.WithProperty("local_user_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public string? MinTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("min_tls_version")?.Value;
        set => this.WithProperty("min_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public bool? Nfsv3Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("nfsv3_enabled")?.Value;
        set => this.WithProperty("nfsv3_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    public string? ProvisionedBillingModelVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioned_billing_model_version")?.Value;
        set => this.WithProperty("provisioned_billing_model_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public string? QueueEncryptionKeyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("queue_encryption_key_type")?.Value;
        set => this.WithProperty("queue_encryption_key_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sftp_enabled attribute.
    /// </summary>
    public bool? SftpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sftp_enabled")?.Value;
        set => this.WithProperty("sftp_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    public bool? SharedAccessKeyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("shared_access_key_enabled")?.Value;
        set => this.WithProperty("shared_access_key_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public string? TableEncryptionKeyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_encryption_key_type")?.Value;
        set => this.WithProperty("table_encryption_key_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

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

}
