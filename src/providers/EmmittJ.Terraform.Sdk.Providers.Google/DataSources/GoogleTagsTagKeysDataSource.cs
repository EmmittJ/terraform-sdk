using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_tags_tag_keys Terraform data source.
/// Retrieves information about a google_tags_tag_keys.
/// </summary>
public partial class GoogleTagsTagKeysDataSource(string name) : TerraformDataSource("google_tags_tag_keys", name)
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
    /// The keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeysAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "keys").ResolveNodes(ctx));
    }

}
