using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermConsumptionBudgetResourceGroupDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_consumption_budget_resource_group Terraform data source.
/// Retrieves information about a azurerm_consumption_budget_resource_group.
/// </summary>
public partial class AzurermConsumptionBudgetResourceGroupDataSource(string name) : TerraformDataSource("azurerm_consumption_budget_resource_group", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => new TerraformReference<string>(this, "resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    public TerraformValue<double> Amount
    {
        get => new TerraformReference<double>(this, "amount");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Filter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The notification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Notification
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "notification").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformValue<string> TimeGrain
    {
        get => new TerraformReference<string>(this, "time_grain");
    }

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TimePeriod
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "time_period").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
