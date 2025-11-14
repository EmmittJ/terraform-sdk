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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleAssignmentsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_role_assignments.
/// </summary>
public class AzurermRoleAssignmentsDataSource : TerraformDataSource
{
    public AzurermRoleAssignmentsDataSource(string name) : base("azurerm_role_assignments", name)
    {
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
    /// The limit_at_scope attribute.
    /// </summary>
    [TerraformArgument("limit_at_scope")]
    public TerraformValue<bool>? LimitAtScope
    {
        get => new TerraformReference<bool>(this, "limit_at_scope");
        set => SetArgument("limit_at_scope", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformArgument("principal_id")]
    public TerraformValue<string>? PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformArgument("scope")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string>? TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRoleAssignmentsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The role_assignments attribute.
    /// </summary>
    [TerraformArgument("role_assignments")]
    public TerraformList<object> RoleAssignments
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "role_assignments").ResolveNodes(ctx));
    }

}
