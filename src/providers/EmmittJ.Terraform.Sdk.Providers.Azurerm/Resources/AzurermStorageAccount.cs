using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_files_authentication in AzurermStorageAccount.
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
        get => GetArgument<TerraformValue<string>>("default_share_level_permission");
        set => SetArgument("default_share_level_permission", value);
    }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryType is required")]
    public required TerraformValue<string> DirectoryType
    {
        get => GetRequiredArgument<TerraformValue<string>>("directory_type");
        set => SetArgument("directory_type", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermStorageAccountAzureFilesAuthenticationBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermStorageAccountAzureFilesAuthenticationBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermStorageAccountAzureFilesAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountAzureFilesAuthenticationBlockActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory";

    /// <summary>
    /// The domain_guid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainGuid is required")]
    public required TerraformValue<string> DomainGuid
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_guid");
        set => SetArgument("domain_guid", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_sid attribute.
    /// </summary>
    public TerraformValue<string>? DomainSid
    {
        get => GetArgument<TerraformValue<string>>("domain_sid");
        set => SetArgument("domain_sid", value);
    }

    /// <summary>
    /// The forest_name attribute.
    /// </summary>
    public TerraformValue<string>? ForestName
    {
        get => GetArgument<TerraformValue<string>>("forest_name");
        set => SetArgument("forest_name", value);
    }

    /// <summary>
    /// The netbios_domain_name attribute.
    /// </summary>
    public TerraformValue<string>? NetbiosDomainName
    {
        get => GetArgument<TerraformValue<string>>("netbios_domain_name");
        set => SetArgument("netbios_domain_name", value);
    }

    /// <summary>
    /// The storage_sid attribute.
    /// </summary>
    public TerraformValue<string>? StorageSid
    {
        get => GetArgument<TerraformValue<string>>("storage_sid");
        set => SetArgument("storage_sid", value);
    }

}


/// <summary>
/// Block type for blob_properties in AzurermStorageAccount.
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
        get => GetArgument<TerraformValue<bool>>("change_feed_enabled");
        set => SetArgument("change_feed_enabled", value);
    }

    /// <summary>
    /// The change_feed_retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? ChangeFeedRetentionInDays
    {
        get => GetArgument<TerraformValue<double>>("change_feed_retention_in_days");
        set => SetArgument("change_feed_retention_in_days", value);
    }

    /// <summary>
    /// The default_service_version attribute.
    /// </summary>
    public TerraformValue<string> DefaultServiceVersion
    {
        get => GetArgument<TerraformValue<string>>("default_service_version") ?? AsReference("default_service_version");
        set => SetArgument("default_service_version", value);
    }

    /// <summary>
    /// The last_access_time_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LastAccessTimeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("last_access_time_enabled");
        set => SetArgument("last_access_time_enabled", value);
    }

    /// <summary>
    /// The versioning_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VersioningEnabled
    {
        get => GetArgument<TerraformValue<bool>>("versioning_enabled");
        set => SetArgument("versioning_enabled", value);
    }

    /// <summary>
    /// ContainerDeleteRetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerDeleteRetentionPolicy block(s) allowed")]
    public TerraformList<AzurermStorageAccountBlobPropertiesBlockContainerDeleteRetentionPolicyBlock>? ContainerDeleteRetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermStorageAccountBlobPropertiesBlockContainerDeleteRetentionPolicyBlock>>("container_delete_retention_policy");
        set => SetArgument("container_delete_retention_policy", value);
    }

    /// <summary>
    /// CorsRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    public TerraformList<AzurermStorageAccountBlobPropertiesBlockCorsRuleBlock>? CorsRule
    {
        get => GetArgument<TerraformList<AzurermStorageAccountBlobPropertiesBlockCorsRuleBlock>>("cors_rule");
        set => SetArgument("cors_rule", value);
    }

    /// <summary>
    /// DeleteRetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteRetentionPolicy block(s) allowed")]
    public TerraformList<AzurermStorageAccountBlobPropertiesBlockDeleteRetentionPolicyBlock>? DeleteRetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermStorageAccountBlobPropertiesBlockDeleteRetentionPolicyBlock>>("delete_retention_policy");
        set => SetArgument("delete_retention_policy", value);
    }

    /// <summary>
    /// RestorePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestorePolicy block(s) allowed")]
    public TerraformList<AzurermStorageAccountBlobPropertiesBlockRestorePolicyBlock>? RestorePolicy
    {
        get => GetArgument<TerraformList<AzurermStorageAccountBlobPropertiesBlockRestorePolicyBlock>>("restore_policy");
        set => SetArgument("restore_policy", value);
    }

}

/// <summary>
/// Block type for container_delete_retention_policy in AzurermStorageAccountBlobPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlockContainerDeleteRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_delete_retention_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

}

/// <summary>
/// Block type for cors_rule in AzurermStorageAccountBlobPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlockCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_rule";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    public TerraformList<string>? AllowedHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => GetArgument<TerraformList<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public TerraformList<string>? ExposedHeaders
    {
        get => GetArgument<TerraformList<string>>("exposed_headers");
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    public required TerraformValue<double> MaxAgeInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for delete_retention_policy in AzurermStorageAccountBlobPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlockDeleteRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delete_retention_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The permanent_delete_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PermanentDeleteEnabled
    {
        get => GetArgument<TerraformValue<bool>>("permanent_delete_enabled");
        set => SetArgument("permanent_delete_enabled", value);
    }

}

/// <summary>
/// Block type for restore_policy in AzurermStorageAccountBlobPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountBlobPropertiesBlockRestorePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Days is required")]
    public required TerraformValue<double> Days
    {
        get => GetRequiredArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

}


/// <summary>
/// Block type for custom_domain in AzurermStorageAccount.
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The use_subdomain attribute.
    /// </summary>
    public TerraformValue<bool>? UseSubdomain
    {
        get => GetArgument<TerraformValue<bool>>("use_subdomain");
        set => SetArgument("use_subdomain", value);
    }

}


/// <summary>
/// Block type for customer_managed_key in AzurermStorageAccount.
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
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedHsmKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserAssignedIdentityId is required")]
    public required TerraformValue<string> UserAssignedIdentityId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermStorageAccount.
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for immutability_policy in AzurermStorageAccount.
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
        get => GetRequiredArgument<TerraformValue<bool>>("allow_protected_append_writes");
        set => SetArgument("allow_protected_append_writes", value);
    }

    /// <summary>
    /// The period_since_creation_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeriodSinceCreationInDays is required")]
    public required TerraformValue<double> PeriodSinceCreationInDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("period_since_creation_in_days");
        set => SetArgument("period_since_creation_in_days", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetRequiredArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for network_rules in AzurermStorageAccount.
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
        get => GetArgument<TerraformSet<string>>("bypass") ?? AsReference("bypass");
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformValue<string> DefaultAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public TerraformSet<string> IpRules
    {
        get => GetArgument<TerraformSet<string>>("ip_rules") ?? AsReference("ip_rules");
        set => SetArgument("ip_rules", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> VirtualNetworkSubnetIds
    {
        get => GetArgument<TerraformSet<string>>("virtual_network_subnet_ids") ?? AsReference("virtual_network_subnet_ids");
        set => SetArgument("virtual_network_subnet_ids", value);
    }

    /// <summary>
    /// PrivateLinkAccess block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageAccountNetworkRulesBlockPrivateLinkAccessBlock>? PrivateLinkAccess
    {
        get => GetArgument<TerraformList<AzurermStorageAccountNetworkRulesBlockPrivateLinkAccessBlock>>("private_link_access");
        set => SetArgument("private_link_access", value);
    }

}

/// <summary>
/// Block type for private_link_access in AzurermStorageAccountNetworkRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountNetworkRulesBlockPrivateLinkAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_link_access";

    /// <summary>
    /// The endpoint_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointResourceId is required")]
    public required TerraformValue<string> EndpointResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("endpoint_resource_id");
        set => SetArgument("endpoint_resource_id", value);
    }

    /// <summary>
    /// The endpoint_tenant_id attribute.
    /// </summary>
    public TerraformValue<string> EndpointTenantId
    {
        get => GetArgument<TerraformValue<string>>("endpoint_tenant_id") ?? AsReference("endpoint_tenant_id");
        set => SetArgument("endpoint_tenant_id", value);
    }

}


/// <summary>
/// Block type for queue_properties in AzurermStorageAccount.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermStorageAccountQueuePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "queue_properties";

    /// <summary>
    /// CorsRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesBlockCorsRuleBlock>? CorsRule
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesBlockCorsRuleBlock>>("cors_rule");
        set => SetArgument("cors_rule", value);
    }

    /// <summary>
    /// HourMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourMetrics block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesBlockHourMetricsBlock>? HourMetrics
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesBlockHourMetricsBlock>>("hour_metrics");
        set => SetArgument("hour_metrics", value);
    }

    /// <summary>
    /// Logging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesBlockLoggingBlock>? Logging
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesBlockLoggingBlock>>("logging");
        set => SetArgument("logging", value);
    }

    /// <summary>
    /// MinuteMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinuteMetrics block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesBlockMinuteMetricsBlock>? MinuteMetrics
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesBlockMinuteMetricsBlock>>("minute_metrics");
        set => SetArgument("minute_metrics", value);
    }

}

/// <summary>
/// Block type for cors_rule in AzurermStorageAccountQueuePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesBlockCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_rule";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    public TerraformList<string>? AllowedHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => GetArgument<TerraformList<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public TerraformList<string>? ExposedHeaders
    {
        get => GetArgument<TerraformList<string>>("exposed_headers");
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    public required TerraformValue<double> MaxAgeInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for hour_metrics in AzurermStorageAccountQueuePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesBlockHourMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hour_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeApis
    {
        get => GetArgument<TerraformValue<bool>>("include_apis");
        set => SetArgument("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => GetArgument<TerraformValue<double>>("retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for logging in AzurermStorageAccountQueuePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesBlockLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformValue<bool> Delete
    {
        get => GetRequiredArgument<TerraformValue<bool>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformValue<bool> Read
    {
        get => GetRequiredArgument<TerraformValue<bool>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => GetArgument<TerraformValue<double>>("retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformValue<bool> Write
    {
        get => GetRequiredArgument<TerraformValue<bool>>("write");
        set => SetArgument("write", value);
    }

}

/// <summary>
/// Block type for minute_metrics in AzurermStorageAccountQueuePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesBlockMinuteMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "minute_metrics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeApis
    {
        get => GetArgument<TerraformValue<bool>>("include_apis");
        set => SetArgument("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => GetArgument<TerraformValue<double>>("retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for routing in AzurermStorageAccount.
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
        get => GetArgument<TerraformValue<string>>("choice");
        set => SetArgument("choice", value);
    }

    /// <summary>
    /// The publish_internet_endpoints attribute.
    /// </summary>
    public TerraformValue<bool>? PublishInternetEndpoints
    {
        get => GetArgument<TerraformValue<bool>>("publish_internet_endpoints");
        set => SetArgument("publish_internet_endpoints", value);
    }

    /// <summary>
    /// The publish_microsoft_endpoints attribute.
    /// </summary>
    public TerraformValue<bool>? PublishMicrosoftEndpoints
    {
        get => GetArgument<TerraformValue<bool>>("publish_microsoft_endpoints");
        set => SetArgument("publish_microsoft_endpoints", value);
    }

}


/// <summary>
/// Block type for sas_policy in AzurermStorageAccount.
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
        get => GetArgument<TerraformValue<string>>("expiration_action");
        set => SetArgument("expiration_action", value);
    }

    /// <summary>
    /// The expiration_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationPeriod is required")]
    public required TerraformValue<string> ExpirationPeriod
    {
        get => GetRequiredArgument<TerraformValue<string>>("expiration_period");
        set => SetArgument("expiration_period", value);
    }

}


/// <summary>
/// Block type for share_properties in AzurermStorageAccount.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "share_properties";

    /// <summary>
    /// CorsRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    public TerraformList<AzurermStorageAccountSharePropertiesBlockCorsRuleBlock>? CorsRule
    {
        get => GetArgument<TerraformList<AzurermStorageAccountSharePropertiesBlockCorsRuleBlock>>("cors_rule");
        set => SetArgument("cors_rule", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public TerraformList<AzurermStorageAccountSharePropertiesBlockRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermStorageAccountSharePropertiesBlockRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

    /// <summary>
    /// Smb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Smb block(s) allowed")]
    public TerraformList<AzurermStorageAccountSharePropertiesBlockSmbBlock>? Smb
    {
        get => GetArgument<TerraformList<AzurermStorageAccountSharePropertiesBlockSmbBlock>>("smb");
        set => SetArgument("smb", value);
    }

}

/// <summary>
/// Block type for cors_rule in AzurermStorageAccountSharePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlockCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_rule";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    public TerraformList<string>? AllowedHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => GetArgument<TerraformList<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public TerraformList<string>? ExposedHeaders
    {
        get => GetArgument<TerraformList<string>>("exposed_headers");
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    public required TerraformValue<double> MaxAgeInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for retention_policy in AzurermStorageAccountSharePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlockRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

}

/// <summary>
/// Block type for smb in AzurermStorageAccountSharePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountSharePropertiesBlockSmbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "smb";

    /// <summary>
    /// The authentication_types attribute.
    /// </summary>
    public TerraformSet<string>? AuthenticationTypes
    {
        get => GetArgument<TerraformSet<string>>("authentication_types");
        set => SetArgument("authentication_types", value);
    }

    /// <summary>
    /// The channel_encryption_type attribute.
    /// </summary>
    public TerraformSet<string>? ChannelEncryptionType
    {
        get => GetArgument<TerraformSet<string>>("channel_encryption_type");
        set => SetArgument("channel_encryption_type", value);
    }

    /// <summary>
    /// The kerberos_ticket_encryption_type attribute.
    /// </summary>
    public TerraformSet<string>? KerberosTicketEncryptionType
    {
        get => GetArgument<TerraformSet<string>>("kerberos_ticket_encryption_type");
        set => SetArgument("kerberos_ticket_encryption_type", value);
    }

    /// <summary>
    /// The multichannel_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultichannelEnabled
    {
        get => GetArgument<TerraformValue<bool>>("multichannel_enabled");
        set => SetArgument("multichannel_enabled", value);
    }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformSet<string>? Versions
    {
        get => GetArgument<TerraformSet<string>>("versions");
        set => SetArgument("versions", value);
    }

}


/// <summary>
/// Block type for static_website in AzurermStorageAccount.
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
        get => GetArgument<TerraformValue<string>>("error_404_document");
        set => SetArgument("error_404_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformValue<string>? IndexDocument
    {
        get => GetArgument<TerraformValue<string>>("index_document");
        set => SetArgument("index_document", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageAccount.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("access_tier") ?? AsReference("access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The account_kind attribute.
    /// </summary>
    public TerraformValue<string>? AccountKind
    {
        get => GetArgument<TerraformValue<string>>("account_kind");
        set => SetArgument("account_kind", value);
    }

    /// <summary>
    /// The account_replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountReplicationType is required")]
    public required TerraformValue<string> AccountReplicationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_replication_type");
        set => SetArgument("account_replication_type", value);
    }

    /// <summary>
    /// The account_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountTier is required")]
    public required TerraformValue<string> AccountTier
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_tier");
        set => SetArgument("account_tier", value);
    }

    /// <summary>
    /// The allow_nested_items_to_be_public attribute.
    /// </summary>
    public TerraformValue<bool>? AllowNestedItemsToBePublic
    {
        get => GetArgument<TerraformValue<bool>>("allow_nested_items_to_be_public");
        set => SetArgument("allow_nested_items_to_be_public", value);
    }

    /// <summary>
    /// The allowed_copy_scope attribute.
    /// </summary>
    public TerraformValue<string>? AllowedCopyScope
    {
        get => GetArgument<TerraformValue<string>>("allowed_copy_scope");
        set => SetArgument("allowed_copy_scope", value);
    }

    /// <summary>
    /// The cross_tenant_replication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CrossTenantReplicationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cross_tenant_replication_enabled");
        set => SetArgument("cross_tenant_replication_enabled", value);
    }

    /// <summary>
    /// The default_to_oauth_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultToOauthAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("default_to_oauth_authentication");
        set => SetArgument("default_to_oauth_authentication", value);
    }

    /// <summary>
    /// The dns_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? DnsEndpointType
    {
        get => GetArgument<TerraformValue<string>>("dns_endpoint_type");
        set => SetArgument("dns_endpoint_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => GetArgument<TerraformValue<string>>("edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The https_traffic_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsTrafficOnlyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("https_traffic_only_enabled");
        set => SetArgument("https_traffic_only_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InfrastructureEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The is_hns_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsHnsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_hns_enabled");
        set => SetArgument("is_hns_enabled", value);
    }

    /// <summary>
    /// The large_file_share_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LargeFileShareEnabled
    {
        get => GetArgument<TerraformValue<bool>>("large_file_share_enabled") ?? AsReference("large_file_share_enabled");
        set => SetArgument("large_file_share_enabled", value);
    }

    /// <summary>
    /// The local_user_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalUserEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_user_enabled");
        set => SetArgument("local_user_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Nfsv3Enabled
    {
        get => GetArgument<TerraformValue<bool>>("nfsv3_enabled");
        set => SetArgument("nfsv3_enabled", value);
    }

    /// <summary>
    /// The provisioned_billing_model_version attribute.
    /// </summary>
    public TerraformValue<string>? ProvisionedBillingModelVersion
    {
        get => GetArgument<TerraformValue<string>>("provisioned_billing_model_version");
        set => SetArgument("provisioned_billing_model_version", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The queue_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string>? QueueEncryptionKeyType
    {
        get => GetArgument<TerraformValue<string>>("queue_encryption_key_type");
        set => SetArgument("queue_encryption_key_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sftp_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SftpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sftp_enabled");
        set => SetArgument("sftp_enabled", value);
    }

    /// <summary>
    /// The shared_access_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SharedAccessKeyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("shared_access_key_enabled");
        set => SetArgument("shared_access_key_enabled", value);
    }

    /// <summary>
    /// The table_encryption_key_type attribute.
    /// </summary>
    public TerraformValue<string>? TableEncryptionKeyType
    {
        get => GetArgument<TerraformValue<string>>("table_encryption_key_type");
        set => SetArgument("table_encryption_key_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The primary_blob_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobConnectionString
        => AsReference("primary_blob_connection_string");

    /// <summary>
    /// The primary_blob_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobEndpoint
        => AsReference("primary_blob_endpoint");

    /// <summary>
    /// The primary_blob_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobHost
        => AsReference("primary_blob_host");

    /// <summary>
    /// The primary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobInternetEndpoint
        => AsReference("primary_blob_internet_endpoint");

    /// <summary>
    /// The primary_blob_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobInternetHost
        => AsReference("primary_blob_internet_host");

    /// <summary>
    /// The primary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobMicrosoftEndpoint
        => AsReference("primary_blob_microsoft_endpoint");

    /// <summary>
    /// The primary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryBlobMicrosoftHost
        => AsReference("primary_blob_microsoft_host");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The primary_dfs_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsEndpoint
        => AsReference("primary_dfs_endpoint");

    /// <summary>
    /// The primary_dfs_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsHost
        => AsReference("primary_dfs_host");

    /// <summary>
    /// The primary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsInternetEndpoint
        => AsReference("primary_dfs_internet_endpoint");

    /// <summary>
    /// The primary_dfs_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsInternetHost
        => AsReference("primary_dfs_internet_host");

    /// <summary>
    /// The primary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsMicrosoftEndpoint
        => AsReference("primary_dfs_microsoft_endpoint");

    /// <summary>
    /// The primary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryDfsMicrosoftHost
        => AsReference("primary_dfs_microsoft_host");

    /// <summary>
    /// The primary_file_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileEndpoint
        => AsReference("primary_file_endpoint");

    /// <summary>
    /// The primary_file_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileHost
        => AsReference("primary_file_host");

    /// <summary>
    /// The primary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileInternetEndpoint
        => AsReference("primary_file_internet_endpoint");

    /// <summary>
    /// The primary_file_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileInternetHost
        => AsReference("primary_file_internet_host");

    /// <summary>
    /// The primary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileMicrosoftEndpoint
        => AsReference("primary_file_microsoft_endpoint");

    /// <summary>
    /// The primary_file_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryFileMicrosoftHost
        => AsReference("primary_file_microsoft_host");

    /// <summary>
    /// The primary_location attribute.
    /// </summary>
    public TerraformValue<string> PrimaryLocation
        => AsReference("primary_location");

    /// <summary>
    /// The primary_queue_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueEndpoint
        => AsReference("primary_queue_endpoint");

    /// <summary>
    /// The primary_queue_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueHost
        => AsReference("primary_queue_host");

    /// <summary>
    /// The primary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueMicrosoftEndpoint
        => AsReference("primary_queue_microsoft_endpoint");

    /// <summary>
    /// The primary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryQueueMicrosoftHost
        => AsReference("primary_queue_microsoft_host");

    /// <summary>
    /// The primary_table_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableEndpoint
        => AsReference("primary_table_endpoint");

    /// <summary>
    /// The primary_table_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableHost
        => AsReference("primary_table_host");

    /// <summary>
    /// The primary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableMicrosoftEndpoint
        => AsReference("primary_table_microsoft_endpoint");

    /// <summary>
    /// The primary_table_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryTableMicrosoftHost
        => AsReference("primary_table_microsoft_host");

    /// <summary>
    /// The primary_web_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebEndpoint
        => AsReference("primary_web_endpoint");

    /// <summary>
    /// The primary_web_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebHost
        => AsReference("primary_web_host");

    /// <summary>
    /// The primary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebInternetEndpoint
        => AsReference("primary_web_internet_endpoint");

    /// <summary>
    /// The primary_web_internet_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebInternetHost
        => AsReference("primary_web_internet_host");

    /// <summary>
    /// The primary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebMicrosoftEndpoint
        => AsReference("primary_web_microsoft_endpoint");

    /// <summary>
    /// The primary_web_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> PrimaryWebMicrosoftHost
        => AsReference("primary_web_microsoft_host");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The secondary_blob_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobConnectionString
        => AsReference("secondary_blob_connection_string");

    /// <summary>
    /// The secondary_blob_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobEndpoint
        => AsReference("secondary_blob_endpoint");

    /// <summary>
    /// The secondary_blob_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobHost
        => AsReference("secondary_blob_host");

    /// <summary>
    /// The secondary_blob_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobInternetEndpoint
        => AsReference("secondary_blob_internet_endpoint");

    /// <summary>
    /// The secondary_blob_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobInternetHost
        => AsReference("secondary_blob_internet_host");

    /// <summary>
    /// The secondary_blob_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobMicrosoftEndpoint
        => AsReference("secondary_blob_microsoft_endpoint");

    /// <summary>
    /// The secondary_blob_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryBlobMicrosoftHost
        => AsReference("secondary_blob_microsoft_host");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The secondary_dfs_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsEndpoint
        => AsReference("secondary_dfs_endpoint");

    /// <summary>
    /// The secondary_dfs_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsHost
        => AsReference("secondary_dfs_host");

    /// <summary>
    /// The secondary_dfs_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsInternetEndpoint
        => AsReference("secondary_dfs_internet_endpoint");

    /// <summary>
    /// The secondary_dfs_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsInternetHost
        => AsReference("secondary_dfs_internet_host");

    /// <summary>
    /// The secondary_dfs_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsMicrosoftEndpoint
        => AsReference("secondary_dfs_microsoft_endpoint");

    /// <summary>
    /// The secondary_dfs_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryDfsMicrosoftHost
        => AsReference("secondary_dfs_microsoft_host");

    /// <summary>
    /// The secondary_file_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileEndpoint
        => AsReference("secondary_file_endpoint");

    /// <summary>
    /// The secondary_file_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileHost
        => AsReference("secondary_file_host");

    /// <summary>
    /// The secondary_file_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileInternetEndpoint
        => AsReference("secondary_file_internet_endpoint");

    /// <summary>
    /// The secondary_file_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileInternetHost
        => AsReference("secondary_file_internet_host");

    /// <summary>
    /// The secondary_file_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileMicrosoftEndpoint
        => AsReference("secondary_file_microsoft_endpoint");

    /// <summary>
    /// The secondary_file_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryFileMicrosoftHost
        => AsReference("secondary_file_microsoft_host");

    /// <summary>
    /// The secondary_location attribute.
    /// </summary>
    public TerraformValue<string> SecondaryLocation
        => AsReference("secondary_location");

    /// <summary>
    /// The secondary_queue_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueEndpoint
        => AsReference("secondary_queue_endpoint");

    /// <summary>
    /// The secondary_queue_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueHost
        => AsReference("secondary_queue_host");

    /// <summary>
    /// The secondary_queue_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueMicrosoftEndpoint
        => AsReference("secondary_queue_microsoft_endpoint");

    /// <summary>
    /// The secondary_queue_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryQueueMicrosoftHost
        => AsReference("secondary_queue_microsoft_host");

    /// <summary>
    /// The secondary_table_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableEndpoint
        => AsReference("secondary_table_endpoint");

    /// <summary>
    /// The secondary_table_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableHost
        => AsReference("secondary_table_host");

    /// <summary>
    /// The secondary_table_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableMicrosoftEndpoint
        => AsReference("secondary_table_microsoft_endpoint");

    /// <summary>
    /// The secondary_table_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryTableMicrosoftHost
        => AsReference("secondary_table_microsoft_host");

    /// <summary>
    /// The secondary_web_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebEndpoint
        => AsReference("secondary_web_endpoint");

    /// <summary>
    /// The secondary_web_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebHost
        => AsReference("secondary_web_host");

    /// <summary>
    /// The secondary_web_internet_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebInternetEndpoint
        => AsReference("secondary_web_internet_endpoint");

    /// <summary>
    /// The secondary_web_internet_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebInternetHost
        => AsReference("secondary_web_internet_host");

    /// <summary>
    /// The secondary_web_microsoft_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebMicrosoftEndpoint
        => AsReference("secondary_web_microsoft_endpoint");

    /// <summary>
    /// The secondary_web_microsoft_host attribute.
    /// </summary>
    public TerraformValue<string> SecondaryWebMicrosoftHost
        => AsReference("secondary_web_microsoft_host");

    /// <summary>
    /// AzureFilesAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureFilesAuthentication block(s) allowed")]
    public TerraformList<AzurermStorageAccountAzureFilesAuthenticationBlock>? AzureFilesAuthentication
    {
        get => GetArgument<TerraformList<AzurermStorageAccountAzureFilesAuthenticationBlock>>("azure_files_authentication");
        set => SetArgument("azure_files_authentication", value);
    }

    /// <summary>
    /// BlobProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobProperties block(s) allowed")]
    public TerraformList<AzurermStorageAccountBlobPropertiesBlock>? BlobProperties
    {
        get => GetArgument<TerraformList<AzurermStorageAccountBlobPropertiesBlock>>("blob_properties");
        set => SetArgument("blob_properties", value);
    }

    /// <summary>
    /// CustomDomain block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    public TerraformList<AzurermStorageAccountCustomDomainBlock>? CustomDomain
    {
        get => GetArgument<TerraformList<AzurermStorageAccountCustomDomainBlock>>("custom_domain");
        set => SetArgument("custom_domain", value);
    }

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public TerraformList<AzurermStorageAccountCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetArgument<TerraformList<AzurermStorageAccountCustomerManagedKeyBlock>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermStorageAccountIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermStorageAccountIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ImmutabilityPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImmutabilityPolicy block(s) allowed")]
    public TerraformList<AzurermStorageAccountImmutabilityPolicyBlock>? ImmutabilityPolicy
    {
        get => GetArgument<TerraformList<AzurermStorageAccountImmutabilityPolicyBlock>>("immutability_policy");
        set => SetArgument("immutability_policy", value);
    }

    /// <summary>
    /// NetworkRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRules block(s) allowed")]
    public TerraformList<AzurermStorageAccountNetworkRulesBlock>? NetworkRules
    {
        get => GetArgument<TerraformList<AzurermStorageAccountNetworkRulesBlock>>("network_rules");
        set => SetArgument("network_rules", value);
    }

    /// <summary>
    /// QueueProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueueProperties block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermStorageAccountQueuePropertiesBlock>? QueueProperties
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesBlock>>("queue_properties");
        set => SetArgument("queue_properties", value);
    }

    /// <summary>
    /// Routing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public TerraformList<AzurermStorageAccountRoutingBlock>? Routing
    {
        get => GetArgument<TerraformList<AzurermStorageAccountRoutingBlock>>("routing");
        set => SetArgument("routing", value);
    }

    /// <summary>
    /// SasPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasPolicy block(s) allowed")]
    public TerraformList<AzurermStorageAccountSasPolicyBlock>? SasPolicy
    {
        get => GetArgument<TerraformList<AzurermStorageAccountSasPolicyBlock>>("sas_policy");
        set => SetArgument("sas_policy", value);
    }

    /// <summary>
    /// ShareProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareProperties block(s) allowed")]
    public TerraformList<AzurermStorageAccountSharePropertiesBlock>? ShareProperties
    {
        get => GetArgument<TerraformList<AzurermStorageAccountSharePropertiesBlock>>("share_properties");
        set => SetArgument("share_properties", value);
    }

    /// <summary>
    /// StaticWebsite block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticWebsite block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermStorageAccountStaticWebsiteBlock>? StaticWebsite
    {
        get => GetArgument<TerraformList<AzurermStorageAccountStaticWebsiteBlock>>("static_website");
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
