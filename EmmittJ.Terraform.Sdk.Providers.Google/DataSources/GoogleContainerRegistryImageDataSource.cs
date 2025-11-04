using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_registry_image.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class GoogleContainerRegistryImageDataSource : TerraformDataSource
{
    public GoogleContainerRegistryImageDataSource(string name) : base("google_container_registry_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("image_url");
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    public string? Digest
    {
        get => GetProperty<TerraformLiteralProperty<string>>("digest")?.Value;
        set => this.WithProperty("digest", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public string? Tag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag")?.Value;
        set => this.WithProperty("tag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformExpression ImageUrl => this["image_url"];

}
