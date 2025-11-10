using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_filter_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsIpFilterRuleBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    public required TerraformProperty<string> IpMask
    {
        set => SetProperty("ip_mask", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        set => SetProperty("target", value);
    }

}

/// <summary>
/// Block type for linked_hub in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsLinkedHubBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_weight attribute.
    /// </summary>
    public TerraformProperty<double>? AllocationWeight
    {
        set => SetProperty("allocation_weight", value);
    }

    /// <summary>
    /// The apply_allocation_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyAllocationPolicy
    {
        set => SetProperty("apply_allocation_policy", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformProperty<string> ConnectionString
    {
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        set => SetProperty("hostname", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        set => SetProperty("location", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsSkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformProperty<double> Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iothub_dps resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIothubDps : TerraformResource
{
    public AzurermIothubDps(string name) : base("azurerm_iothub_dps", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("device_provisioning_host_name");
        SetOutput("id_scope");
        SetOutput("service_operations_host_name");
        SetOutput("allocation_policy");
        SetOutput("data_residency_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    public TerraformProperty<string> AllocationPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allocation_policy");
        set => SetProperty("allocation_policy", value);
    }

    /// <summary>
    /// The data_residency_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DataResidencyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("data_residency_enabled");
        set => SetProperty("data_residency_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// Block for ip_filter_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermIothubDpsIpFilterRuleBlock>? IpFilterRule
    {
        set => SetProperty("ip_filter_rule", value);
    }

    /// <summary>
    /// Block for linked_hub.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermIothubDpsLinkedHubBlock>? LinkedHub
    {
        set => SetProperty("linked_hub", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermIothubDpsSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubDpsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    public TerraformExpression DeviceProvisioningHostName => this["device_provisioning_host_name"];

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    public TerraformExpression IdScope => this["id_scope"];

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    public TerraformExpression ServiceOperationsHostName => this["service_operations_host_name"];

}
