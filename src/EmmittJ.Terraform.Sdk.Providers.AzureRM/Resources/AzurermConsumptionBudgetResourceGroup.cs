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
    public TerraformLiteralProperty<double>? Amount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("amount");
        set => this.WithProperty("amount", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Etag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("etag");
        set => this.WithProperty("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_id");
        set => this.WithProperty("resource_group_id", value);
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimeGrain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_grain");
        set => this.WithProperty("time_grain", value);
    }

}
