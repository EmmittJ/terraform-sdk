using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pcc_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServicePccRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Precedence is required")]
    public required TerraformProperty<double> Precedence
    {
        get => GetRequiredProperty<TerraformProperty<double>>("precedence");
        set => WithProperty("precedence", value);
    }

    /// <summary>
    /// The traffic_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrafficControlEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("traffic_control_enabled");
        set => WithProperty("traffic_control_enabled", value);
    }

}

/// <summary>
/// Block type for service_qos_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServiceServiceQosPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_and_retention_priority_level attribute.
    /// </summary>
    public TerraformProperty<double>? AllocationAndRetentionPriorityLevel
    {
        get => GetProperty<TerraformProperty<double>>("allocation_and_retention_priority_level");
        set => WithProperty("allocation_and_retention_priority_level", value);
    }

    /// <summary>
    /// The preemption_capability attribute.
    /// </summary>
    public TerraformProperty<string>? PreemptionCapability
    {
        get => GetProperty<TerraformProperty<string>>("preemption_capability");
        set => WithProperty("preemption_capability", value);
    }

    /// <summary>
    /// The preemption_vulnerability attribute.
    /// </summary>
    public TerraformProperty<string>? PreemptionVulnerability
    {
        get => GetProperty<TerraformProperty<string>>("preemption_vulnerability");
        set => WithProperty("preemption_vulnerability", value);
    }

    /// <summary>
    /// The qos_indicator attribute.
    /// </summary>
    public TerraformProperty<double>? QosIndicator
    {
        get => GetProperty<TerraformProperty<double>>("qos_indicator");
        set => WithProperty("qos_indicator", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mobile_network_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkService : TerraformResource
{
    public AzurermMobileNetworkService(string name) : base("azurerm_mobile_network_service", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformProperty<string> MobileNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mobile_network_id");
        set => this.WithProperty("mobile_network_id", value);
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
    /// The service_precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrecedence is required")]
    public required TerraformProperty<double> ServicePrecedence
    {
        get => GetRequiredProperty<TerraformProperty<double>>("service_precedence");
        set => this.WithProperty("service_precedence", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for pcc_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PccRule block(s) required")]
    public List<AzurermMobileNetworkServicePccRuleBlock>? PccRule
    {
        get => GetProperty<List<AzurermMobileNetworkServicePccRuleBlock>>("pcc_rule");
        set => this.WithProperty("pcc_rule", value);
    }

    /// <summary>
    /// Block for service_qos_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceQosPolicy block(s) allowed")]
    public List<AzurermMobileNetworkServiceServiceQosPolicyBlock>? ServiceQosPolicy
    {
        get => GetProperty<List<AzurermMobileNetworkServiceServiceQosPolicyBlock>>("service_qos_policy");
        set => this.WithProperty("service_qos_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMobileNetworkServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
