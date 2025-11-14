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
/// Block type for azure_files_authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountAzureFilesAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_files_authentication";

    /// <summary>
    /// The default_share_level_permission attribute.
    /// </summary>
    [TerraformArgument("default_share_level_permission")]
    public TerraformValue<string>? DefaultShareLevelPermission
    {
        get => new TerraformReference<string>(this, "default_share_level_permission");
        set => SetArgument("default_share_level_permission", value);
    }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
    [TerraformArgument("directory_type")]
    public required TerraformValue<string> DirectoryType
    {
        get => new TerraformReference<string>(this, "directory_type");
        set => SetArgument("directory_type", value);
    }

}

/// <summary>
/// Block type for blob_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blob_properties";

    /// <summary>
    /// The change_feed_enabled attribute.
    /// </summary>
    [TerraformArgument("change_feed_enabled")]
    public TerraformValue<bool>? ChangeFeedEnabled
    {
        get => new TerraformReference<bool>(this, "change_feed_enabled");
        set => SetArgument("change_feed_enabled", value);
    }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    [TerraformArgument("change_feed_retention_in_days")]
    public TerraformValue<double>? ChangeFeedRetentionInDays
    {
        get => new TerraformReference<double>(this, "change_feed_retention_in_days");
        set => SetArgument("change_feed_retention_in_days", value);
    }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    [TerraformArgument("default_service_version")]
    public TerraformValue<string> DefaultServiceVersion
    {
        get => new TerraformReference<string>(this, "default_service_version");
        set => SetArgument("default_service_version", value);
    }

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    [TerraformArgument("last_access_time_enabled")]
    public TerraformValue<bool>? LastAccessTimeEnabled
    {
        get => new TerraformReference<bool>(this, "last_access_time_enabled");
        set => SetArgument("last_access_time_enabled", value);
    }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
    [TerraformArgument("versioning_enabled")]
    public TerraformValue<bool>? VersioningEnabled
    {
        get => new TerraformReference<bool>(this, "versioning_enabled");
        set => SetArgument("versioning_enabled", value);
    }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomDomainBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_domain";

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
    /// The use_subdomain attribute.
    /// </summary>
    [TerraformArgument("use_subdomain")]
    public TerraformValue<bool>? UseSubdomain
    {
        get => new TerraformReference<bool>(this, "use_subdomain");
        set => SetArgument("use_subdomain", value);
    }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_key";

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_key_id")]
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformArgument("managed_hsm_key_id")]
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => new TerraformReference<string>(this, "managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    [TerraformArgument("user_assigned_identity_id")]
    public required TerraformValue<string> UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for immutability_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountImmutabilityPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "immutability_policy";

    /// <summary>
    /// The allow_protected_append_writes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowProtectedAppendWrites is required")]
    [TerraformArgument("allow_protected_append_writes")]
    public required TerraformValue<bool> AllowProtectedAppendWrites
    {
        get => new TerraformReference<bool>(this, "allow_protected_append_writes");
        set => SetArgument("allow_protected_append_writes", value);
    }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    [TerraformArgument("period_since_creation_in_days")]
    public required TerraformValue<double> PeriodSinceCreationInDays
    {
        get => new TerraformReference<double>(this, "period_since_creation_in_days");
        set => SetArgument("period_since_creation_in_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformArgument("state")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}

/// <summary>
/// Block type for network_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountNetworkRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_rules";

    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [TerraformArgument("bypass")]
    public TerraformSet<string> Bypass
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "bypass").ResolveNodes(ctx));
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformArgument("default_action")]
    public required TerraformValue<string> DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformArgument("ip_rules")]
    public TerraformSet<string> IpRules
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_rules").ResolveNodes(ctx));
        set => SetArgument("ip_rules", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    [TerraformArgument("virtual_network_subnet_ids")]
    public TerraformSet<string> VirtualNetworkSubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "virtual_network_subnet_ids").ResolveNodes(ctx));
        set => SetArgument("virtual_network_subnet_ids", value);
    }

}

/// <summary>
/// Block type for queue_properties in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountQueuePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "queue_properties";

}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing";

    /// <summary>
    /// The choice attribute.
    /// </summary>
    [TerraformArgument("choice")]
    public TerraformValue<string>? Choice
    {
        get => new TerraformReference<string>(this, "choice");
        set => SetArgument("choice", value);
    }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    [TerraformArgument("publish_internet_endpoints")]
    public TerraformValue<bool>? PublishInternetEndpoints
    {
        get => new TerraformReference<bool>(this, "publish_internet_endpoints");
        set => SetArgument("publish_internet_endpoints", value);
    }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
    [TerraformArgument("publish_microsoft_endpoints")]
    public TerraformValue<bool>? PublishMicrosoftEndpoints
    {
        get => new TerraformReference<bool>(this, "publish_microsoft_endpoints");
        set => SetArgument("publish_microsoft_endpoints", value);
    }

}

/// <summary>
/// Block type for sas_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sas_policy";

    /// <summary>
    /// The expiration_action attribute.
    /// </summary>
    [TerraformArgument("expiration_action")]
    public TerraformValue<string>? ExpirationAction
    {
        get => new TerraformReference<string>(this, "expiration_action");
        set => SetArgument("expiration_action", value);
    }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
    [TerraformArgument("expiration_period")]
    public required TerraformValue<string> ExpirationPeriod
    {
        get => new TerraformReference<string>(this, "expiration_period");
        set => SetArgument("expiration_period", value);
    }

}

/// <summary>
/// Block type for share_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "share_properties";

}

/// <summary>
/// Block type for static_website in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountStaticWebsiteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_website";

    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    [TerraformArgument("error_404_document")]
    public TerraformValue<string>? Error404Document
    {
        get => new TerraformReference<string>(this, "error_404_document");
        set => SetArgument("error_404_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    [TerraformArgument("index_document")]
    public TerraformValue<string>? IndexDocument
    {
        get => new TerraformReference<string>(this, "index_document");
        set => SetArgument("index_document", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformArgument("access_tier")]
    public TerraformValue<string> AccessTier
    {
        get => new TerraformReference<string>(this, "access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformArgument("account_kind")]
    public TerraformValue<string>? AccountKind
    {
        get => new TerraformReference<string>(this, "account_kind");
        set => SetArgument("account_kind", value);
    }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    [TerraformArgument("account_replication_type")]
    public required TerraformValue<string> AccountReplicationType
    {
        get => new TerraformReference<string>(this, "account_replication_type");
        set => SetArgument("account_replication_type", value);
    }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    [TerraformArgument("account_tier")]
    public required TerraformValue<string> AccountTier
    {
        get => new TerraformReference<string>(this, "account_tier");
        set => SetArgument("account_tier", value);
    }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformArgument("allow_nested_items_to_be_public")]
    public TerraformValue<bool>? AllowNestedItemsToBePublic
    {
        get => new TerraformReference<bool>(this, "allow_nested_items_to_be_public");
        set => SetArgument("allow_nested_items_to_be_public", value);
    }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    [TerraformArgument("allowed_copy_scope")]
    public TerraformValue<string>? AllowedCopyScope
    {
        get => new TerraformReference<string>(this, "allowed_copy_scope");
        set => SetArgument("allowed_copy_scope", value);
    }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    [TerraformArgument("cross_tenant_replication_enabled")]
    public TerraformValue<bool>? CrossTenantReplicationEnabled
    {
        get => new TerraformReference<bool>(this, "cross_tenant_replication_enabled");
        set => SetArgument("cross_tenant_replication_enabled", value);
    }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    [TerraformArgument("default_to_oauth_authentication")]
    public TerraformValue<bool>? DefaultToOauthAuthentication
    {
        get => new TerraformReference<bool>(this, "default_to_oauth_authentication");
        set => SetArgument("default_to_oauth_authentication", value);
    }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformArgument("dns_endpoint_type")]
    public TerraformValue<string>? DnsEndpointType
    {
        get => new TerraformReference<string>(this, "dns_endpoint_type");
        set => SetArgument("dns_endpoint_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformArgument("edge_zone")]
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformArgument("https_traffic_only_enabled")]
    public TerraformValue<bool>? HttpsTrafficOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "https_traffic_only_enabled");
        set => SetArgument("https_traffic_only_enabled", value);
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("infrastructure_encryption_enabled")]
    public TerraformValue<bool>? InfrastructureEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformArgument("is_hns_enabled")]
    public TerraformValue<bool>? IsHnsEnabled
    {
        get => new TerraformReference<bool>(this, "is_hns_enabled");
        set => SetArgument("is_hns_enabled", value);
    }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    [TerraformArgument("large_file_share_enabled")]
    public TerraformValue<bool> LargeFileShareEnabled
    {
        get => new TerraformReference<bool>(this, "large_file_share_enabled");
        set => SetArgument("large_file_share_enabled", value);
    }

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    [TerraformArgument("local_user_enabled")]
    public TerraformValue<bool>? LocalUserEnabled
    {
        get => new TerraformReference<bool>(this, "local_user_enabled");
        set => SetArgument("local_user_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformArgument("nfsv3_enabled")]
    public TerraformValue<bool>? Nfsv3Enabled
    {
        get => new TerraformReference<bool>(this, "nfsv3_enabled");
        set => SetArgument("nfsv3_enabled", value);
    }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    [TerraformArgument("provisioned_billing_model_version")]
    public TerraformValue<string>? ProvisionedBillingModelVersion
    {
        get => new TerraformReference<string>(this, "provisioned_billing_model_version");
        set => SetArgument("provisioned_billing_model_version", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformArgument("queue_encryption_key_type")]
    public TerraformValue<string>? QueueEncryptionKeyType
    {
        get => new TerraformReference<string>(this, "queue_encryption_key_type");
        set => SetArgument("queue_encryption_key_type", value);
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
    /// The sftp_enabled attribute.
    /// </summary>
    [TerraformArgument("sftp_enabled")]
    public TerraformValue<bool>? SftpEnabled
    {
        get => new TerraformReference<bool>(this, "sftp_enabled");
        set => SetArgument("sftp_enabled", value);
    }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    [TerraformArgument("shared_access_key_enabled")]
    public TerraformValue<bool>? SharedAccessKeyEnabled
    {
        get => new TerraformReference<bool>(this, "shared_access_key_enabled");
        set => SetArgument("shared_access_key_enabled", value);
    }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformArgument("table_encryption_key_type")]
    public TerraformValue<string>? TableEncryptionKeyType
    {
        get => new TerraformReference<string>(this, "table_encryption_key_type");
        set => SetArgument("table_encryption_key_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for azure_files_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    [TerraformArgument("azure_files_authentication")]
    public TerraformList<AzurermStorageAccountAzureFilesAuthenticationBlock> AzureFilesAuthentication { get; set; } = new();

    /// <summary>
    /// Block for blob_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    [TerraformArgument("blob_properties")]
    public TerraformList<AzurermStorageAccountBlobPropertiesBlock> BlobProperties { get; set; } = new();

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    [TerraformArgument("custom_domain")]
    public TerraformList<AzurermStorageAccountCustomDomainBlock> CustomDomain { get; set; } = new();

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformArgument("customer_managed_key")]
    public TerraformList<AzurermStorageAccountCustomerManagedKeyBlock> CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermStorageAccountIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for immutability_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    [TerraformArgument("immutability_policy")]
    public TerraformList<AzurermStorageAccountImmutabilityPolicyBlock> ImmutabilityPolicy { get; set; } = new();

    /// <summary>
    /// Block for network_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    [TerraformArgument("network_rules")]
    public TerraformList<AzurermStorageAccountNetworkRulesBlock> NetworkRules { get; set; } = new();

    /// <summary>
    /// Block for queue_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformArgument("queue_properties")]
    public TerraformList<AzurermStorageAccountQueuePropertiesBlock> QueueProperties { get; set; } = new();

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformArgument("routing")]
    public TerraformList<AzurermStorageAccountRoutingBlock> Routing { get; set; } = new();

    /// <summary>
    /// Block for sas_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    [TerraformArgument("sas_policy")]
    public TerraformList<AzurermStorageAccountSasPolicyBlock> SasPolicy { get; set; } = new();

    /// <summary>
    /// Block for share_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    [TerraformArgument("share_properties")]
    public TerraformList<AzurermStorageAccountSharePropertiesBlock> ShareProperties { get; set; } = new();

    /// <summary>
    /// Block for static_website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformArgument("static_website")]
    public TerraformList<AzurermStorageAccountStaticWebsiteBlock> StaticWebsite { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageAccountTimeoutsBlock Timeouts { get; set; } = new();

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

}
