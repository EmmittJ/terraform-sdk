using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for scope in AzurermNetworkManager.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    public TerraformList<string>? ManagementGroupIds
    {
        get => GetArgument<TerraformList<string>>("management_group_ids");
        set => SetArgument("management_group_ids", value);
    }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformList<string>? SubscriptionIds
    {
        get => GetArgument<TerraformList<string>>("subscription_ids");
        set => SetArgument("subscription_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetworkManager.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_manager Terraform resource.
/// Manages a azurerm_network_manager resource.
/// </summary>
public partial class AzurermNetworkManager(string name) : TerraformResource("azurerm_network_manager", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scope_accesses attribute.
    /// </summary>
    public TerraformList<string>? ScopeAccesses
    {
        get => GetArgument<TerraformList<string>>("scope_accesses");
        set => SetArgument("scope_accesses", value);
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
    /// The cross_tenant_scopes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CrossTenantScopes
        => AsReference("cross_tenant_scopes");

    /// <summary>
    /// Scope block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Scope block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public required TerraformList<AzurermNetworkManagerScopeBlock> Scope
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkManagerScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
