using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointLocation
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_location");
        set => this.WithProperty("endpoint_location", value);
    }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    public TerraformProperty<List<string>>? GeoMappings
    {
        get => GetProperty<TerraformProperty<List<string>>>("geo_mappings");
        set => this.WithProperty("geo_mappings", value);
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
    /// The minimum_child_endpoints attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumChildEndpoints
    {
        get => GetProperty<TerraformProperty<double>>("minimum_child_endpoints");
        set => this.WithProperty("minimum_child_endpoints", value);
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv4 attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumRequiredChildEndpointsIpv4
    {
        get => GetProperty<TerraformProperty<double>>("minimum_required_child_endpoints_ipv4");
        set => this.WithProperty("minimum_required_child_endpoints_ipv4", value);
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv6 attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumRequiredChildEndpointsIpv6
    {
        get => GetProperty<TerraformProperty<double>>("minimum_required_child_endpoints_ipv6");
        set => this.WithProperty("minimum_required_child_endpoints_ipv6", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileId
    {
        get => GetProperty<TerraformProperty<string>>("profile_id");
        set => this.WithProperty("profile_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => this.WithProperty("weight", value);
    }

}
