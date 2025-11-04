using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_subscriptions.
/// </summary>
public class AzurermSubscriptionsDataSource : TerraformDataSource
{
    public AzurermSubscriptionsDataSource(string name) : base("azurerm_subscriptions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("subscriptions");
    }

    /// <summary>
    /// The display_name_contains attribute.
    /// </summary>
    public string? DisplayNameContains
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name_contains")?.Value;
        set => this.WithProperty("display_name_contains", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    public string? DisplayNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name_prefix")?.Value;
        set => this.WithProperty("display_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The subscriptions attribute.
    /// </summary>
    public TerraformExpression Subscriptions => this["subscriptions"];

}
