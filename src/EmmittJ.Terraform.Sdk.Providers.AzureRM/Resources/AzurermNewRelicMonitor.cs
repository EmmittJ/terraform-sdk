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
public class AzurermNewRelicMonitorPlanBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EffectiveDate is required")]
    public required TerraformProperty<string> EffectiveDate
    {
        get => GetProperty<TerraformProperty<string>>("effective_date");
        set => WithProperty("effective_date", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? PlanId
    {
        get => GetProperty<TerraformProperty<string>>("plan_id");
        set => WithProperty("plan_id", value);
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
public class AzurermNewRelicMonitorTimeoutsBlock : TerraformBlock
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
    }

    /// <summary>
    /// The account_creation_source attribute.
    /// </summary>
    public TerraformProperty<string>? AccountCreationSource
    {
        get => GetProperty<TerraformProperty<string>>("account_creation_source");
        set => this.WithProperty("account_creation_source", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// The ingestion_key attribute.
    /// </summary>
    public TerraformProperty<string>? IngestionKey
    {
        get => GetProperty<TerraformProperty<string>>("ingestion_key");
        set => this.WithProperty("ingestion_key", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The org_creation_source attribute.
    /// </summary>
    public TerraformProperty<string>? OrgCreationSource
    {
        get => GetProperty<TerraformProperty<string>>("org_creation_source");
        set => this.WithProperty("org_creation_source", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("organization_id");
        set => this.WithProperty("organization_id", value);
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
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserId
    {
        get => GetProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermNewRelicMonitorIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermNewRelicMonitorIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plan block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermNewRelicMonitorPlanBlock>? Plan
    {
        get => GetProperty<List<AzurermNewRelicMonitorPlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNewRelicMonitorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNewRelicMonitorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    public List<AzurermNewRelicMonitorUserBlock>? User
    {
        get => GetProperty<List<AzurermNewRelicMonitorUserBlock>>("user");
        set => this.WithProperty("user", value);
    }

}
