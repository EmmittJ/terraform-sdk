using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_orbital_spacecraft resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The norad_id attribute.
    /// </summary>
    public TerraformProperty<string>? NoradId
    {
        get => GetProperty<TerraformProperty<string>>("norad_id");
        set => this.WithProperty("norad_id", value);
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

    /// <summary>
    /// The title_line attribute.
    /// </summary>
    public TerraformProperty<string>? TitleLine
    {
        get => GetProperty<TerraformProperty<string>>("title_line");
        set => this.WithProperty("title_line", value);
    }

    /// <summary>
    /// The two_line_elements attribute.
    /// </summary>
    public TerraformProperty<List<string>>? TwoLineElements
    {
        get => GetProperty<TerraformProperty<List<string>>>("two_line_elements");
        set => this.WithProperty("two_line_elements", value);
    }

}
