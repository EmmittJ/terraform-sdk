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
        => CreateReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => CreateReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("billing_cycle");
        set => SetArgument("billing_cycle", value);
    }

    /// <summary>
    /// The effective_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EffectiveDate is required")]
    public required TerraformValue<string> EffectiveDate
    {
        get => GetRequiredArgument<TerraformValue<string>>("effective_date");
        set => SetArgument("effective_date", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public TerraformValue<string>? PlanId
    {
        get => GetArgument<TerraformValue<string>>("plan_id");
        set => SetArgument("plan_id", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    public TerraformValue<string>? UsageType
    {
        get => GetArgument<TerraformValue<string>>("usage_type");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    public required TerraformValue<string> FirstName
    {
        get => GetRequiredArgument<TerraformValue<string>>("first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    public required TerraformValue<string> LastName
    {
        get => GetRequiredArgument<TerraformValue<string>>("last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
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
        get => GetArgument<TerraformValue<string>>("account_creation_source");
        set => SetArgument("account_creation_source", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id") ?? CreateReference("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ingestion_key attribute.
    /// </summary>
    public TerraformValue<string>? IngestionKey
    {
        get => GetArgument<TerraformValue<string>>("ingestion_key");
        set => SetArgument("ingestion_key", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The org_creation_source attribute.
    /// </summary>
    public TerraformValue<string>? OrgCreationSource
    {
        get => GetArgument<TerraformValue<string>>("org_creation_source");
        set => SetArgument("org_creation_source", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformValue<string> OrganizationId
    {
        get => GetArgument<TerraformValue<string>>("organization_id") ?? CreateReference("organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string>? UserId
    {
        get => GetArgument<TerraformValue<string>>("user_id");
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
