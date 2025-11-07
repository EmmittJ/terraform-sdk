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
    public TerraformProperty<string>? Digest
    {
        get => GetProperty<TerraformProperty<string>>("digest");
        set => this.WithProperty("digest", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        get => GetProperty<TerraformProperty<string>>("tag");
        set => this.WithProperty("tag", value);
    }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformExpression ImageUrl => this["image_url"];

}
