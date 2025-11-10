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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("tenant_id");
        SetOutput("alias");
        SetOutput("billing_scope_id");
        SetOutput("id");
        SetOutput("subscription_id");
        SetOutput("subscription_name");
        SetOutput("tags");
        SetOutput("workload");
    }

    /// <summary>
    /// The Alias Name of the subscription. If omitted a new UUID will be generated for this property.
    /// </summary>
    public TerraformProperty<string> Alias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias");
        set => SetProperty("alias", value);
    }

    /// <summary>
    /// The billing_scope_id attribute.
    /// </summary>
    public TerraformProperty<string> BillingScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_scope_id");
        set => SetProperty("billing_scope_id", value);
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
    /// The GUID of the Subscription.
    /// </summary>
    public TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// The Display Name for the Subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionName is required")]
    public required TerraformProperty<string> SubscriptionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_name");
        set => SetProperty("subscription_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The workload type for the Subscription. Possible values are `Production` (default) and `DevTest`.
    /// </summary>
    public TerraformProperty<string> Workload
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workload");
        set => SetProperty("workload", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The Tenant ID to which the subscription belongs
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
