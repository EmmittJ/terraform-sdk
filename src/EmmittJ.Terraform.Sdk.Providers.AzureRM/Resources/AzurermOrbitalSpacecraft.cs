using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for links in .
/// Nesting mode: list
/// </summary>
public class AzurermOrbitalSpacecraftLinksBlock : TerraformBlock
{
    /// <summary>
    /// The bandwidth_mhz attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthMhz is required")]
    public required TerraformProperty<double> BandwidthMhz
    {
        get => GetProperty<TerraformProperty<double>>("bandwidth_mhz");
        set => WithProperty("bandwidth_mhz", value);
    }

    /// <summary>
    /// The center_frequency_mhz attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CenterFrequencyMhz is required")]
    public required TerraformProperty<double> CenterFrequencyMhz
    {
        get => GetProperty<TerraformProperty<double>>("center_frequency_mhz");
        set => WithProperty("center_frequency_mhz", value);
    }

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
public class AzurermOrbitalSpacecraftTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_orbital_spacecraft resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermOrbitalSpacecraft : TerraformResource
{
    public AzurermOrbitalSpacecraft(string name) : base("azurerm_orbital_spacecraft", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The norad_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoradId is required")]
    public required TerraformProperty<string> NoradId
    {
        get => GetProperty<TerraformProperty<string>>("norad_id");
        set => this.WithProperty("norad_id", value);
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
    /// The title_line attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TitleLine is required")]
    public required TerraformProperty<string> TitleLine
    {
        get => GetProperty<TerraformProperty<string>>("title_line");
        set => this.WithProperty("title_line", value);
    }

    /// <summary>
    /// The two_line_elements attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TwoLineElements is required")]
    public List<TerraformProperty<string>>? TwoLineElements
    {
        get => GetProperty<List<TerraformProperty<string>>>("two_line_elements");
        set => this.WithProperty("two_line_elements", value);
    }

    /// <summary>
    /// Block for links.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Links block(s) required")]
    public List<AzurermOrbitalSpacecraftLinksBlock>? Links
    {
        get => GetProperty<List<AzurermOrbitalSpacecraftLinksBlock>>("links");
        set => this.WithProperty("links", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOrbitalSpacecraftTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOrbitalSpacecraftTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
