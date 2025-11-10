using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_files_authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountAzureFilesAuthenticationBlock : ITerraformBlock
{
    /// <summary>
    /// The default_share_level_permission attribute.
    /// </summary>
    [TerraformPropertyName("default_share_level_permission")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultShareLevelPermission { get; set; }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
    [TerraformPropertyName("directory_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DirectoryType { get; set; }

}

/// <summary>
/// Block type for blob_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The change_feed_enabled attribute.
    /// </summary>
    [TerraformPropertyName("change_feed_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ChangeFeedEnabled { get; set; }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("change_feed_retention_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ChangeFeedRetentionInDays { get; set; }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    [TerraformPropertyName("default_service_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultServiceVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "default_service_version");

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    [TerraformPropertyName("last_access_time_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LastAccessTimeEnabled { get; set; }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
    [TerraformPropertyName("versioning_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VersioningEnabled { get; set; }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomDomainBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The use_subdomain attribute.
    /// </summary>
    [TerraformPropertyName("use_subdomain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseSubdomain { get; set; }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomerManagedKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_hsm_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    [TerraformPropertyName("user_assigned_identity_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for immutability_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountImmutabilityPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_protected_append_writes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowProtectedAppendWrites is required")]
    [TerraformPropertyName("allow_protected_append_writes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> AllowProtectedAppendWrites { get; set; }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    [TerraformPropertyName("period_since_creation_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> PeriodSinceCreationInDays { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> State { get; set; }

}

/// <summary>
/// Block type for network_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountNetworkRulesBlock : ITerraformBlock
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [TerraformPropertyName("bypass")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Bypass { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "bypass");

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformPropertyName("default_action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DefaultAction { get; set; }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformPropertyName("ip_rules")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> IpRules { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "ip_rules");

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VirtualNetworkSubnetIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "virtual_network_subnet_ids");

}

/// <summary>
/// Block type for queue_properties in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountQueuePropertiesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountRoutingBlock : ITerraformBlock
{
    /// <summary>
    /// The choice attribute.
    /// </summary>
    [TerraformPropertyName("choice")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Choice { get; set; }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("publish_internet_endpoints")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublishInternetEndpoints { get; set; }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("publish_microsoft_endpoints")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublishMicrosoftEndpoints { get; set; }

}

/// <summary>
/// Block type for sas_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The expiration_action attribute.
    /// </summary>
    [TerraformPropertyName("expiration_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpirationAction { get; set; }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
    [TerraformPropertyName("expiration_period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExpirationPeriod { get; set; }

}

/// <summary>
/// Block type for share_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for static_website in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountStaticWebsiteBlock : ITerraformBlock
{
    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    [TerraformPropertyName("error_404_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Error404Document { get; set; }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    [TerraformPropertyName("index_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IndexDocument { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("access_tier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccessTier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_tier");

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformPropertyName("account_kind")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccountKind { get; set; }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    [TerraformPropertyName("account_replication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountReplicationType { get; set; }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    [TerraformPropertyName("account_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountTier { get; set; }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformPropertyName("allow_nested_items_to_be_public")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowNestedItemsToBePublic { get; set; }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    [TerraformPropertyName("allowed_copy_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllowedCopyScope { get; set; }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cross_tenant_replication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CrossTenantReplicationEnabled { get; set; }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    [TerraformPropertyName("default_to_oauth_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultToOauthAuthentication { get; set; }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("dns_endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsEndpointType { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("https_traffic_only_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HttpsTrafficOnlyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_hns_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsHnsEnabled { get; set; }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    [TerraformPropertyName("large_file_share_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> LargeFileShareEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "large_file_share_enabled");

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_user_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalUserEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

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
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformPropertyName("nfsv3_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Nfsv3Enabled { get; set; }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_billing_model_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProvisionedBillingModelVersion { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("queue_encryption_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueueEncryptionKeyType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sftp_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sftp_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SftpEnabled { get; set; }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("shared_access_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SharedAccessKeyEnabled { get; set; }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("table_encryption_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TableEncryptionKeyType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for azure_files_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    [TerraformPropertyName("azure_files_authentication")]
    public TerraformList<TerraformBlock<AzurermStorageAccountAzureFilesAuthenticationBlock>>? AzureFilesAuthentication { get; set; } = new();

    /// <summary>
    /// Block for blob_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    [TerraformPropertyName("blob_properties")]
    public TerraformList<TerraformBlock<AzurermStorageAccountBlobPropertiesBlock>>? BlobProperties { get; set; } = new();

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    [TerraformPropertyName("custom_domain")]
    public TerraformList<TerraformBlock<AzurermStorageAccountCustomDomainBlock>>? CustomDomain { get; set; } = new();

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformPropertyName("customer_managed_key")]
    public TerraformList<TerraformBlock<AzurermStorageAccountCustomerManagedKeyBlock>>? CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermStorageAccountIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for immutability_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    [TerraformPropertyName("immutability_policy")]
    public TerraformList<TerraformBlock<AzurermStorageAccountImmutabilityPolicyBlock>>? ImmutabilityPolicy { get; set; } = new();

    /// <summary>
    /// Block for network_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    [TerraformPropertyName("network_rules")]
    public TerraformList<TerraformBlock<AzurermStorageAccountNetworkRulesBlock>>? NetworkRules { get; set; } = new();

    /// <summary>
    /// Block for queue_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("queue_properties")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesBlock>>? QueueProperties { get; set; } = new();

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformPropertyName("routing")]
    public TerraformList<TerraformBlock<AzurermStorageAccountRoutingBlock>>? Routing { get; set; } = new();

    /// <summary>
    /// Block for sas_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    [TerraformPropertyName("sas_policy")]
    public TerraformList<TerraformBlock<AzurermStorageAccountSasPolicyBlock>>? SasPolicy { get; set; } = new();

    /// <summary>
    /// Block for share_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    [TerraformPropertyName("share_properties")]
    public TerraformList<TerraformBlock<AzurermStorageAccountSharePropertiesBlock>>? ShareProperties { get; set; } = new();

    /// <summary>
    /// Block for static_website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("static_website")]
    public TerraformList<TerraformBlock<AzurermStorageAccountStaticWebsiteBlock>>? StaticWebsite { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageAccountTimeoutsBlock>? Timeouts { get; set; } = new();

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

}
