using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutputenant_id");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionName is required")]
    public required TerraformProperty<string> SubscriptionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subscription_name");
        set => this.WithProperty("subscription_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSubscriptionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The Tenant ID to which the subscription belongs
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
