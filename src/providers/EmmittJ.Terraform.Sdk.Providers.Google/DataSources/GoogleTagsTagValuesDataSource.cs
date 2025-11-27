using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_tags_tag_values Terraform data source.
/// Retrieves information about a google_tags_tag_values.
/// </summary>
public partial class GoogleTagsTagValuesDataSource(string name) : TerraformDataSource("google_tags_tag_values", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValuesAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "values").ResolveNodes(ctx));
    }

}
