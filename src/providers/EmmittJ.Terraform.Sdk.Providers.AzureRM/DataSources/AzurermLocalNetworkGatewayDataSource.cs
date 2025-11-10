using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLocalNetworkGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_local_network_gateway.
/// </summary>
public class AzurermLocalNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermLocalNetworkGatewayDataSource(string name) : base("azurerm_local_network_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_space");
        SetOutput("bgp_settings");
        SetOutput("gateway_address");
        SetOutput("gateway_fqdn");
        SetOutput("location");
        SetOutput("tags");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLocalNetworkGatewayDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public TerraformExpression AddressSpace => this["address_space"];

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    public TerraformExpression BgpSettings => this["bgp_settings"];

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    public TerraformExpression GatewayAddress => this["gateway_address"];

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    public TerraformExpression GatewayFqdn => this["gateway_fqdn"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
