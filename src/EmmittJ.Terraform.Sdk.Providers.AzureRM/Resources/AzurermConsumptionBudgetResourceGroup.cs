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
    public TerraformProperty<double>? Amount
    {
        get => GetProperty<TerraformProperty<double>>("amount");
        set => this.WithProperty("amount", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupId
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_id");
        set => this.WithProperty("resource_group_id", value);
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    public TerraformProperty<string>? TimeGrain
    {
        get => GetProperty<TerraformProperty<string>>("time_grain");
        set => this.WithProperty("time_grain", value);
    }

}
