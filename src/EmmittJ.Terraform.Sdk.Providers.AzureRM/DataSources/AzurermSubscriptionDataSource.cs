using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("display_name");
        this.DeclareOutput("location_placement_id");
        this.DeclareOutput("quota_id");
        this.DeclareOutput("spending_limit");
        this.DeclareOutput("state");
        this.DeclareOutput("tags");
        this.DeclareOutput("tenant_id");
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
    /// The subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
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
