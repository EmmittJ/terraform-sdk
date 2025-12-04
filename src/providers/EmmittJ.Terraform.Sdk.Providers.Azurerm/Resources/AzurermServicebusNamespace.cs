using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for customer_managed_key in AzurermServicebusNamespace.
/// Nesting mode: list
/// </summary>
public class AzurermServicebusNamespaceCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_key";

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityId is required")]
    public required TerraformValue<string> IdentityId
    {
        get => GetArgument<TerraformValue<string>>("identity_id");
        set => SetArgument("identity_id", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermServicebusNamespace.
/// Nesting mode: list
/// </summary>
public class AzurermServicebusNamespaceIdentityBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for network_rule_set in AzurermServicebusNamespace.
/// Nesting mode: list
/// </summary>
public class AzurermServicebusNamespaceNetworkRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_rule_set";

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAction
    {
        get => GetArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public TerraformSet<string>? IpRules
    {
        get => GetArgument<TerraformSet<string>>("ip_rules");
        set => SetArgument("ip_rules", value);
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
    /// The trusted_services_allowed attribute.
    /// </summary>
    public TerraformValue<bool>? TrustedServicesAllowed
    {
        get => GetArgument<TerraformValue<bool>>("trusted_services_allowed");
        set => SetArgument("trusted_services_allowed", value);
    }

    /// <summary>
    /// NetworkRules block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermServicebusNamespaceNetworkRuleSetBlockNetworkRulesBlock>? NetworkRules
    {
        get => GetArgument<TerraformSet<AzurermServicebusNamespaceNetworkRuleSetBlockNetworkRulesBlock>>("network_rules");
        set => SetArgument("network_rules", value);
    }

}

/// <summary>
/// Block type for network_rules in AzurermServicebusNamespaceNetworkRuleSetBlock.
/// Nesting mode: set
/// </summary>
public class AzurermServicebusNamespaceNetworkRuleSetBlockNetworkRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_rules";

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreMissingVnetServiceEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("ignore_missing_vnet_service_endpoint");
        set => SetArgument("ignore_missing_vnet_service_endpoint", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermServicebusNamespace.
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_servicebus_namespace Terraform resource.
/// Manages a azurerm_servicebus_namespace resource.
/// </summary>
public partial class AzurermServicebusNamespace(string name) : TerraformResource("azurerm_servicebus_namespace", name)
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The premium_messaging_partitions attribute.
    /// </summary>
    public TerraformValue<double>? PremiumMessagingPartitions
    {
        get => GetArgument<TerraformValue<double>>("premium_messaging_partitions");
        set => SetArgument("premium_messaging_partitions", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
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
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionString
        => AsReference("default_primary_connection_string");

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryKey
        => AsReference("default_primary_key");

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionString
        => AsReference("default_secondary_connection_string");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryKey
        => AsReference("default_secondary_key");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public TerraformList<AzurermServicebusNamespaceCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetArgument<TerraformList<AzurermServicebusNamespaceCustomerManagedKeyBlock>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermServicebusNamespaceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermServicebusNamespaceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NetworkRuleSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRuleSet block(s) allowed")]
    public TerraformList<AzurermServicebusNamespaceNetworkRuleSetBlock>? NetworkRuleSet
    {
        get => GetArgument<TerraformList<AzurermServicebusNamespaceNetworkRuleSetBlock>>("network_rule_set");
        set => SetArgument("network_rule_set", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusNamespaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusNamespaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
