using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for environment_properties in AzurermDynatraceMonitor.
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorEnvironmentPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_properties";

    /// <summary>
    /// EnvironmentInfo block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnvironmentInfo block(s) required")]
    public required TerraformList<AzurermDynatraceMonitorEnvironmentPropertiesBlockEnvironmentInfoBlock> EnvironmentInfo
    {
        get => GetRequiredArgument<TerraformList<AzurermDynatraceMonitorEnvironmentPropertiesBlockEnvironmentInfoBlock>>("environment_info");
        set => SetArgument("environment_info", value);
    }

}

/// <summary>
/// Block type for environment_info in AzurermDynatraceMonitorEnvironmentPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorEnvironmentPropertiesBlockEnvironmentInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_info";

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformValue<string> EnvironmentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("environment_id");
        set => SetArgument("environment_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermDynatraceMonitor.
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorIdentityBlock : TerraformBlock
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
/// Block type for plan in AzurermDynatraceMonitor.
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorPlanBlock : TerraformBlock
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
    public TerraformValue<string> EffectiveDate
        => CreateReference("effective_date");

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformValue<string> Plan
    {
        get => GetRequiredArgument<TerraformValue<string>>("plan");
        set => SetArgument("plan", value);
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
/// Block type for timeouts in AzurermDynatraceMonitor.
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceMonitorTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user in AzurermDynatraceMonitor.
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceMonitorUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user";

    /// <summary>
    /// The country attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Country is required")]
    public required TerraformValue<string> Country
    {
        get => GetRequiredArgument<TerraformValue<string>>("country");
        set => SetArgument("country", value);
    }

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
/// Represents a azurerm_dynatrace_monitor Terraform resource.
/// Manages a azurerm_dynatrace_monitor resource.
/// </summary>
public partial class AzurermDynatraceMonitor(string name) : TerraformResource("azurerm_dynatrace_monitor", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The marketplace_subscription attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MarketplaceSubscription is required")]
    public required TerraformValue<string> MarketplaceSubscription
    {
        get => GetRequiredArgument<TerraformValue<string>>("marketplace_subscription");
        set => SetArgument("marketplace_subscription", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MonitoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("monitoring_enabled");
        set => SetArgument("monitoring_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// EnvironmentProperties block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDynatraceMonitorEnvironmentPropertiesBlock>? EnvironmentProperties
    {
        get => GetArgument<TerraformList<AzurermDynatraceMonitorEnvironmentPropertiesBlock>>("environment_properties");
        set => SetArgument("environment_properties", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermDynatraceMonitorIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermDynatraceMonitorIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plan block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public required TerraformList<AzurermDynatraceMonitorPlanBlock> Plan
    {
        get => GetRequiredArgument<TerraformList<AzurermDynatraceMonitorPlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDynatraceMonitorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDynatraceMonitorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// User block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    public required TerraformList<AzurermDynatraceMonitorUserBlock> User
    {
        get => GetRequiredArgument<TerraformList<AzurermDynatraceMonitorUserBlock>>("user");
        set => SetArgument("user", value);
    }

}
