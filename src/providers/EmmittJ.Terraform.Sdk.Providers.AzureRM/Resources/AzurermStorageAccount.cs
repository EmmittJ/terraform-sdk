using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_files_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountAzureFilesAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_share_level_permission attribute.
    /// </summary>
    [TerraformProperty("default_share_level_permission")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultShareLevelPermission { get; set; }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
    [TerraformProperty("directory_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectoryType { get; set; }

}

/// <summary>
/// Block type for blob_properties in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountBlobPropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The change_feed_enabled attribute.
    /// </summary>
    [TerraformProperty("change_feed_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ChangeFeedEnabled { get; set; }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    [TerraformProperty("change_feed_retention_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ChangeFeedRetentionInDays { get; set; }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    [TerraformProperty("default_service_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultServiceVersion { get; set; }

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    [TerraformProperty("last_access_time_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LastAccessTimeEnabled { get; set; }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
    [TerraformProperty("versioning_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VersioningEnabled { get; set; }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountCustomDomainBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The use_subdomain attribute.
    /// </summary>
    [TerraformProperty("use_subdomain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseSubdomain { get; set; }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountCustomerManagedKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_hsm_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    [TerraformProperty("user_assigned_identity_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for immutability_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountImmutabilityPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_protected_append_writes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowProtectedAppendWrites is required")]
    [TerraformProperty("allow_protected_append_writes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AllowProtectedAppendWrites { get; set; }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    [TerraformProperty("period_since_creation_in_days")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> PeriodSinceCreationInDays { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformProperty("state")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> State { get; set; }

}

/// <summary>
/// Block type for network_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountNetworkRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [TerraformProperty("bypass")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Bypass { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformProperty("default_action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultAction { get; set; }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformProperty("ip_rules")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> IpRules { get; set; }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VirtualNetworkSubnetIds { get; set; }

}

/// <summary>
/// Block type for queue_properties in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzurermStorageAccountQueuePropertiesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountRoutingBlock : TerraformBlockBase
{
    /// <summary>
    /// The choice attribute.
    /// </summary>
    [TerraformProperty("choice")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Choice { get; set; }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    [TerraformProperty("publish_internet_endpoints")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublishInternetEndpoints { get; set; }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
    [TerraformProperty("publish_microsoft_endpoints")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublishMicrosoftEndpoints { get; set; }

}

/// <summary>
/// Block type for sas_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountSasPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The expiration_action attribute.
    /// </summary>
    [TerraformProperty("expiration_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpirationAction { get; set; }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
    [TerraformProperty("expiration_period")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExpirationPeriod { get; set; }

}

/// <summary>
/// Block type for share_properties in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountSharePropertiesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for static_website in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzurermStorageAccountStaticWebsiteBlock : TerraformBlockBase
{
    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    [TerraformProperty("error_404_document")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Error404Document { get; set; }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    [TerraformProperty("index_document")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IndexDocument { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageAccountTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStorageAccount : TerraformResource
{
    public AzurermStorageAccount(string name) : base("azurerm_storage_account", name)
    {
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformProperty("access_tier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccessTier { get; set; }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    [TerraformProperty("account_kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountKind { get; set; }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    [TerraformProperty("account_replication_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountReplicationType { get; set; }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    [TerraformProperty("account_tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountTier { get; set; }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    [TerraformProperty("allow_nested_items_to_be_public")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowNestedItemsToBePublic { get; set; }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    [TerraformProperty("allowed_copy_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllowedCopyScope { get; set; }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    [TerraformProperty("cross_tenant_replication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CrossTenantReplicationEnabled { get; set; }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    [TerraformProperty("default_to_oauth_authentication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultToOauthAuthentication { get; set; }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    [TerraformProperty("dns_endpoint_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsEndpointType { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    [TerraformProperty("https_traffic_only_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsTrafficOnlyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("infrastructure_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    [TerraformProperty("is_hns_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsHnsEnabled { get; set; }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    [TerraformProperty("large_file_share_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> LargeFileShareEnabled { get; set; }

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    [TerraformProperty("local_user_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalUserEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformProperty("min_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    [TerraformProperty("nfsv3_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Nfsv3Enabled { get; set; }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    [TerraformProperty("provisioned_billing_model_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProvisionedBillingModelVersion { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    [TerraformProperty("queue_encryption_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueueEncryptionKeyType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sftp_enabled attribute.
    /// </summary>
    [TerraformProperty("sftp_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SftpEnabled { get; set; }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    [TerraformProperty("shared_access_key_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SharedAccessKeyEnabled { get; set; }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    [TerraformProperty("table_encryption_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableEncryptionKeyType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for azure_files_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    [TerraformProperty("azure_files_authentication")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountAzureFilesAuthenticationBlock>>? AzureFilesAuthentication { get; set; }

    /// <summary>
    /// Block for blob_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    [TerraformProperty("blob_properties")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountBlobPropertiesBlock>>? BlobProperties { get; set; }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    [TerraformProperty("custom_domain")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountCustomDomainBlock>>? CustomDomain { get; set; }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformProperty("customer_managed_key")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountCustomerManagedKeyBlock>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for immutability_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    [TerraformProperty("immutability_policy")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountImmutabilityPolicyBlock>>? ImmutabilityPolicy { get; set; }

    /// <summary>
    /// Block for network_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    [TerraformProperty("network_rules")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountNetworkRulesBlock>>? NetworkRules { get; set; }

    /// <summary>
    /// Block for queue_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("queue_properties")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesBlock>>? QueueProperties { get; set; }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformProperty("routing")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountRoutingBlock>>? Routing { get; set; }

    /// <summary>
    /// Block for sas_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    [TerraformProperty("sas_policy")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountSasPolicyBlock>>? SasPolicy { get; set; }

    /// <summary>
    /// Block for share_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    [TerraformProperty("share_properties")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountSharePropertiesBlock>>? ShareProperties { get; set; }

    /// <summary>
    /// Block for static_website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("static_website")]
    public partial TerraformList<TerraformBlock<AzurermStorageAccountStaticWebsiteBlock>>? StaticWebsite { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermStorageAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_blob_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryBlobConnectionString { get; }

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_blob_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryBlobEndpoint { get; }

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    [TerraformProperty("primary_blob_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryBlobHost { get; }

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_blob_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryBlobInternetEndpoint { get; }

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_blob_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryBlobInternetHost { get; }

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_blob_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryBlobMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_blob_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryBlobMicrosoftHost { get; }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryConnectionString { get; }

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryDfsEndpoint { get; }

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryDfsHost { get; }

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryDfsInternetEndpoint { get; }

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryDfsInternetHost { get; }

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryDfsMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_dfs_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryDfsMicrosoftHost { get; }

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_file_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryFileEndpoint { get; }

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    [TerraformProperty("primary_file_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryFileHost { get; }

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_file_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryFileInternetEndpoint { get; }

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_file_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryFileInternetHost { get; }

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_file_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryFileMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_file_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryFileMicrosoftHost { get; }

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    [TerraformProperty("primary_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryLocation { get; }

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_queue_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryQueueEndpoint { get; }

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    [TerraformProperty("primary_queue_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryQueueHost { get; }

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_queue_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryQueueMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_queue_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryQueueMicrosoftHost { get; }

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_table_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryTableEndpoint { get; }

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    [TerraformProperty("primary_table_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryTableHost { get; }

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_table_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryTableMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_table_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryTableMicrosoftHost { get; }

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_web_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryWebEndpoint { get; }

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    [TerraformProperty("primary_web_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryWebHost { get; }

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_web_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryWebInternetEndpoint { get; }

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    [TerraformProperty("primary_web_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryWebInternetHost { get; }

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("primary_web_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryWebMicrosoftEndpoint { get; }

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("primary_web_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryWebMicrosoftHost { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryAccessKey { get; }

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryBlobConnectionString { get; }

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryBlobEndpoint { get; }

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryBlobHost { get; }

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryBlobInternetEndpoint { get; }

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryBlobInternetHost { get; }

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryBlobMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_blob_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryBlobMicrosoftHost { get; }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryConnectionString { get; }

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryDfsEndpoint { get; }

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryDfsHost { get; }

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryDfsInternetEndpoint { get; }

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryDfsInternetHost { get; }

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryDfsMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_dfs_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryDfsMicrosoftHost { get; }

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_file_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryFileEndpoint { get; }

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    [TerraformProperty("secondary_file_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryFileHost { get; }

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_file_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryFileInternetEndpoint { get; }

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_file_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryFileInternetHost { get; }

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_file_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryFileMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_file_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryFileMicrosoftHost { get; }

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    [TerraformProperty("secondary_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryLocation { get; }

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryQueueEndpoint { get; }

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryQueueHost { get; }

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryQueueMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_queue_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryQueueMicrosoftHost { get; }

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_table_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryTableEndpoint { get; }

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    [TerraformProperty("secondary_table_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryTableHost { get; }

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_table_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryTableMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_table_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryTableMicrosoftHost { get; }

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_web_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryWebEndpoint { get; }

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    [TerraformProperty("secondary_web_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryWebHost { get; }

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_web_internet_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryWebInternetEndpoint { get; }

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    [TerraformProperty("secondary_web_internet_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryWebInternetHost { get; }

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    [TerraformProperty("secondary_web_microsoft_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryWebMicrosoftEndpoint { get; }

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    [TerraformProperty("secondary_web_microsoft_host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryWebMicrosoftHost { get; }

}
