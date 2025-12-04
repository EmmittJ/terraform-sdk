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
        get => GetArgument<TerraformValue<string>>("digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformValue<string> ImageUrl
        => AsReference("image_url");

}
