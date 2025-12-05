using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for allow_rule in AzurermIotSecurityDeviceGroup.
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
        get => GetArgument<TerraformSet<string>>("connection_from_ips_not_allowed");
        set => SetArgument("connection_from_ips_not_allowed", value);
    }

    /// <summary>
    /// The connection_to_ips_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? ConnectionToIpsNotAllowed
    {
        get => GetArgument<TerraformSet<string>>("connection_to_ips_not_allowed");
        set => SetArgument("connection_to_ips_not_allowed", value);
    }

    /// <summary>
    /// The local_users_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? LocalUsersNotAllowed
    {
        get => GetArgument<TerraformSet<string>>("local_users_not_allowed");
        set => SetArgument("local_users_not_allowed", value);
    }

    /// <summary>
    /// The processes_not_allowed attribute.
    /// </summary>
    public TerraformSet<string>? ProcessesNotAllowed
    {
        get => GetArgument<TerraformSet<string>>("processes_not_allowed");
        set => SetArgument("processes_not_allowed", value);
    }

}


/// <summary>
/// Block type for range_rule in AzurermIotSecurityDeviceGroup.
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
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    public required TerraformValue<double> Max
    {
        get => GetRequiredArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformValue<double> Min
    {
        get => GetRequiredArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

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
/// Block type for timeouts in AzurermIotSecurityDeviceGroup.
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformValue<string> IothubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("iothub_id");
        set => SetArgument("iothub_id", value);
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
    /// AllowRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowRule block(s) allowed")]
    public TerraformList<AzurermIotSecurityDeviceGroupAllowRuleBlock>? AllowRule
    {
        get => GetArgument<TerraformList<AzurermIotSecurityDeviceGroupAllowRuleBlock>>("allow_rule");
        set => SetArgument("allow_rule", value);
    }

    /// <summary>
    /// RangeRule block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermIotSecurityDeviceGroupRangeRuleBlock>? RangeRule
    {
        get => GetArgument<TerraformSet<AzurermIotSecurityDeviceGroupRangeRuleBlock>>("range_rule");
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
