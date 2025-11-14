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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSearchServiceIdentityBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSearchServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_search_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSearchService : TerraformResource
{
    public AzurermSearchService(string name) : base("azurerm_search_service", name)
    {
    }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformArgument("allowed_ips")]
    public TerraformSet<string>? AllowedIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_ips").ResolveNodes(ctx));
        set => SetArgument("allowed_ips", value);
    }

    /// <summary>
    /// The authentication_failure_mode attribute.
    /// </summary>
    [TerraformArgument("authentication_failure_mode")]
    public TerraformValue<string>? AuthenticationFailureMode
    {
        get => new TerraformReference<string>(this, "authentication_failure_mode");
        set => SetArgument("authentication_failure_mode", value);
    }

    /// <summary>
    /// The customer_managed_key_enforcement_enabled attribute.
    /// </summary>
    [TerraformArgument("customer_managed_key_enforcement_enabled")]
    public TerraformValue<bool>? CustomerManagedKeyEnforcementEnabled
    {
        get => new TerraformReference<bool>(this, "customer_managed_key_enforcement_enabled");
        set => SetArgument("customer_managed_key_enforcement_enabled", value);
    }

    /// <summary>
    /// The hosting_mode attribute.
    /// </summary>
    [TerraformArgument("hosting_mode")]
    public TerraformValue<string>? HostingMode
    {
        get => new TerraformReference<string>(this, "hosting_mode");
        set => SetArgument("hosting_mode", value);
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("local_authentication_enabled")]
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
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
    /// The network_rule_bypass_option attribute.
    /// </summary>
    [TerraformArgument("network_rule_bypass_option")]
    public TerraformValue<string>? NetworkRuleBypassOption
    {
        get => new TerraformReference<string>(this, "network_rule_bypass_option");
        set => SetArgument("network_rule_bypass_option", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [TerraformArgument("partition_count")]
    public TerraformValue<double>? PartitionCount
    {
        get => new TerraformReference<double>(this, "partition_count");
        set => SetArgument("partition_count", value);
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
    /// The replica_count attribute.
    /// </summary>
    [TerraformArgument("replica_count")]
    public TerraformValue<double>? ReplicaCount
    {
        get => new TerraformReference<double>(this, "replica_count");
        set => SetArgument("replica_count", value);
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
    /// The semantic_search_sku attribute.
    /// </summary>
    [TerraformArgument("semantic_search_sku")]
    public TerraformValue<string>? SemanticSearchSku
    {
        get => new TerraformReference<string>(this, "semantic_search_sku");
        set => SetArgument("semantic_search_sku", value);
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
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermSearchServiceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSearchServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The customer_managed_key_encryption_compliance_status attribute.
    /// </summary>
    [TerraformArgument("customer_managed_key_encryption_compliance_status")]
    public TerraformValue<string> CustomerManagedKeyEncryptionComplianceStatus
    {
        get => new TerraformReference<string>(this, "customer_managed_key_encryption_compliance_status");
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformArgument("primary_key")]
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The query_keys attribute.
    /// </summary>
    [TerraformArgument("query_keys")]
    public TerraformList<object> QueryKeys
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "query_keys").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformArgument("secondary_key")]
    public TerraformValue<string> SecondaryKey
    {
        get => new TerraformReference<string>(this, "secondary_key");
    }

}
