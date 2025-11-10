using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_header in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerNestedEndpointCustomHeaderBlock : TerraformBlock
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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerNestedEndpointSubnetBlock : TerraformBlock
{
    /// <summary>
    /// The first attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First is required")]
    public required TerraformProperty<string> First
    {
        set => SetProperty("first", value);
    }

    /// <summary>
    /// The last attribute.
    /// </summary>
    public TerraformProperty<string>? Last
    {
        set => SetProperty("last", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<double>? Scope
    {
        set => SetProperty("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerNestedEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_traffic_manager_nested_endpoint resource.
/// </summary>
public class AzurermTrafficManagerNestedEndpoint : TerraformResource
{
    public AzurermTrafficManagerNestedEndpoint(string name) : base("azurerm_traffic_manager_nested_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("enabled");
        SetOutput("endpoint_location");
        SetOutput("geo_mappings");
        SetOutput("id");
        SetOutput("minimum_child_endpoints");
        SetOutput("minimum_required_child_endpoints_ipv4");
        SetOutput("minimum_required_child_endpoints_ipv6");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("profile_id");
        SetOutput("target_resource_id");
        SetOutput("weight");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    public TerraformProperty<string> EndpointLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_location");
        set => SetProperty("endpoint_location", value);
    }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    public List<TerraformProperty<string>> GeoMappings
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("geo_mappings");
        set => SetProperty("geo_mappings", value);
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
    /// The minimum_child_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumChildEndpoints is required")]
    public required TerraformProperty<double> MinimumChildEndpoints
    {
        get => GetRequiredOutput<TerraformProperty<double>>("minimum_child_endpoints");
        set => SetProperty("minimum_child_endpoints", value);
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv4 attribute.
    /// </summary>
    public TerraformProperty<double> MinimumRequiredChildEndpointsIpv4
    {
        get => GetRequiredOutput<TerraformProperty<double>>("minimum_required_child_endpoints_ipv4");
        set => SetProperty("minimum_required_child_endpoints_ipv4", value);
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv6 attribute.
    /// </summary>
    public TerraformProperty<double> MinimumRequiredChildEndpointsIpv6
    {
        get => GetRequiredOutput<TerraformProperty<double>>("minimum_required_child_endpoints_ipv6");
        set => SetProperty("minimum_required_child_endpoints_ipv6", value);
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
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformProperty<string> ProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_id");
        set => SetProperty("profile_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_resource_id");
        set => SetProperty("target_resource_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double> Weight
    {
        get => GetRequiredOutput<TerraformProperty<double>>("weight");
        set => SetProperty("weight", value);
    }

    /// <summary>
    /// Block for custom_header.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermTrafficManagerNestedEndpointCustomHeaderBlock>? CustomHeader
    {
        set => SetProperty("custom_header", value);
    }

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermTrafficManagerNestedEndpointSubnetBlock>? Subnet
    {
        set => SetProperty("subnet", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermTrafficManagerNestedEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
