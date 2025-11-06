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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The norad_id attribute.
    /// </summary>
    public string? NoradId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("norad_id")?.Value;
        set => this.WithProperty("norad_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The title_line attribute.
    /// </summary>
    public string? TitleLine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("title_line")?.Value;
        set => this.WithProperty("title_line", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The two_line_elements attribute.
    /// </summary>
    public List<string>? TwoLineElements
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("two_line_elements")?.Value;
        set => this.WithProperty("two_line_elements", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
