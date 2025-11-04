using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_consumption_budget_resource_group resource.
/// </summary>
public class AzurermConsumptionBudgetResourceGroup : TerraformResource
{
    public AzurermConsumptionBudgetResourceGroup(string name) : base("azurerm_consumption_budget_resource_group", name)
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
    /// The resource_group_id attribute.
    /// </summary>
    public string? ResourceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_id")?.Value;
        set => this.WithProperty("resource_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
