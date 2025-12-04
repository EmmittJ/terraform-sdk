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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => GetArgument<TerraformValue<string>>("resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    public TerraformValue<double> Amount
        => AsReference("amount");

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Filter
        => AsReference("filter");

    /// <summary>
    /// The notification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Notification
        => AsReference("notification");

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformValue<string> TimeGrain
        => AsReference("time_grain");

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TimePeriod
        => AsReference("time_period");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConsumptionBudgetResourceGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
