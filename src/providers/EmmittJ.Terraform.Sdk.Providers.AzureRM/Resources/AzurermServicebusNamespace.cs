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
/// Block type for customer_managed_key in .
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
    [TerraformArgument("identity_id")]
    public required TerraformValue<string> IdentityId
    {
        get => new TerraformReference<string>(this, "identity_id");
        set => SetArgument("identity_id", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformArgument("key_vault_key_id")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

}

/// <summary>
/// Block type for identity in .
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
/// Block type for network_rule_set in .
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
    [TerraformArgument("default_action")]
    public TerraformValue<string>? DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformArgument("ip_rules")]
    public TerraformSet<string>? IpRules
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_rules").ResolveNodes(ctx));
        set => SetArgument("ip_rules", value);
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
    /// The trusted_services_allowed attribute.
    /// </summary>
    [TerraformArgument("trusted_services_allowed")]
    public TerraformValue<bool>? TrustedServicesAllowed
    {
        get => new TerraformReference<bool>(this, "trusted_services_allowed");
        set => SetArgument("trusted_services_allowed", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_servicebus_namespace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermServicebusNamespace : TerraformResource
{
    public AzurermServicebusNamespace(string name) : base("azurerm_servicebus_namespace", name)
    {
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformArgument("capacity")]
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
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
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("local_auth_enabled")]
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => new TerraformReference<bool>(this, "local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
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
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformArgument("minimum_tls_version")]
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
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
    /// The premium_messaging_partitions attribute.
    /// </summary>
    [TerraformArgument("premium_messaging_partitions")]
    public TerraformValue<double>? PremiumMessagingPartitions
    {
        get => new TerraformReference<double>(this, "premium_messaging_partitions");
        set => SetArgument("premium_messaging_partitions", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
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
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformArgument("customer_managed_key")]
    public TerraformList<AzurermServicebusNamespaceCustomerManagedKeyBlock> CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermServicebusNamespaceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for network_rule_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkRuleSet block(s) allowed")]
    [TerraformArgument("network_rule_set")]
    public TerraformList<AzurermServicebusNamespaceNetworkRuleSetBlock> NetworkRuleSet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServicebusNamespaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformArgument("default_primary_connection_string")]
    public TerraformValue<string> DefaultPrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "default_primary_connection_string");
    }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformArgument("default_primary_key")]
    public TerraformValue<string> DefaultPrimaryKey
    {
        get => new TerraformReference<string>(this, "default_primary_key");
    }

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    [TerraformArgument("default_secondary_connection_string")]
    public TerraformValue<string> DefaultSecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "default_secondary_connection_string");
    }

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformArgument("default_secondary_key")]
    public TerraformValue<string> DefaultSecondaryKey
    {
        get => new TerraformReference<string>(this, "default_secondary_key");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

}
