using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolAddressTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_lb_backend_address_pool_address resource.
/// </summary>
public class AzurermLbBackendAddressPoolAddress : TerraformResource
{
    public AzurermLbBackendAddressPoolAddress(string name) : base("azurerm_lb_backend_address_pool_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("inbound_nat_rule_port_mapping");
        SetOutput("backend_address_ip_configuration_id");
        SetOutput("backend_address_pool_id");
        SetOutput("id");
        SetOutput("ip_address");
        SetOutput("name");
        SetOutput("virtual_network_id");
    }

    /// <summary>
    /// For global load balancer, user needs to specify the `backend_address_ip_configuration_id` of the added regional load balancers
    /// </summary>
    public TerraformProperty<string> BackendAddressIpConfigurationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backend_address_ip_configuration_id");
        set => SetProperty("backend_address_ip_configuration_id", value);
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    public required TerraformProperty<string> BackendAddressPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backend_address_pool_id");
        set => SetProperty("backend_address_pool_id", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string> IpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address");
        set => SetProperty("ip_address", value);
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
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbBackendAddressPoolAddressTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The inbound_nat_rule_port_mapping attribute.
    /// </summary>
    public TerraformExpression InboundNatRulePortMapping => this["inbound_nat_rule_port_mapping"];

}
