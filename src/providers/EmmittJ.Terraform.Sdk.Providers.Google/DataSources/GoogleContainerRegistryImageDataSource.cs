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
        SetOutput("image_url");
        SetOutput("digest");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
        SetOutput("tag");
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    public TerraformProperty<string> Digest
    {
        get => GetRequiredOutput<TerraformProperty<string>>("digest");
        set => SetProperty("digest", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string> Tag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tag");
        set => SetProperty("tag", value);
    }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformExpression ImageUrl => this["image_url"];

}
