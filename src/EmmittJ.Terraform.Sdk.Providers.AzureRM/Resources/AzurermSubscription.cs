using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_subscription resource.
/// </summary>
public class AzurermSubscription : TerraformResource
{
    public AzurermSubscription(string name) : base("azurerm_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("tenant_id");
    }

    /// <summary>
    /// The Alias Name of the subscription. If omitted a new UUID will be generated for this property.
    /// </summary>
    public TerraformProperty<string>? Alias
    {
        get => GetProperty<TerraformProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// The billing_scope_id attribute.
    /// </summary>
    public TerraformProperty<string>? BillingScopeId
    {
        get => GetProperty<TerraformProperty<string>>("billing_scope_id");
        set => this.WithProperty("billing_scope_id", value);
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
    /// The GUID of the Subscription.
    /// </summary>
    public TerraformProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// The Display Name for the Subscription.
    /// </summary>
    public TerraformProperty<string>? SubscriptionName
    {
        get => GetProperty<TerraformProperty<string>>("subscription_name");
        set => this.WithProperty("subscription_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workload type for the Subscription. Possible values are `Production` (default) and `DevTest`.
    /// </summary>
    public TerraformProperty<string>? Workload
    {
        get => GetProperty<TerraformProperty<string>>("workload");
        set => this.WithProperty("workload", value);
    }

    /// <summary>
    /// The Tenant ID to which the subscription belongs
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
