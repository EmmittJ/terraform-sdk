using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for private_link_access in AzurermStorageAccountNetworkRules.
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
    public required TerraformValue<string> EndpointResourceId
    {
        get => new TerraformReference<string>(this, "endpoint_resource_id");
        set => SetArgument("endpoint_resource_id", value);
    }

    /// <summary>
    /// The endpoint_tenant_id attribute.
    /// </summary>
    public TerraformValue<string> EndpointTenantId
    {
        get => new TerraformReference<string>(this, "endpoint_tenant_id");
        set => SetArgument("endpoint_tenant_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageAccountNetworkRules.
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
/// Represents a azurerm_storage_account_network_rules Terraform resource.
/// Manages a azurerm_storage_account_network_rules resource.
/// </summary>
public partial class AzurermStorageAccountNetworkRules(string name) : TerraformResource("azurerm_storage_account_network_rules", name)
{
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public TerraformSet<string>? IpRules
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_rules").ResolveNodes(ctx));
        set => SetArgument("ip_rules", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? VirtualNetworkSubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "virtual_network_subnet_ids").ResolveNodes(ctx));
        set => SetArgument("virtual_network_subnet_ids", value);
    }

    /// <summary>
    /// PrivateLinkAccess block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock>? PrivateLinkAccess
    {
        get => GetArgument<TerraformList<AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock>>("private_link_access");
        set => SetArgument("private_link_access", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountNetworkRulesTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountNetworkRulesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
