using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_container_registry_image Terraform data source.
/// Retrieves information about a google_container_registry_image.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleContainerRegistryImageDataSource(string name) : TerraformDataSource("google_container_registry_image", name)
{
    /// <summary>
    /// The digest attribute.
    /// </summary>
    public TerraformValue<string>? Digest
    {
        get => new TerraformReference<string>(this, "digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string> ImageUrl
    {
        get => new TerraformReference<string>(this, "image_url");
    }

}
