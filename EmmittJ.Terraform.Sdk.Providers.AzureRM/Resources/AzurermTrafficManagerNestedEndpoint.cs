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
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    public string? EndpointLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_location")?.Value;
        set => this.WithProperty("endpoint_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    public List<string>? GeoMappings
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("geo_mappings")?.Value;
        set => this.WithProperty("geo_mappings", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimum_child_endpoints attribute.
    /// </summary>
    public double? MinimumChildEndpoints
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_child_endpoints")?.Value;
        set => this.WithProperty("minimum_child_endpoints", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv4 attribute.
    /// </summary>
    public double? MinimumRequiredChildEndpointsIpv4
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_required_child_endpoints_ipv4")?.Value;
        set => this.WithProperty("minimum_required_child_endpoints_ipv4", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv6 attribute.
    /// </summary>
    public double? MinimumRequiredChildEndpointsIpv6
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_required_child_endpoints_ipv6")?.Value;
        set => this.WithProperty("minimum_required_child_endpoints_ipv6", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public string? ProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_id")?.Value;
        set => this.WithProperty("profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public string? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id")?.Value;
        set => this.WithProperty("target_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public double? Weight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("weight")?.Value;
        set => this.WithProperty("weight", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
