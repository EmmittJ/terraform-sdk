using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_servicebus_subscription_rule resource.
/// </summary>
public class AzurermServicebusSubscriptionRule : TerraformResource
{
    public AzurermServicebusSubscriptionRule(string name) : base("azurerm_servicebus_subscription_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sql_filter_compatibility_level");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    public TerraformProperty<string>? FilterType
    {
        get => GetProperty<TerraformProperty<string>>("filter_type");
        set => this.WithProperty("filter_type", value);
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
    /// The sql_filter attribute.
    /// </summary>
    public TerraformProperty<string>? SqlFilter
    {
        get => GetProperty<TerraformProperty<string>>("sql_filter");
        set => this.WithProperty("sql_filter", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    public TerraformExpression SqlFilterCompatibilityLevel => this["sql_filter_compatibility_level"];

}
