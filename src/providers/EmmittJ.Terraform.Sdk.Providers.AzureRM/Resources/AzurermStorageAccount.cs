using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_files_authentication in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountAzureFilesAuthenticationBlock
{
    /// <summary>
    /// The default_share_level_permission attribute.
    /// </summary>
    [TerraformPropertyName("default_share_level_permission")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultShareLevelPermission { get; set; }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
    [TerraformPropertyName("directory_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DirectoryType { get; set; }

}

/// <summary>
/// Block type for blob_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlock
{
    /// <summary>
    /// The change_feed_enabled attribute.
    /// </summary>
    [TerraformPropertyName("change_feed_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ChangeFeedEnabled { get; set; }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("change_feed_retention_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ChangeFeedRetentionInDays { get; set; }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    [TerraformPropertyName("default_service_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DefaultServiceVersion { get; set; } = default!;

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    [TerraformPropertyName("last_access_time_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LastAccessTimeEnabled { get; set; }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
    [TerraformPropertyName("versioning_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VersioningEnabled { get; set; }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomDomainBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The use_subdomain attribute.
    /// </summary>
    [TerraformPropertyName("use_subdomain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseSubdomain { get; set; }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountCustomerManagedKeyBlock
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_hsm_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    [TerraformPropertyName("user_assigned_identity_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for immutability_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountImmutabilityPolicyBlock
{
    /// <summary>
    /// The allow_protected_append_writes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowProtectedAppendWrites is required")]
    [TerraformPropertyName("allow_protected_append_writes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> AllowProtectedAppendWrites { get; set; }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    [TerraformPropertyName("period_since_creation_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> PeriodSinceCreationInDays { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> State { get; set; }

}

/// <summary>
/// Block type for network_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountNetworkRulesBlock
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [TerraformPropertyName("bypass")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Bypass { get; set; } = default!;

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformPropertyName("default_action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DefaultAction { get; set; }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformPropertyName("ip_rules")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> IpRules { get; set; } = default!;

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> VirtualNetworkSubnetIds { get; set; } = default!;

}

/// <summary>
/// Block type for queue_properties in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountQueuePropertiesBlock
{
}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountRoutingBlock
{
    /// <summary>
    /// The choice attribute.
    /// </summary>
    [TerraformPropertyName("choice")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Choice { get; set; }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("publish_internet_endpoints")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublishInternetEndpoints { get; set; }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("publish_microsoft_endpoints")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublishMicrosoftEndpoints { get; set; }

}

/// <summary>
/// Block type for sas_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSasPolicyBlock
{
    /// <summary>
    /// The expiration_action attribute.
    /// </summary>
    [TerraformPropertyName("expiration_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpirationAction { get; set; }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
    [TerraformPropertyName("expiration_period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExpirationPeriod { get; set; }

}

/// <summary>
/// Block type for share_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlock
{
}

/// <summary>
/// Block type for static_website in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountStaticWebsiteBlock
{
    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    [TerraformPropertyName("error_404_document")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Error404Document { get; set; }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    [TerraformPropertyName("index_document")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IndexDocument { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccessTier { get; set; } = default!;

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformPropertyName("account_kind")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountKind { get; set; }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    [TerraformPropertyName("account_replication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountReplicationType { get; set; }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    [TerraformPropertyName("account_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountTier { get; set; }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformPropertyName("allow_nested_items_to_be_public")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowNestedItemsToBePublic { get; set; }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    [TerraformPropertyName("allowed_copy_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AllowedCopyScope { get; set; }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cross_tenant_replication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CrossTenantReplicationEnabled { get; set; }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    [TerraformPropertyName("default_to_oauth_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DefaultToOauthAuthentication { get; set; }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("dns_endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsEndpointType { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("https_traffic_only_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HttpsTrafficOnlyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_hns_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsHnsEnabled { get; set; }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    [TerraformPropertyName("large_file_share_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> LargeFileShareEnabled { get; set; } = default!;

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_user_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalUserEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

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
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformPropertyName("nfsv3_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Nfsv3Enabled { get; set; }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_billing_model_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProvisionedBillingModelVersion { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("queue_encryption_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueueEncryptionKeyType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sftp_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sftp_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SftpEnabled { get; set; }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("shared_access_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SharedAccessKeyEnabled { get; set; }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformPropertyName("table_encryption_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TableEncryptionKeyType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for azure_files_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    [TerraformPropertyName("azure_files_authentication")]
    public TerraformList<TerraformBlock<AzurermStorageAccountAzureFilesAuthenticationBlock>>? AzureFilesAuthentication { get; set; }

    /// <summary>
    /// Block for blob_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    [TerraformPropertyName("blob_properties")]
    public TerraformList<TerraformBlock<AzurermStorageAccountBlobPropertiesBlock>>? BlobProperties { get; set; }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    [TerraformPropertyName("custom_domain")]
    public TerraformList<TerraformBlock<AzurermStorageAccountCustomDomainBlock>>? CustomDomain { get; set; }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformPropertyName("customer_managed_key")]
    public TerraformList<TerraformBlock<AzurermStorageAccountCustomerManagedKeyBlock>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermStorageAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for immutability_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    [TerraformPropertyName("immutability_policy")]
    public TerraformList<TerraformBlock<AzurermStorageAccountImmutabilityPolicyBlock>>? ImmutabilityPolicy { get; set; }

    /// <summary>
    /// Block for network_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    [TerraformPropertyName("network_rules")]
    public TerraformList<TerraformBlock<AzurermStorageAccountNetworkRulesBlock>>? NetworkRules { get; set; }

    /// <summary>
    /// Block for queue_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("queue_properties")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesBlock>>? QueueProperties { get; set; }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformPropertyName("routing")]
    public TerraformList<TerraformBlock<AzurermStorageAccountRoutingBlock>>? Routing { get; set; }

    /// <summary>
    /// Block for sas_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    [TerraformPropertyName("sas_policy")]
    public TerraformList<TerraformBlock<AzurermStorageAccountSasPolicyBlock>>? SasPolicy { get; set; }

    /// <summary>
    /// Block for share_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    [TerraformPropertyName("share_properties")]
    public TerraformList<TerraformBlock<AzurermStorageAccountSharePropertiesBlock>>? ShareProperties { get; set; }

    /// <summary>
    /// Block for static_website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("static_website")]
    public TerraformList<TerraformBlock<AzurermStorageAccountStaticWebsiteBlock>>? StaticWebsite { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageAccountTimeoutsBlock>? Timeouts { get; set; }

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

}
