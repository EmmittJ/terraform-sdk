using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? DefaultShareLevelPermission
    {
        get => new TerraformReference<string>(this, "default_share_level_permission");
        set => SetArgument("default_share_level_permission", value);
    }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
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
    public TerraformValue<bool>? ChangeFeedEnabled
    {
        get => new TerraformReference<bool>(this, "change_feed_enabled");
        set => SetArgument("change_feed_enabled", value);
    }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? ChangeFeedRetentionInDays
    {
        get => new TerraformReference<double>(this, "change_feed_retention_in_days");
        set => SetArgument("change_feed_retention_in_days", value);
    }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    public TerraformValue<string> DefaultServiceVersion
    {
        get => new TerraformReference<string>(this, "default_service_version");
        set => SetArgument("default_service_version", value);
    }

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LastAccessTimeEnabled
    {
        get => new TerraformReference<bool>(this, "last_access_time_enabled");
        set => SetArgument("last_access_time_enabled", value);
    }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The use_subdomain attribute.
    /// </summary>
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
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => new TerraformReference<string>(this, "managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
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
    public required TerraformValue<bool> AllowProtectedAppendWrites
    {
        get => new TerraformReference<bool>(this, "allow_protected_append_writes");
        set => SetArgument("allow_protected_append_writes", value);
    }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    public required TerraformValue<double> PeriodSinceCreationInDays
    {
        get => new TerraformReference<double>(this, "period_since_creation_in_days");
        set => SetArgument("period_since_creation_in_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
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
    public TerraformSet<string> Bypass
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "bypass").ResolveNodes(ctx));
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformValue<string> DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public TerraformSet<string> IpRules
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_rules").ResolveNodes(ctx));
        set => SetArgument("ip_rules", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
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
    public TerraformValue<string>? Choice
    {
        get => new TerraformReference<string>(this, "choice");
        set => SetArgument("choice", value);
    }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    public TerraformValue<bool>? PublishInternetEndpoints
    {
        get => new TerraformReference<bool>(this, "publish_internet_endpoints");
        set => SetArgument("publish_internet_endpoints", value);
    }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
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
    public TerraformValue<string>? ExpirationAction
    {
        get => new TerraformReference<string>(this, "expiration_action");
        set => SetArgument("expiration_action", value);
    }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
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
    public TerraformValue<string>? Error404Document
    {
        get => new TerraformReference<string>(this, "error_404_document");
        set => SetArgument("error_404_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_storage_account Terraform resource.
/// Manages a azurerm_storage_account resource.
/// </summary>
public partial class AzurermStorageAccount(string name) : TerraformResource("azurerm_storage_account", name)
{
    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformValue<string> AccessTier
    {
        get => new TerraformReference<string>(this, "access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public TerraformValue<string>? AccountKind
    {
        get => new TerraformReference<string>(this, "account_kind");
        set => SetArgument("account_kind", value);
    }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    public required TerraformValue<string> AccountReplicationType
    {
        get => new TerraformReference<string>(this, "account_replication_type");
        set => SetArgument("account_replication_type", value);
    }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    public required TerraformValue<string> AccountTier
    {
        get => new TerraformReference<string>(this, "account_tier");
        set => SetArgument("account_tier", value);
    }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public TerraformValue<bool>? AllowNestedItemsToBePublic
    {
        get => new TerraformReference<bool>(this, "allow_nested_items_to_be_public");
        set => SetArgument("allow_nested_items_to_be_public", value);
    }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    public TerraformValue<string>? AllowedCopyScope
    {
        get => new TerraformReference<string>(this, "allowed_copy_scope");
        set => SetArgument("allowed_copy_scope", value);
    }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CrossTenantReplicationEnabled
    {
        get => new TerraformReference<bool>(this, "cross_tenant_replication_enabled");
        set => SetArgument("cross_tenant_replication_enabled", value);
    }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultToOauthAuthentication
    {
        get => new TerraformReference<bool>(this, "default_to_oauth_authentication");
        set => SetArgument("default_to_oauth_authentication", value);
    }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? DnsEndpointType
    {
        get => new TerraformReference<string>(this, "dns_endpoint_type");
        set => SetArgument("dns_endpoint_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsTrafficOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "https_traffic_only_enabled");
        set => SetArgument("https_traffic_only_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InfrastructureEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsHnsEnabled
    {
        get => new TerraformReference<bool>(this, "is_hns_enabled");
        set => SetArgument("is_hns_enabled", value);
    }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LargeFileShareEnabled
    {
        get => new TerraformReference<bool>(this, "large_file_share_enabled");
        set => SetArgument("large_file_share_enabled", value);
    }

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalUserEnabled
    {
        get => new TerraformReference<bool>(this, "local_user_enabled");
        set => SetArgument("local_user_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => new TerraformReference<string>(this, "min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Nfsv3Enabled
    {
        get => new TerraformReference<bool>(this, "nfsv3_enabled");
        set => SetArgument("nfsv3_enabled", value);
    }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    public TerraformValue<string>? ProvisionedBillingModelVersion
    {
        get => new TerraformReference<string>(this, "provisioned_billing_model_version");
        set => SetArgument("provisioned_billing_model_version", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string>? QueueEncryptionKeyType
    {
        get => new TerraformReference<string>(this, "queue_encryption_key_type");
        set => SetArgument("queue_encryption_key_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sftp_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SftpEnabled
    {
        get => new TerraformReference<bool>(this, "sftp_enabled");
        set => SetArgument("sftp_enabled", value);
    }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SharedAccessKeyEnabled
    {
        get => new TerraformReference<bool>(this, "shared_access_key_enabled");
        set => SetArgument("shared_access_key_enabled", value);
    }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string>? TableEncryptionKeyType
    {
        get => new TerraformReference<string>(this, "table_encryption_key_type");
        set => SetArgument("table_encryption_key_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AzureFilesAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    public AzurermStorageAccountAzureFilesAuthenticationBlock? AzureFilesAuthentication
    {
        get => GetArgument<AzurermStorageAccountAzureFilesAuthenticationBlock>("azure_files_authentication");
        set => SetArgument("azure_files_authentication", value);
    }

    /// <summary>
    /// BlobProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    public AzurermStorageAccountBlobPropertiesBlock? BlobProperties
    {
        get => GetArgument<AzurermStorageAccountBlobPropertiesBlock>("blob_properties");
        set => SetArgument("blob_properties", value);
    }

    /// <summary>
    /// CustomDomain block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    public AzurermStorageAccountCustomDomainBlock? CustomDomain
    {
        get => GetArgument<AzurermStorageAccountCustomDomainBlock>("custom_domain");
        set => SetArgument("custom_domain", value);
    }

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public AzurermStorageAccountCustomerManagedKeyBlock? CustomerManagedKey
    {
        get => GetArgument<AzurermStorageAccountCustomerManagedKeyBlock>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermStorageAccountIdentityBlock? Identity
    {
        get => GetArgument<AzurermStorageAccountIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ImmutabilityPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    public AzurermStorageAccountImmutabilityPolicyBlock? ImmutabilityPolicy
    {
        get => GetArgument<AzurermStorageAccountImmutabilityPolicyBlock>("immutability_policy");
        set => SetArgument("immutability_policy", value);
    }

    /// <summary>
    /// NetworkRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    public AzurermStorageAccountNetworkRulesBlock? NetworkRules
    {
        get => GetArgument<AzurermStorageAccountNetworkRulesBlock>("network_rules");
        set => SetArgument("network_rules", value);
    }

    /// <summary>
    /// QueueProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public AzurermStorageAccountQueuePropertiesBlock? QueueProperties
    {
        get => GetArgument<AzurermStorageAccountQueuePropertiesBlock>("queue_properties");
        set => SetArgument("queue_properties", value);
    }

    /// <summary>
    /// Routing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public AzurermStorageAccountRoutingBlock? Routing
    {
        get => GetArgument<AzurermStorageAccountRoutingBlock>("routing");
        set => SetArgument("routing", value);
    }

    /// <summary>
    /// SasPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    public AzurermStorageAccountSasPolicyBlock? SasPolicy
    {
        get => GetArgument<AzurermStorageAccountSasPolicyBlock>("sas_policy");
        set => SetArgument("sas_policy", value);
    }

    /// <summary>
    /// ShareProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    public AzurermStorageAccountSharePropertiesBlock? ShareProperties
    {
        get => GetArgument<AzurermStorageAccountSharePropertiesBlock>("share_properties");
        set => SetArgument("share_properties", value);
    }

    /// <summary>
    /// StaticWebsite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public AzurermStorageAccountStaticWebsiteBlock? StaticWebsite
    {
        get => GetArgument<AzurermStorageAccountStaticWebsiteBlock>("static_website");
        set => SetArgument("static_website", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
