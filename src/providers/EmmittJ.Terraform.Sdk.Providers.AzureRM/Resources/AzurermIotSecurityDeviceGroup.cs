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
    [TerraformArgument("connection_from_ips_not_allowed")]
    public TerraformSet<string>? ConnectionFromIpsNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "connection_from_ips_not_allowed").ResolveNodes(ctx));
        set => SetArgument("connection_from_ips_not_allowed", value);
    }

    /// <summary>
    /// The connection_to_ips_not_allowed attribute.
    /// </summary>
    [TerraformArgument("connection_to_ips_not_allowed")]
    public TerraformSet<string>? ConnectionToIpsNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "connection_to_ips_not_allowed").ResolveNodes(ctx));
        set => SetArgument("connection_to_ips_not_allowed", value);
    }

    /// <summary>
    /// The local_users_not_allowed attribute.
    /// </summary>
    [TerraformArgument("local_users_not_allowed")]
    public TerraformSet<string>? LocalUsersNotAllowed
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "local_users_not_allowed").ResolveNodes(ctx));
        set => SetArgument("local_users_not_allowed", value);
    }

    /// <summary>
    /// The processes_not_allowed attribute.
    /// </summary>
    [TerraformArgument("processes_not_allowed")]
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
    [TerraformArgument("duration")]
    public required TerraformValue<string> Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    [TerraformArgument("max")]
    public required TerraformValue<double> Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    [TerraformArgument("min")]
    public required TerraformValue<double> Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_iot_security_device_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIotSecurityDeviceGroup : TerraformResource
{
    public AzurermIotSecurityDeviceGroup(string name) : base("azurerm_iot_security_device_group", name)
    {
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
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformArgument("iothub_id")]
    public required TerraformValue<string> IothubId
    {
        get => new TerraformReference<string>(this, "iothub_id");
        set => SetArgument("iothub_id", value);
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
    /// Block for allow_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowRule block(s) allowed")]
    [TerraformArgument("allow_rule")]
    public TerraformList<AzurermIotSecurityDeviceGroupAllowRuleBlock> AllowRule { get; set; } = new();

    /// <summary>
    /// Block for range_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("range_rule")]
    public TerraformSet<AzurermIotSecurityDeviceGroupRangeRuleBlock> RangeRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermIotSecurityDeviceGroupTimeoutsBlock Timeouts { get; set; } = new();

}
