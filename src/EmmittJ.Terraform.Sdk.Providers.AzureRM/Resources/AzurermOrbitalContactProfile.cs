using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_orbital_contact_profile resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermOrbitalContactProfile : TerraformResource
{
    public AzurermOrbitalContactProfile(string name) : base("azurerm_orbital_contact_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_tracking attribute.
    /// </summary>
    public string? AutoTracking
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_tracking")?.Value;
        set => this.WithProperty("auto_tracking", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_hub_uri attribute.
    /// </summary>
    public string? EventHubUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_hub_uri")?.Value;
        set => this.WithProperty("event_hub_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimum_elevation_degrees attribute.
    /// </summary>
    public double? MinimumElevationDegrees
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_elevation_degrees")?.Value;
        set => this.WithProperty("minimum_elevation_degrees", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The minimum_variable_contact_duration attribute.
    /// </summary>
    public string? MinimumVariableContactDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_variable_contact_duration")?.Value;
        set => this.WithProperty("minimum_variable_contact_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The network_configuration_subnet_id attribute.
    /// </summary>
    public string? NetworkConfigurationSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_configuration_subnet_id")?.Value;
        set => this.WithProperty("network_configuration_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
