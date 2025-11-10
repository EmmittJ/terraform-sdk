using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for links in .
/// Nesting mode: list
/// </summary>
public class AzurermOrbitalContactProfileLinksBlock : TerraformBlock
{
    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformProperty<string> Direction
    {
        get => GetProperty<TerraformProperty<string>>("direction");
        set => WithProperty("direction", value);
    }

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
    /// The polarization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Polarization is required")]
    public required TerraformProperty<string> Polarization
    {
        get => GetProperty<TerraformProperty<string>>("polarization");
        set => WithProperty("polarization", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOrbitalContactProfileTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoTracking is required")]
    public required TerraformProperty<string> AutoTracking
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumVariableContactDuration is required")]
    public required TerraformProperty<string> MinimumVariableContactDuration
    {
        get => GetProperty<TerraformProperty<string>>("minimum_variable_contact_duration");
        set => this.WithProperty("minimum_variable_contact_duration", value);
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
    /// The network_configuration_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfigurationSubnetId is required")]
    public required TerraformProperty<string> NetworkConfigurationSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("network_configuration_subnet_id");
        set => this.WithProperty("network_configuration_subnet_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for links.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Links block(s) required")]
    public List<AzurermOrbitalContactProfileLinksBlock>? Links
    {
        get => GetProperty<List<AzurermOrbitalContactProfileLinksBlock>>("links");
        set => this.WithProperty("links", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOrbitalContactProfileTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOrbitalContactProfileTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
