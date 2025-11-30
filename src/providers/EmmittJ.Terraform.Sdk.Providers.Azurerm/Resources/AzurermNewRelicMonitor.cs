using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermNewRelicMonitor.
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicMonitorIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for plan in AzurermNewRelicMonitor.
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
    public TerraformValue<string>? BillingCycle
    {
        get => new TerraformReference<string>(this, "billing_cycle");
        set => SetArgument("billing_cycle", value);
    }

    /// <summary>
    /// The effective_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EffectiveDate is required")]
    public required TerraformValue<string> EffectiveDate
    {
        get => new TerraformReference<string>(this, "effective_date");
        set => SetArgument("effective_date", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformValue<string>? PlanId
    {
        get => new TerraformReference<string>(this, "plan_id");
        set => SetArgument("plan_id", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    public TerraformValue<string>? UsageType
    {
        get => new TerraformReference<string>(this, "usage_type");
        set => SetArgument("usage_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNewRelicMonitor.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Block type for user in AzurermNewRelicMonitor.
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
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    public required TerraformValue<string> FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    public required TerraformValue<string> LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

}


/// <summary>
/// Represents a azurerm_new_relic_monitor Terraform resource.
/// Manages a azurerm_new_relic_monitor resource.
/// </summary>
public partial class AzurermNewRelicMonitor(string name) : TerraformResource("azurerm_new_relic_monitor", name)
{
    /// <summary>
    /// The account_creation_source attribute.
    /// </summary>
    public TerraformValue<string>? AccountCreationSource
    {
        get => new TerraformReference<string>(this, "account_creation_source");
        set => SetArgument("account_creation_source", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ingestion_key attribute.
    /// </summary>
    public TerraformValue<string>? IngestionKey
    {
        get => new TerraformReference<string>(this, "ingestion_key");
        set => SetArgument("ingestion_key", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The org_creation_source attribute.
    /// </summary>
    public TerraformValue<string>? OrgCreationSource
    {
        get => new TerraformReference<string>(this, "org_creation_source");
        set => SetArgument("org_creation_source", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformValue<string> OrganizationId
    {
        get => new TerraformReference<string>(this, "organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string>? UserId
    {
        get => new TerraformReference<string>(this, "user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermNewRelicMonitorIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermNewRelicMonitorIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plan block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public required TerraformList<AzurermNewRelicMonitorPlanBlock> Plan
    {
        get => GetRequiredArgument<TerraformList<AzurermNewRelicMonitorPlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNewRelicMonitorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNewRelicMonitorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// User block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    public required TerraformList<AzurermNewRelicMonitorUserBlock> User
    {
        get => GetRequiredArgument<TerraformList<AzurermNewRelicMonitorUserBlock>>("user");
        set => SetArgument("user", value);
    }

}
