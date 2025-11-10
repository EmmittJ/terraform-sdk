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
        set => SetProperty("direction", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The polarization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Polarization is required")]
    public required TerraformProperty<string> Polarization
    {
        set => SetProperty("polarization", value);
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
/// Manages a azurerm_orbital_contact_profile resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermOrbitalContactProfile : TerraformResource
{
    public AzurermOrbitalContactProfile(string name) : base("azurerm_orbital_contact_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_tracking");
        SetOutput("event_hub_uri");
        SetOutput("id");
        SetOutput("location");
        SetOutput("minimum_elevation_degrees");
        SetOutput("minimum_variable_contact_duration");
        SetOutput("name");
        SetOutput("network_configuration_subnet_id");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The auto_tracking attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoTracking is required")]
    public required TerraformProperty<string> AutoTracking
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_tracking");
        set => SetProperty("auto_tracking", value);
    }

    /// <summary>
    /// The event_hub_uri attribute.
    /// </summary>
    public TerraformProperty<string> EventHubUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_hub_uri");
        set => SetProperty("event_hub_uri", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The minimum_elevation_degrees attribute.
    /// </summary>
    public TerraformProperty<double> MinimumElevationDegrees
    {
        get => GetRequiredOutput<TerraformProperty<double>>("minimum_elevation_degrees");
        set => SetProperty("minimum_elevation_degrees", value);
    }

    /// <summary>
    /// The minimum_variable_contact_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumVariableContactDuration is required")]
    public required TerraformProperty<string> MinimumVariableContactDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimum_variable_contact_duration");
        set => SetProperty("minimum_variable_contact_duration", value);
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
    /// The network_configuration_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfigurationSubnetId is required")]
    public required TerraformProperty<string> NetworkConfigurationSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_configuration_subnet_id");
        set => SetProperty("network_configuration_subnet_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for links.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Links is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Links block(s) required")]
    public List<AzurermOrbitalContactProfileLinksBlock>? Links
    {
        set => SetProperty("links", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOrbitalContactProfileTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
