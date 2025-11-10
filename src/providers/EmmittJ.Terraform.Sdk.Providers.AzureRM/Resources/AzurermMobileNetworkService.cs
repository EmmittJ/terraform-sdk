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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Precedence is required")]
    public required TerraformProperty<double> Precedence
    {
        set => SetProperty("precedence", value);
    }

    /// <summary>
    /// The traffic_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrafficControlEnabled
    {
        set => SetProperty("traffic_control_enabled", value);
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
        set => SetProperty("allocation_and_retention_priority_level", value);
    }

    /// <summary>
    /// The preemption_capability attribute.
    /// </summary>
    public TerraformProperty<string>? PreemptionCapability
    {
        set => SetProperty("preemption_capability", value);
    }

    /// <summary>
    /// The preemption_vulnerability attribute.
    /// </summary>
    public TerraformProperty<string>? PreemptionVulnerability
    {
        set => SetProperty("preemption_vulnerability", value);
    }

    /// <summary>
    /// The qos_indicator attribute.
    /// </summary>
    public TerraformProperty<double>? QosIndicator
    {
        set => SetProperty("qos_indicator", value);
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
        SetOutput("id");
        SetOutput("location");
        SetOutput("mobile_network_id");
        SetOutput("name");
        SetOutput("service_precedence");
        SetOutput("tags");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformProperty<string> MobileNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mobile_network_id");
        set => SetProperty("mobile_network_id", value);
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
    /// The service_precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrecedence is required")]
    public required TerraformProperty<double> ServicePrecedence
    {
        get => GetRequiredOutput<TerraformProperty<double>>("service_precedence");
        set => SetProperty("service_precedence", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for pcc_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PccRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PccRule block(s) required")]
    public List<AzurermMobileNetworkServicePccRuleBlock>? PccRule
    {
        set => SetProperty("pcc_rule", value);
    }

    /// <summary>
    /// Block for service_qos_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceQosPolicy block(s) allowed")]
    public List<AzurermMobileNetworkServiceServiceQosPolicyBlock>? ServiceQosPolicy
    {
        set => SetProperty("service_qos_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
