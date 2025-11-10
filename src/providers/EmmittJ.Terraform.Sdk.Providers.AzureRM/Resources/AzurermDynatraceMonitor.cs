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
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("billing_cycle", value);
    }

    /// <summary>
    /// The effective_date attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveDate
    {
        set => SetProperty("effective_date", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformProperty<string> Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    public TerraformProperty<string>? UsageType
    {
        set => SetProperty("usage_type", value);
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
        set => SetProperty("country", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    public required TerraformProperty<string> FirstName
    {
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    public required TerraformProperty<string> LastName
    {
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        set => SetProperty("phone_number", value);
    }

}

/// <summary>
/// Manages a azurerm_dynatrace_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDynatraceMonitor : TerraformResource
{
    public AzurermDynatraceMonitor(string name) : base("azurerm_dynatrace_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("location");
        SetOutput("marketplace_subscription");
        SetOutput("monitoring_enabled");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MarketplaceSubscription is required")]
    public required TerraformProperty<string> MarketplaceSubscription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("marketplace_subscription");
        set => SetProperty("marketplace_subscription", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MonitoringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("monitoring_enabled");
        set => SetProperty("monitoring_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// Block for environment_properties.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDynatraceMonitorEnvironmentPropertiesBlock>? EnvironmentProperties
    {
        set => SetProperty("environment_properties", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermDynatraceMonitorIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plan block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermDynatraceMonitorPlanBlock>? Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDynatraceMonitorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    public List<AzurermDynatraceMonitorUserBlock>? User
    {
        set => SetProperty("user", value);
    }

}
