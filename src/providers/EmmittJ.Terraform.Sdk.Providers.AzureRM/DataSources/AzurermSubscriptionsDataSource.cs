using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("subscriptions");
    }

    /// <summary>
    /// The display_name_contains attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayNameContains
    {
        get => GetProperty<TerraformProperty<string>>("display_name_contains");
        set => this.WithProperty("display_name_contains", value);
    }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("display_name_prefix");
        set => this.WithProperty("display_name_prefix", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSubscriptionsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The subscriptions attribute.
    /// </summary>
    public TerraformExpression Subscriptions => this["subscriptions"];

}
