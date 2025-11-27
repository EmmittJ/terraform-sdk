using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_images Terraform data source.
/// Retrieves information about a google_compute_images.
/// </summary>
public partial class GoogleComputeImagesDataSource(string name) : TerraformDataSource("google_compute_images", name)
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Images
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "images").ResolveNodes(ctx));
    }

}
