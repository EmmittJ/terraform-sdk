using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_subscription.
/// </summary>
public class AzurermSubscriptionDataSource : TerraformDataSource
{
    public AzurermSubscriptionDataSource(string name) : base("azurerm_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("display_name");
        SetOutput("location_placement_id");
        SetOutput("quota_id");
        SetOutput("spending_limit");
        SetOutput("state");
        SetOutput("tags");
        SetOutput("tenant_id");
        SetOutput("id");
        SetOutput("subscription_id");
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
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The location_placement_id attribute.
    /// </summary>
    public TerraformExpression LocationPlacementId => this["location_placement_id"];

    /// <summary>
    /// The quota_id attribute.
    /// </summary>
    public TerraformExpression QuotaId => this["quota_id"];

    /// <summary>
    /// The spending_limit attribute.
    /// </summary>
    public TerraformExpression SpendingLimit => this["spending_limit"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
