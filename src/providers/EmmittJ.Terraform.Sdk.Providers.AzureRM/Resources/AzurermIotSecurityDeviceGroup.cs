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
        set => SetProperty("connection_from_ips_not_allowed", value);
    }

    /// <summary>
    /// The connection_to_ips_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ConnectionToIpsNotAllowed
    {
        set => SetProperty("connection_to_ips_not_allowed", value);
    }

    /// <summary>
    /// The local_users_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? LocalUsersNotAllowed
    {
        set => SetProperty("local_users_not_allowed", value);
    }

    /// <summary>
    /// The processes_not_allowed attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProcessesNotAllowed
    {
        set => SetProperty("processes_not_allowed", value);
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
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The max attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    public required TerraformProperty<double> Max
    {
        set => SetProperty("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    public required TerraformProperty<double> Min
    {
        set => SetProperty("min", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("id");
        SetOutput("iothub_id");
        SetOutput("name");
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
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformProperty<string> IothubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iothub_id");
        set => SetProperty("iothub_id", value);
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
    /// Block for allow_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowRule block(s) allowed")]
    public List<AzurermIotSecurityDeviceGroupAllowRuleBlock>? AllowRule
    {
        set => SetProperty("allow_rule", value);
    }

    /// <summary>
    /// Block for range_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermIotSecurityDeviceGroupRangeRuleBlock>? RangeRule
    {
        set => SetProperty("range_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIotSecurityDeviceGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
