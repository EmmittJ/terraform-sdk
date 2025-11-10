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
        set => SetProperty("default_share_level_permission", value);
    }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
    public required TerraformProperty<string> DirectoryType
    {
        set => SetProperty("directory_type", value);
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
        set => SetProperty("change_feed_enabled", value);
    }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? ChangeFeedRetentionInDays
    {
        set => SetProperty("change_feed_retention_in_days", value);
    }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultServiceVersion
    {
        set => SetProperty("default_service_version", value);
    }

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LastAccessTimeEnabled
    {
        set => SetProperty("last_access_time_enabled", value);
    }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VersioningEnabled
    {
        set => SetProperty("versioning_enabled", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The use_subdomain attribute.
    /// </summary>
    public TerraformProperty<bool>? UseSubdomain
    {
        set => SetProperty("use_subdomain", value);
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
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        set => SetProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    public required TerraformProperty<string> UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("allow_protected_append_writes", value);
    }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    public required TerraformProperty<double> PeriodSinceCreationInDays
    {
        set => SetProperty("period_since_creation_in_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        set => SetProperty("state", value);
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
        set => SetProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        set => SetProperty("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpRules
    {
        set => SetProperty("ip_rules", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VirtualNetworkSubnetIds
    {
        set => SetProperty("virtual_network_subnet_ids", value);
    }

}

/// <summary>
/// Block type for queue_properties in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
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
        set => SetProperty("choice", value);
    }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishInternetEndpoints
    {
        set => SetProperty("publish_internet_endpoints", value);
    }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishMicrosoftEndpoints
    {
        set => SetProperty("publish_microsoft_endpoints", value);
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
        set => SetProperty("expiration_action", value);
    }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
    public required TerraformProperty<string> ExpirationPeriod
    {
        set => SetProperty("expiration_period", value);
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
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountStaticWebsiteBlock : TerraformBlock
{
    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    public TerraformProperty<string>? Error404Document
    {
        set => SetProperty("error_404_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformProperty<string>? IndexDocument
    {
        set => SetProperty("index_document", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("primary_access_key");
        SetOutput("primary_blob_connection_string");
        SetOutput("primary_blob_endpoint");
        SetOutput("primary_blob_host");
        SetOutput("primary_blob_internet_endpoint");
        SetOutput("primary_blob_internet_host");
        SetOutput("primary_blob_microsoft_endpoint");
        SetOutput("primary_blob_microsoft_host");
        SetOutput("primary_connection_string");
        SetOutput("primary_dfs_endpoint");
        SetOutput("primary_dfs_host");
        SetOutput("primary_dfs_internet_endpoint");
        SetOutput("primary_dfs_internet_host");
        SetOutput("primary_dfs_microsoft_endpoint");
        SetOutput("primary_dfs_microsoft_host");
        SetOutput("primary_file_endpoint");
        SetOutput("primary_file_host");
        SetOutput("primary_file_internet_endpoint");
        SetOutput("primary_file_internet_host");
        SetOutput("primary_file_microsoft_endpoint");
        SetOutput("primary_file_microsoft_host");
        SetOutput("primary_location");
        SetOutput("primary_queue_endpoint");
        SetOutput("primary_queue_host");
        SetOutput("primary_queue_microsoft_endpoint");
        SetOutput("primary_queue_microsoft_host");
        SetOutput("primary_table_endpoint");
        SetOutput("primary_table_host");
        SetOutput("primary_table_microsoft_endpoint");
        SetOutput("primary_table_microsoft_host");
        SetOutput("primary_web_endpoint");
        SetOutput("primary_web_host");
        SetOutput("primary_web_internet_endpoint");
        SetOutput("primary_web_internet_host");
        SetOutput("primary_web_microsoft_endpoint");
        SetOutput("primary_web_microsoft_host");
        SetOutput("secondary_access_key");
        SetOutput("secondary_blob_connection_string");
        SetOutput("secondary_blob_endpoint");
        SetOutput("secondary_blob_host");
        SetOutput("secondary_blob_internet_endpoint");
        SetOutput("secondary_blob_internet_host");
        SetOutput("secondary_blob_microsoft_endpoint");
        SetOutput("secondary_blob_microsoft_host");
        SetOutput("secondary_connection_string");
        SetOutput("secondary_dfs_endpoint");
        SetOutput("secondary_dfs_host");
        SetOutput("secondary_dfs_internet_endpoint");
        SetOutput("secondary_dfs_internet_host");
        SetOutput("secondary_dfs_microsoft_endpoint");
        SetOutput("secondary_dfs_microsoft_host");
        SetOutput("secondary_file_endpoint");
        SetOutput("secondary_file_host");
        SetOutput("secondary_file_internet_endpoint");
        SetOutput("secondary_file_internet_host");
        SetOutput("secondary_file_microsoft_endpoint");
        SetOutput("secondary_file_microsoft_host");
        SetOutput("secondary_location");
        SetOutput("secondary_queue_endpoint");
        SetOutput("secondary_queue_host");
        SetOutput("secondary_queue_microsoft_endpoint");
        SetOutput("secondary_queue_microsoft_host");
        SetOutput("secondary_table_endpoint");
        SetOutput("secondary_table_host");
        SetOutput("secondary_table_microsoft_endpoint");
        SetOutput("secondary_table_microsoft_host");
        SetOutput("secondary_web_endpoint");
        SetOutput("secondary_web_host");
        SetOutput("secondary_web_internet_endpoint");
        SetOutput("secondary_web_internet_host");
        SetOutput("secondary_web_microsoft_endpoint");
        SetOutput("secondary_web_microsoft_host");
        SetOutput("access_tier");
        SetOutput("account_kind");
        SetOutput("account_replication_type");
        SetOutput("account_tier");
        SetOutput("allow_nested_items_to_be_public");
        SetOutput("allowed_copy_scope");
        SetOutput("cross_tenant_replication_enabled");
        SetOutput("default_to_oauth_authentication");
        SetOutput("dns_endpoint_type");
        SetOutput("edge_zone");
        SetOutput("https_traffic_only_enabled");
        SetOutput("id");
        SetOutput("infrastructure_encryption_enabled");
        SetOutput("is_hns_enabled");
        SetOutput("large_file_share_enabled");
        SetOutput("local_user_enabled");
        SetOutput("location");
        SetOutput("min_tls_version");
        SetOutput("name");
        SetOutput("nfsv3_enabled");
        SetOutput("provisioned_billing_model_version");
        SetOutput("public_network_access_enabled");
        SetOutput("queue_encryption_key_type");
        SetOutput("resource_group_name");
        SetOutput("sftp_enabled");
        SetOutput("shared_access_key_enabled");
        SetOutput("table_encryption_key_type");
        SetOutput("tags");
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformProperty<string> AccessTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_tier");
        set => SetProperty("access_tier", value);
    }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public TerraformProperty<string> AccountKind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_kind");
        set => SetProperty("account_kind", value);
    }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    public required TerraformProperty<string> AccountReplicationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_replication_type");
        set => SetProperty("account_replication_type", value);
    }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    public required TerraformProperty<string> AccountTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_tier");
        set => SetProperty("account_tier", value);
    }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public TerraformProperty<bool> AllowNestedItemsToBePublic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_nested_items_to_be_public");
        set => SetProperty("allow_nested_items_to_be_public", value);
    }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    public TerraformProperty<string> AllowedCopyScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allowed_copy_scope");
        set => SetProperty("allowed_copy_scope", value);
    }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CrossTenantReplicationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cross_tenant_replication_enabled");
        set => SetProperty("cross_tenant_replication_enabled", value);
    }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultToOauthAuthentication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_to_oauth_authentication");
        set => SetProperty("default_to_oauth_authentication", value);
    }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string> DnsEndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_endpoint_type");
        set => SetProperty("dns_endpoint_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
    }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HttpsTrafficOnlyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("https_traffic_only_enabled");
        set => SetProperty("https_traffic_only_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InfrastructureEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => SetProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IsHnsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_hns_enabled");
        set => SetProperty("is_hns_enabled", value);
    }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LargeFileShareEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("large_file_share_enabled");
        set => SetProperty("large_file_share_enabled", value);
    }

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalUserEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_user_enabled");
        set => SetProperty("local_user_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string> MinTlsVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("min_tls_version");
        set => SetProperty("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Nfsv3Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("nfsv3_enabled");
        set => SetProperty("nfsv3_enabled", value);
    }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    public TerraformProperty<string> ProvisionedBillingModelVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provisioned_billing_model_version");
        set => SetProperty("provisioned_billing_model_version", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public TerraformProperty<string> QueueEncryptionKeyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("queue_encryption_key_type");
        set => SetProperty("queue_encryption_key_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sftp_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SftpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sftp_enabled");
        set => SetProperty("sftp_enabled", value);
    }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SharedAccessKeyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("shared_access_key_enabled");
        set => SetProperty("shared_access_key_enabled", value);
    }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public TerraformProperty<string> TableEncryptionKeyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_encryption_key_type");
        set => SetProperty("table_encryption_key_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for azure_files_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    public List<AzurermStorageAccountAzureFilesAuthenticationBlock>? AzureFilesAuthentication
    {
        set => SetProperty("azure_files_authentication", value);
    }

    /// <summary>
    /// Block for blob_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    public List<AzurermStorageAccountBlobPropertiesBlock>? BlobProperties
    {
        set => SetProperty("blob_properties", value);
    }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    public List<AzurermStorageAccountCustomDomainBlock>? CustomDomain
    {
        set => SetProperty("custom_domain", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermStorageAccountCustomerManagedKeyBlock>? CustomerManagedKey
    {
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermStorageAccountIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for immutability_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    public List<AzurermStorageAccountImmutabilityPolicyBlock>? ImmutabilityPolicy
    {
        set => SetProperty("immutability_policy", value);
    }

    /// <summary>
    /// Block for network_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    public List<AzurermStorageAccountNetworkRulesBlock>? NetworkRules
    {
        set => SetProperty("network_rules", value);
    }

    /// <summary>
    /// Block for queue_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AzurermStorageAccountQueuePropertiesBlock>? QueueProperties
    {
        set => SetProperty("queue_properties", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermStorageAccountRoutingBlock>? Routing
    {
        set => SetProperty("routing", value);
    }

    /// <summary>
    /// Block for sas_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    public List<AzurermStorageAccountSasPolicyBlock>? SasPolicy
    {
        set => SetProperty("sas_policy", value);
    }

    /// <summary>
    /// Block for share_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    public List<AzurermStorageAccountSharePropertiesBlock>? ShareProperties
    {
        set => SetProperty("share_properties", value);
    }

    /// <summary>
    /// Block for static_website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AzurermStorageAccountStaticWebsiteBlock>? StaticWebsite
    {
        set => SetProperty("static_website", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
