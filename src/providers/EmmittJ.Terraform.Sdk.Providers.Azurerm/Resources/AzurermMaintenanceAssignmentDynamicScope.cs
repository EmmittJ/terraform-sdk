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
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The os_types attribute.
    /// </summary>
    public TerraformList<string>? OsTypes
    {
        get => GetArgument<TerraformList<string>>("os_types");
        set => SetArgument("os_types", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformList<string>? ResourceGroups
    {
        get => GetArgument<TerraformList<string>>("resource_groups");
        set => SetArgument("resource_groups", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => GetArgument<TerraformList<string>>("resource_types");
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// The tag_filter attribute.
    /// </summary>
    public TerraformValue<string>? TagFilter
    {
        get => GetArgument<TerraformValue<string>>("tag_filter");
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
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
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
/// Represents a azurerm_maintenance_assignment_dynamic_scope Terraform resource.
/// Manages a azurerm_maintenance_assignment_dynamic_scope resource.
/// </summary>
public partial class AzurermMaintenanceAssignmentDynamicScope(string name) : TerraformResource("azurerm_maintenance_assignment_dynamic_scope", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The maintenance_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceConfigurationId is required")]
    public required TerraformValue<string> MaintenanceConfigurationId
    {
        get => GetArgument<TerraformValue<string>>("maintenance_configuration_id");
        set => SetArgument("maintenance_configuration_id", value);
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
