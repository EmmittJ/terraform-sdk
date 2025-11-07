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
    public TerraformLiteralProperty<string>? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FilterType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_type");
        set => this.WithProperty("filter_type", value);
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
    /// The sql_filter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlFilter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_filter");
        set => this.WithProperty("sql_filter", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    public TerraformExpression SqlFilterCompatibilityLevel => this["sql_filter_compatibility_level"];

}
