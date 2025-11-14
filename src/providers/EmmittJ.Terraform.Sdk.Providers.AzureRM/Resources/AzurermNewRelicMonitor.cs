using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicMonitorIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicMonitorPlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plan";

    /// <summary>
    /// The billing_cycle attribute.
    /// </summary>
    [TerraformArgument("billing_cycle")]
    public TerraformValue<string>? BillingCycle
    {
        get => new TerraformReference<string>(this, "billing_cycle");
        set => SetArgument("billing_cycle", value);
    }

    /// <summary>
    /// The effective_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EffectiveDate is required")]
    [TerraformArgument("effective_date")]
    public required TerraformValue<string> EffectiveDate
    {
        get => new TerraformReference<string>(this, "effective_date");
        set => SetArgument("effective_date", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [TerraformArgument("plan_id")]
    public TerraformValue<string>? PlanId
    {
        get => new TerraformReference<string>(this, "plan_id");
        set => SetArgument("plan_id", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    [TerraformArgument("usage_type")]
    public TerraformValue<string>? UsageType
    {
        get => new TerraformReference<string>(this, "usage_type");
        set => SetArgument("usage_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNewRelicMonitorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Block type for user in .
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicMonitorUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user";

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformArgument("email")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    [TerraformArgument("first_name")]
    public required TerraformValue<string> FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    [TerraformArgument("last_name")]
    public required TerraformValue<string> LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformArgument("phone_number")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
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
    }

    /// <summary>
    /// The account_creation_source attribute.
    /// </summary>
    [TerraformArgument("account_creation_source")]
    public TerraformValue<string>? AccountCreationSource
    {
        get => new TerraformReference<string>(this, "account_creation_source");
        set => SetArgument("account_creation_source", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformArgument("account_id")]
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ingestion_key attribute.
    /// </summary>
    [TerraformArgument("ingestion_key")]
    public TerraformValue<string>? IngestionKey
    {
        get => new TerraformReference<string>(this, "ingestion_key");
        set => SetArgument("ingestion_key", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The org_creation_source attribute.
    /// </summary>
    [TerraformArgument("org_creation_source")]
    public TerraformValue<string>? OrgCreationSource
    {
        get => new TerraformReference<string>(this, "org_creation_source");
        set => SetArgument("org_creation_source", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [TerraformArgument("organization_id")]
    public TerraformValue<string> OrganizationId
    {
        get => new TerraformReference<string>(this, "organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformArgument("user_id")]
    public TerraformValue<string>? UserId
    {
        get => new TerraformReference<string>(this, "user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermNewRelicMonitorIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plan block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformArgument("plan")]
    public required TerraformList<AzurermNewRelicMonitorPlanBlock> Plan { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNewRelicMonitorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    [TerraformArgument("user")]
    public required TerraformList<AzurermNewRelicMonitorUserBlock> User { get; set; } = new();

}
