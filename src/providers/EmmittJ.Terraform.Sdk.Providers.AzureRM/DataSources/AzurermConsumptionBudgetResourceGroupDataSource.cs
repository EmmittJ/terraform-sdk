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
public class AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_consumption_budget_resource_group.
/// </summary>
public class AzurermConsumptionBudgetResourceGroupDataSource : TerraformDataSource
{
    public AzurermConsumptionBudgetResourceGroupDataSource(string name) : base("azurerm_consumption_budget_resource_group", name)
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
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformArgument("resource_group_id")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => new TerraformReference<string>(this, "resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [TerraformArgument("amount")]
    public TerraformValue<double> Amount
    {
        get => new TerraformReference<double>(this, "amount");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformArgument("filter")]
    public TerraformList<object> Filter
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The notification attribute.
    /// </summary>
    [TerraformArgument("notification")]
    public TerraformList<object> Notification
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "notification").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    [TerraformArgument("time_grain")]
    public TerraformValue<string> TimeGrain
    {
        get => new TerraformReference<string>(this, "time_grain");
    }

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    [TerraformArgument("time_period")]
    public TerraformList<object> TimePeriod
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "time_period").ResolveNodes(ctx));
    }

}
