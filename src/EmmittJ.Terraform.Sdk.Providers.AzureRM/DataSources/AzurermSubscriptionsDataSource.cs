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
    public TerraformLiteralProperty<string>? DisplayNameContains
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name_contains");
        set => this.WithProperty("display_name_contains", value);
    }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name_prefix");
        set => this.WithProperty("display_name_prefix", value);
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
    /// The subscriptions attribute.
    /// </summary>
    public TerraformExpression Subscriptions => this["subscriptions"];

}
