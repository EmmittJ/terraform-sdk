using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for filter in AzurermMaintenanceAssignmentDynamicScope.
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceAssignmentDynamicScopeFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformList<string>? Locations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "locations").ResolveNodes(ctx));
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The os_types attribute.
    /// </summary>
    public TerraformList<string>? OsTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "os_types").ResolveNodes(ctx));
        set => SetArgument("os_types", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformList<string>? ResourceGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_groups").ResolveNodes(ctx));
        set => SetArgument("resource_groups", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The tag_filter attribute.
    /// </summary>
    public TerraformValue<string>? TagFilter
    {
        get => new TerraformReference<string>(this, "tag_filter");
        set => SetArgument("tag_filter", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMaintenanceAssignmentDynamicScopeFilterBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AzurermMaintenanceAssignmentDynamicScopeFilterBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tags in AzurermMaintenanceAssignmentDynamicScopeFilterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMaintenanceAssignmentDynamicScopeFilterBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformValue<string> Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMaintenanceAssignmentDynamicScope.
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_maintenance_assignment_dynamic_scope Terraform resource.
/// Manages a azurerm_maintenance_assignment_dynamic_scope resource.
/// </summary>
public partial class AzurermMaintenanceAssignmentDynamicScope(string name) : TerraformResource("azurerm_maintenance_assignment_dynamic_scope", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    public required TerraformValue<string> MaintenanceConfigurationId
    {
        get => new TerraformReference<string>(this, "maintenance_configuration_id");
        set => SetArgument("maintenance_configuration_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public required TerraformList<AzurermMaintenanceAssignmentDynamicScopeFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformList<AzurermMaintenanceAssignmentDynamicScopeFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMaintenanceAssignmentDynamicScopeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
