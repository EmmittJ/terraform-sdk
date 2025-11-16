using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for allow_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermIotSecurityDeviceGroupAllowRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allow_rule";

    /// <summary>
    /// The connection_from_ips_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? ConnectionFromIpsNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "connection_from_ips_not_allowed").ResolveNodes(ctx));
        set => SetArgument("connection_from_ips_not_allowed", value);
    }

    /// <summary>
    /// The connection_to_ips_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? ConnectionToIpsNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "connection_to_ips_not_allowed").ResolveNodes(ctx));
        set => SetArgument("connection_to_ips_not_allowed", value);
    }

    /// <summary>
    /// The local_users_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? LocalUsersNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "local_users_not_allowed").ResolveNodes(ctx));
        set => SetArgument("local_users_not_allowed", value);
    }

    /// <summary>
    /// The processes_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? ProcessesNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "processes_not_allowed").ResolveNodes(ctx));
        set => SetArgument("processes_not_allowed", value);
    }

}

/// <summary>
/// Block type for range_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermIotSecurityDeviceGroupRangeRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range_rule";

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    public required TerraformValue<double> Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformValue<double> Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIotSecurityDeviceGroupTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_iot_security_device_group Terraform resource.
/// Manages a azurerm_iot_security_device_group resource.
/// </summary>
public partial class AzurermIotSecurityDeviceGroup(string name) : TerraformResource("azurerm_iot_security_device_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformValue<string> IothubId
    {
        get => new TerraformReference<string>(this, "iothub_id");
        set => SetArgument("iothub_id", value);
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
    /// AllowRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowRule block(s) allowed")]
    public AzurermIotSecurityDeviceGroupAllowRuleBlock? AllowRule
    {
        get => GetArgument<AzurermIotSecurityDeviceGroupAllowRuleBlock>("allow_rule");
        set => SetArgument("allow_rule", value);
    }

    /// <summary>
    /// RangeRule block (nesting mode: set).
    /// </summary>
    public AzurermIotSecurityDeviceGroupRangeRuleBlock? RangeRule
    {
        get => GetArgument<AzurermIotSecurityDeviceGroupRangeRuleBlock>("range_rule");
        set => SetArgument("range_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIotSecurityDeviceGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIotSecurityDeviceGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
