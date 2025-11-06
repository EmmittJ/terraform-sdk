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
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    public string? FilterType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_type")?.Value;
        set => this.WithProperty("filter_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sql_filter attribute.
    /// </summary>
    public string? SqlFilter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_filter")?.Value;
        set => this.WithProperty("sql_filter", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sql_filter_compatibility_level attribute.
    /// </summary>
    public TerraformExpression SqlFilterCompatibilityLevel => this["sql_filter_compatibility_level"];

}
