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
public class AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dev_center_project_environment_type.
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectEnvironmentTypeDataSource(string name) : base("azurerm_dev_center_project_environment_type", name)
    {
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    [TerraformArgument("dev_center_project_id")]
    public required TerraformValue<string> DevCenterProjectId
    {
        get => new TerraformReference<string>(this, "dev_center_project_id");
        set => SetArgument("dev_center_project_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDevCenterProjectEnvironmentTypeDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    [TerraformArgument("creator_role_assignment_roles")]
    public TerraformSet<string> CreatorRoleAssignmentRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "creator_role_assignment_roles").ResolveNodes(ctx));
    }

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    [TerraformArgument("deployment_target_id")]
    public TerraformValue<string> DeploymentTargetId
    {
        get => new TerraformReference<string>(this, "deployment_target_id");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_role_assignment attribute.
    /// </summary>
    [TerraformArgument("user_role_assignment")]
    public TerraformSet<object> UserRoleAssignment
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "user_role_assignment").ResolveNodes(ctx));
    }

}
