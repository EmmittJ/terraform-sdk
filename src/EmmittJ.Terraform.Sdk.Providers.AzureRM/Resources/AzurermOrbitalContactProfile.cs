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
    public TerraformProperty<string>? AutoTracking
    {
        get => GetProperty<TerraformProperty<string>>("auto_tracking");
        set => this.WithProperty("auto_tracking", value);
    }

    /// <summary>
    /// The event_hub_uri attribute.
    /// </summary>
    public TerraformProperty<string>? EventHubUri
    {
        get => GetProperty<TerraformProperty<string>>("event_hub_uri");
        set => this.WithProperty("event_hub_uri", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The minimum_elevation_degrees attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumElevationDegrees
    {
        get => GetProperty<TerraformProperty<double>>("minimum_elevation_degrees");
        set => this.WithProperty("minimum_elevation_degrees", value);
    }

    /// <summary>
    /// The minimum_variable_contact_duration attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumVariableContactDuration
    {
        get => GetProperty<TerraformProperty<string>>("minimum_variable_contact_duration");
        set => this.WithProperty("minimum_variable_contact_duration", value);
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
    /// The network_configuration_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkConfigurationSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("network_configuration_subnet_id");
        set => this.WithProperty("network_configuration_subnet_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
