using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for allow_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermIotSecurityDeviceGroupAllowRuleBlock : TerraformBlock
{
    /// <summary>
    /// The connection_from_ips_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ConnectionFromIpsNotAllowed
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("connection_from_ips_not_allowed");
        set => WithProperty("connection_from_ips_not_allowed", value);
    }

    /// <summary>
    /// The connection_to_ips_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ConnectionToIpsNotAllowed
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("connection_to_ips_not_allowed");
        set => WithProperty("connection_to_ips_not_allowed", value);
    }

    /// <summary>
    /// The local_users_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? LocalUsersNotAllowed
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("local_users_not_allowed");
        set => WithProperty("local_users_not_allowed", value);
    }

    /// <summary>
    /// The processes_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProcessesNotAllowed
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("processes_not_allowed");
        set => WithProperty("processes_not_allowed", value);
    }

}

/// <summary>
/// Block type for range_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermIotSecurityDeviceGroupRangeRuleBlock : TerraformBlock
{
    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<string> Duration
    {
        get => GetRequiredProperty<TerraformProperty<string>>("duration");
        set => WithProperty("duration", value);
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    public required TerraformProperty<double> Max
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max");
        set => WithProperty("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformProperty<double> Min
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min");
        set => WithProperty("min", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIotSecurityDeviceGroupTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformProperty<string> IothubId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("iothub_id");
        set => this.WithProperty("iothub_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for allow_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowRule block(s) allowed")]
    public List<AzurermIotSecurityDeviceGroupAllowRuleBlock>? AllowRule
    {
        get => GetProperty<List<AzurermIotSecurityDeviceGroupAllowRuleBlock>>("allow_rule");
        set => this.WithProperty("allow_rule", value);
    }

    /// <summary>
    /// Block for range_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermIotSecurityDeviceGroupRangeRuleBlock>? RangeRule
    {
        get => GetProperty<HashSet<AzurermIotSecurityDeviceGroupRangeRuleBlock>>("range_rule");
        set => this.WithProperty("range_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIotSecurityDeviceGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermIotSecurityDeviceGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
