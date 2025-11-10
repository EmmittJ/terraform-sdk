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
        set => SetProperty("read", value);
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
        SetOutput("subscriptions");
        SetOutput("display_name_contains");
        SetOutput("display_name_prefix");
        SetOutput("id");
    }

    /// <summary>
    /// The display_name_contains attribute.
    /// </summary>
    public TerraformProperty<string> DisplayNameContains
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name_contains");
        set => SetProperty("display_name_contains", value);
    }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> DisplayNamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name_prefix");
        set => SetProperty("display_name_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The subscriptions attribute.
    /// </summary>
    public TerraformExpression Subscriptions => this["subscriptions"];

}
