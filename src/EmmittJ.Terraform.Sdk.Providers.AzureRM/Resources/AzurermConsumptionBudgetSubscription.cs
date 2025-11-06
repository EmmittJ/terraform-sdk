using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_consumption_budget_subscription resource.
/// </summary>
public class AzurermConsumptionBudgetSubscription : TerraformResource
{
    public AzurermConsumptionBudgetSubscription(string name) : base("azurerm_consumption_budget_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    public double? Amount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("amount")?.Value;
        set => this.WithProperty("amount", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public string? Etag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("etag")?.Value;
        set => this.WithProperty("etag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public string? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id")?.Value;
        set => this.WithProperty("subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public string? TimeGrain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_grain")?.Value;
        set => this.WithProperty("time_grain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
