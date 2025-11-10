using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_header in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerAzureEndpointCustomHeaderBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerAzureEndpointSubnetBlock : TerraformBlock
{
    /// <summary>
    /// The first attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First is required")]
    public required TerraformProperty<string> First
    {
        get => GetProperty<TerraformProperty<string>>("first");
        set => WithProperty("first", value);
    }

    /// <summary>
    /// The last attribute.
    /// </summary>
    public TerraformProperty<string>? Last
    {
        get => GetProperty<TerraformProperty<string>>("last");
        set => WithProperty("last", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<double>? Scope
    {
        get => GetProperty<TerraformProperty<double>>("scope");
        set => WithProperty("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerAzureEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_traffic_manager_azure_endpoint resource.
/// </summary>
public class AzurermTrafficManagerAzureEndpoint : TerraformResource
{
    public AzurermTrafficManagerAzureEndpoint(string name) : base("azurerm_traffic_manager_azure_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The always_serve_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AlwaysServeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("always_serve_enabled");
        set => this.WithProperty("always_serve_enabled", value);
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
    /// The geo_mappings attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GeoMappings
    {
        get => GetProperty<List<TerraformProperty<string>>>("geo_mappings");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformProperty<string> ProfileId
    {
        get => GetProperty<TerraformProperty<string>>("profile_id");
        set => this.WithProperty("profile_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
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

    /// <summary>
    /// Block for custom_header.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermTrafficManagerAzureEndpointCustomHeaderBlock>? CustomHeader
    {
        get => GetProperty<List<AzurermTrafficManagerAzureEndpointCustomHeaderBlock>>("custom_header");
        set => this.WithProperty("custom_header", value);
    }

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermTrafficManagerAzureEndpointSubnetBlock>? Subnet
    {
        get => GetProperty<List<AzurermTrafficManagerAzureEndpointSubnetBlock>>("subnet");
        set => this.WithProperty("subnet", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermTrafficManagerAzureEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermTrafficManagerAzureEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
