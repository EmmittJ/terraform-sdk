using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for environment_properties in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorEnvironmentPropertiesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorPlanBlock : TerraformBlock
{
    /// <summary>
    /// The billing_cycle attribute.
    /// </summary>
    public TerraformProperty<string>? BillingCycle
    {
        get => GetProperty<TerraformProperty<string>>("billing_cycle");
        set => WithProperty("billing_cycle", value);
    }

    /// <summary>
    /// The effective_date attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveDate
    {
        get => GetProperty<TerraformProperty<string>>("effective_date");
        set => WithProperty("effective_date", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformProperty<string> Plan
    {
        get => GetProperty<TerraformProperty<string>>("plan");
        set => WithProperty("plan", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    public TerraformProperty<string>? UsageType
    {
        get => GetProperty<TerraformProperty<string>>("usage_type");
        set => WithProperty("usage_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceMonitorTimeoutsBlock : TerraformBlock
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
/// Block type for user in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorUserBlock : TerraformBlock
{
    /// <summary>
    /// The country attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Country is required")]
    public required TerraformProperty<string> Country
    {
        get => GetProperty<TerraformProperty<string>>("country");
        set => WithProperty("country", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    public required TerraformProperty<string> FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => WithProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    public required TerraformProperty<string> LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => WithProperty("last_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

}

/// <summary>
/// Manages a azurerm_dynatrace_monitor resource.
/// </summary>
public class AzurermDynatraceMonitor : TerraformResource
{
    public AzurermDynatraceMonitor(string name) : base("azurerm_dynatrace_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MarketplaceSubscription is required")]
    public required TerraformProperty<string> MarketplaceSubscription
    {
        get => GetProperty<TerraformProperty<string>>("marketplace_subscription");
        set => this.WithProperty("marketplace_subscription", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("monitoring_enabled");
        set => this.WithProperty("monitoring_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// Block for environment_properties.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDynatraceMonitorEnvironmentPropertiesBlock>? EnvironmentProperties
    {
        get => GetProperty<List<AzurermDynatraceMonitorEnvironmentPropertiesBlock>>("environment_properties");
        set => this.WithProperty("environment_properties", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermDynatraceMonitorIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermDynatraceMonitorIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plan block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermDynatraceMonitorPlanBlock>? Plan
    {
        get => GetProperty<List<AzurermDynatraceMonitorPlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDynatraceMonitorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDynatraceMonitorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    public List<AzurermDynatraceMonitorUserBlock>? User
    {
        get => GetProperty<List<AzurermDynatraceMonitorUserBlock>>("user");
        set => this.WithProperty("user", value);
    }

}
