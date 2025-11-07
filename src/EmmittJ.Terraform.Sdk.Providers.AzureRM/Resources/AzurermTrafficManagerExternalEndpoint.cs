using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_traffic_manager_external_endpoint resource.
/// </summary>
public class AzurermTrafficManagerExternalEndpoint : TerraformResource
{
    public AzurermTrafficManagerExternalEndpoint(string name) : base("azurerm_traffic_manager_external_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The always_serve_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AlwaysServeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("always_serve_enabled");
        set => this.WithProperty("always_serve_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_location");
        set => this.WithProperty("endpoint_location", value);
    }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? GeoMappings
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("geo_mappings");
        set => this.WithProperty("geo_mappings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_id");
        set => this.WithProperty("profile_id", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Target
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Weight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("weight");
        set => this.WithProperty("weight", value);
    }

}
