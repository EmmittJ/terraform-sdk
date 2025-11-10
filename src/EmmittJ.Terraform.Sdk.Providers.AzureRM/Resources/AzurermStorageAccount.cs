using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_files_authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountAzureFilesAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The default_share_level_permission attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultShareLevelPermission
    {
        get => GetProperty<TerraformProperty<string>>("default_share_level_permission");
        set => WithProperty("default_share_level_permission", value);
    }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
    public required TerraformProperty<string> DirectoryType
    {
        get => GetProperty<TerraformProperty<string>>("directory_type");
        set => WithProperty("directory_type", value);
    }

}

/// <summary>
/// Block type for blob_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The change_feed_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ChangeFeedEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("change_feed_enabled");
        set => WithProperty("change_feed_enabled", value);
    }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? ChangeFeedRetentionInDays
    {
        get => GetProperty<TerraformProperty<double>>("change_feed_retention_in_days");
        set => WithProperty("change_feed_retention_in_days", value);
    }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultServiceVersion
    {
        get => GetProperty<TerraformProperty<string>>("default_service_version");
        set => WithProperty("default_service_version", value);
    }

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LastAccessTimeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("last_access_time_enabled");
        set => WithProperty("last_access_time_enabled", value);
    }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VersioningEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("versioning_enabled");
        set => WithProperty("versioning_enabled", value);
    }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomDomainBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The use_subdomain attribute.
    /// </summary>
    public TerraformProperty<bool>? UseSubdomain
    {
        get => GetProperty<TerraformProperty<bool>>("use_subdomain");
        set => WithProperty("use_subdomain", value);
    }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_key_id");
        set => WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    public required TerraformProperty<string> UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for immutability_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountImmutabilityPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The allow_protected_append_writes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowProtectedAppendWrites is required")]
    public required TerraformProperty<bool> AllowProtectedAppendWrites
    {
        get => GetProperty<TerraformProperty<bool>>("allow_protected_append_writes");
        set => WithProperty("allow_protected_append_writes", value);
    }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    public required TerraformProperty<double> PeriodSinceCreationInDays
    {
        get => GetProperty<TerraformProperty<double>>("period_since_creation_in_days");
        set => WithProperty("period_since_creation_in_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

}

/// <summary>
/// Block type for network_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountNetworkRulesBlock : TerraformBlock
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Bypass
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("bypass");
        set => WithProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => WithProperty("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpRules
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ip_rules");
        set => WithProperty("ip_rules", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VirtualNetworkSubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("virtual_network_subnet_ids");
        set => WithProperty("virtual_network_subnet_ids", value);
    }

}

/// <summary>
/// Block type for queue_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountRoutingBlock : TerraformBlock
{
    /// <summary>
    /// The choice attribute.
    /// </summary>
    public TerraformProperty<string>? Choice
    {
        get => GetProperty<TerraformProperty<string>>("choice");
        set => WithProperty("choice", value);
    }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishInternetEndpoints
    {
        get => GetProperty<TerraformProperty<bool>>("publish_internet_endpoints");
        set => WithProperty("publish_internet_endpoints", value);
    }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishMicrosoftEndpoints
    {
        get => GetProperty<TerraformProperty<bool>>("publish_microsoft_endpoints");
        set => WithProperty("publish_microsoft_endpoints", value);
    }

}

/// <summary>
/// Block type for sas_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The expiration_action attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationAction
    {
        get => GetProperty<TerraformProperty<string>>("expiration_action");
        set => WithProperty("expiration_action", value);
    }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
    public required TerraformProperty<string> ExpirationPeriod
    {
        get => GetProperty<TerraformProperty<string>>("expiration_period");
        set => WithProperty("expiration_period", value);
    }

}

/// <summary>
/// Block type for share_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for static_website in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountStaticWebsiteBlock : TerraformBlock
{
    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    public TerraformProperty<string>? Error404Document
    {
        get => GetProperty<TerraformProperty<string>>("error_404_document");
        set => WithProperty("error_404_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformProperty<string>? IndexDocument
    {
        get => GetProperty<TerraformProperty<string>>("index_document");
        set => WithProperty("index_document", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<string>? AccessTier
    {
        get => GetProperty<TerraformProperty<string>>("access_tier");
        set => this.WithProperty("access_tier", value);
    }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public TerraformProperty<string>? AccountKind
    {
        get => GetProperty<TerraformProperty<string>>("account_kind");
        set => this.WithProperty("account_kind", value);
    }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    public required TerraformProperty<string> AccountReplicationType
    {
        get => GetProperty<TerraformProperty<string>>("account_replication_type");
        set => this.WithProperty("account_replication_type", value);
    }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    public required TerraformProperty<string> AccountTier
    {
        get => GetProperty<TerraformProperty<string>>("account_tier");
        set => this.WithProperty("account_tier", value);
    }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowNestedItemsToBePublic
    {
        get => GetProperty<TerraformProperty<bool>>("allow_nested_items_to_be_public");
        set => this.WithProperty("allow_nested_items_to_be_public", value);
    }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    public TerraformProperty<string>? AllowedCopyScope
    {
        get => GetProperty<TerraformProperty<string>>("allowed_copy_scope");
        set => this.WithProperty("allowed_copy_scope", value);
    }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CrossTenantReplicationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cross_tenant_replication_enabled");
        set => this.WithProperty("cross_tenant_replication_enabled", value);
    }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultToOauthAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("default_to_oauth_authentication");
        set => this.WithProperty("default_to_oauth_authentication", value);
    }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? DnsEndpointType
    {
        get => GetProperty<TerraformProperty<string>>("dns_endpoint_type");
        set => this.WithProperty("dns_endpoint_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsTrafficOnlyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("https_traffic_only_enabled");
        set => this.WithProperty("https_traffic_only_enabled", value);
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => this.WithProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsHnsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_hns_enabled");
        set => this.WithProperty("is_hns_enabled", value);
    }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LargeFileShareEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("large_file_share_enabled");
        set => this.WithProperty("large_file_share_enabled", value);
    }

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalUserEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_user_enabled");
        set => this.WithProperty("local_user_enabled", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Nfsv3Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("nfsv3_enabled");
        set => this.WithProperty("nfsv3_enabled", value);
    }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisionedBillingModelVersion
    {
        get => GetProperty<TerraformProperty<string>>("provisioned_billing_model_version");
        set => this.WithProperty("provisioned_billing_model_version", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? QueueEncryptionKeyType
    {
        get => GetProperty<TerraformProperty<string>>("queue_encryption_key_type");
        set => this.WithProperty("queue_encryption_key_type", value);
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
    /// The sftp_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SftpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sftp_enabled");
        set => this.WithProperty("sftp_enabled", value);
    }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SharedAccessKeyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("shared_access_key_enabled");
        set => this.WithProperty("shared_access_key_enabled", value);
    }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? TableEncryptionKeyType
    {
        get => GetProperty<TerraformProperty<string>>("table_encryption_key_type");
        set => this.WithProperty("table_encryption_key_type", value);
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
    /// Block for azure_files_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    public List<AzurermStorageAccountAzureFilesAuthenticationBlock>? AzureFilesAuthentication
    {
        get => GetProperty<List<AzurermStorageAccountAzureFilesAuthenticationBlock>>("azure_files_authentication");
        set => this.WithProperty("azure_files_authentication", value);
    }

    /// <summary>
    /// Block for blob_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    public List<AzurermStorageAccountBlobPropertiesBlock>? BlobProperties
    {
        get => GetProperty<List<AzurermStorageAccountBlobPropertiesBlock>>("blob_properties");
        set => this.WithProperty("blob_properties", value);
    }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    public List<AzurermStorageAccountCustomDomainBlock>? CustomDomain
    {
        get => GetProperty<List<AzurermStorageAccountCustomDomainBlock>>("custom_domain");
        set => this.WithProperty("custom_domain", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermStorageAccountCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetProperty<List<AzurermStorageAccountCustomerManagedKeyBlock>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermStorageAccountIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermStorageAccountIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for immutability_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    public List<AzurermStorageAccountImmutabilityPolicyBlock>? ImmutabilityPolicy
    {
        get => GetProperty<List<AzurermStorageAccountImmutabilityPolicyBlock>>("immutability_policy");
        set => this.WithProperty("immutability_policy", value);
    }

    /// <summary>
    /// Block for network_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    public List<AzurermStorageAccountNetworkRulesBlock>? NetworkRules
    {
        get => GetProperty<List<AzurermStorageAccountNetworkRulesBlock>>("network_rules");
        set => this.WithProperty("network_rules", value);
    }

    /// <summary>
    /// Block for queue_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesBlock>? QueueProperties
    {
        get => GetProperty<List<AzurermStorageAccountQueuePropertiesBlock>>("queue_properties");
        set => this.WithProperty("queue_properties", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermStorageAccountRoutingBlock>? Routing
    {
        get => GetProperty<List<AzurermStorageAccountRoutingBlock>>("routing");
        set => this.WithProperty("routing", value);
    }

    /// <summary>
    /// Block for sas_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    public List<AzurermStorageAccountSasPolicyBlock>? SasPolicy
    {
        get => GetProperty<List<AzurermStorageAccountSasPolicyBlock>>("sas_policy");
        set => this.WithProperty("sas_policy", value);
    }

    /// <summary>
    /// Block for share_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    public List<AzurermStorageAccountSharePropertiesBlock>? ShareProperties
    {
        get => GetProperty<List<AzurermStorageAccountSharePropertiesBlock>>("share_properties");
        set => this.WithProperty("share_properties", value);
    }

    /// <summary>
    /// Block for static_website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    public List<AzurermStorageAccountStaticWebsiteBlock>? StaticWebsite
    {
        get => GetProperty<List<AzurermStorageAccountStaticWebsiteBlock>>("static_website");
        set => this.WithProperty("static_website", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageAccountTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
