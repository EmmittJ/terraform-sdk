using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConsumptionBudgetSubscriptionDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_consumption_budget_subscription Terraform data source.
/// Retrieves information about a azurerm_consumption_budget_subscription.
/// </summary>
public partial class AzurermConsumptionBudgetSubscriptionDataSource(string name) : TerraformDataSource("azurerm_consumption_budget_subscription", name)
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
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
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
    public AzurermConsumptionBudgetSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConsumptionBudgetSubscriptionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
