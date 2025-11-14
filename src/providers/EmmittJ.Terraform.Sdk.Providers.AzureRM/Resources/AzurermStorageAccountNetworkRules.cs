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
/// Block type for private_link_access in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_link_access";

    /// <summary>
    /// The endpoint_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointResourceId is required")]
    [TerraformArgument("endpoint_resource_id")]
    public required TerraformValue<string> EndpointResourceId
    {
        get => new TerraformReference<string>(this, "endpoint_resource_id");
        set => SetArgument("endpoint_resource_id", value);
    }

    /// <summary>
    /// The endpoint_tenant_id attribute.
    /// </summary>
    [TerraformArgument("endpoint_tenant_id")]
    public TerraformValue<string> EndpointTenantId
    {
        get => new TerraformReference<string>(this, "endpoint_tenant_id");
        set => SetArgument("endpoint_tenant_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountNetworkRulesTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_account_network_rules resource.
/// </summary>
public class AzurermStorageAccountNetworkRules : TerraformResource
{
    public AzurermStorageAccountNetworkRules(string name) : base("azurerm_storage_account_network_rules", name)
    {
    }

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
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformArgument("storage_account_id")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    [TerraformArgument("virtual_network_subnet_ids")]
    public TerraformSet<string>? VirtualNetworkSubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "virtual_network_subnet_ids").ResolveNodes(ctx));
        set => SetArgument("virtual_network_subnet_ids", value);
    }

    /// <summary>
    /// Block for private_link_access.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("private_link_access")]
    public TerraformList<AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock> PrivateLinkAccess { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageAccountNetworkRulesTimeoutsBlock Timeouts { get; set; } = new();

}
