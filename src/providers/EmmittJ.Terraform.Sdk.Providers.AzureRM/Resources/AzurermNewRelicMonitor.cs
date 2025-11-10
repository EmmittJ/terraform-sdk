using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicMonitorIdentityBlock : TerraformBlock
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
public class AzurermNewRelicMonitorPlanBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EffectiveDate is required")]
    public required TerraformProperty<string> EffectiveDate
    {
        set => SetProperty("effective_date", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? PlanId
    {
        set => SetProperty("plan_id", value);
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
public class AzurermNewRelicMonitorTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Block type for user in .
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicMonitorUserBlock : TerraformBlock
{
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
/// Manages a azurerm_new_relic_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNewRelicMonitor : TerraformResource
{
    public AzurermNewRelicMonitor(string name) : base("azurerm_new_relic_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_creation_source");
        SetOutput("account_id");
        SetOutput("id");
        SetOutput("ingestion_key");
        SetOutput("location");
        SetOutput("name");
        SetOutput("org_creation_source");
        SetOutput("organization_id");
        SetOutput("resource_group_name");
        SetOutput("user_id");
    }

    /// <summary>
    /// The account_creation_source attribute.
    /// </summary>
    public TerraformProperty<string> AccountCreationSource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_creation_source");
        set => SetProperty("account_creation_source", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
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
    /// The ingestion_key attribute.
    /// </summary>
    public TerraformProperty<string> IngestionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ingestion_key");
        set => SetProperty("ingestion_key", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The org_creation_source attribute.
    /// </summary>
    public TerraformProperty<string> OrgCreationSource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_creation_source");
        set => SetProperty("org_creation_source", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformProperty<string> OrganizationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization_id");
        set => SetProperty("organization_id", value);
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
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string> UserId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_id");
        set => SetProperty("user_id", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermNewRelicMonitorIdentityBlock>? Identity
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
    public List<AzurermNewRelicMonitorPlanBlock>? Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNewRelicMonitorTimeoutsBlock? Timeouts
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
    public List<AzurermNewRelicMonitorUserBlock>? User
    {
        set => SetProperty("user", value);
    }

}
