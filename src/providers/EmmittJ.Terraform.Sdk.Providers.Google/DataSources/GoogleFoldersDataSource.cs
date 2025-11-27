using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_folders Terraform data source.
/// Retrieves information about a google_folders.
/// </summary>
public partial class GoogleFoldersDataSource(string name) : TerraformDataSource("google_folders", name)
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
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformValue<string> ParentId
    {
        get => new TerraformReference<string>(this, "parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The folders attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Folders
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "folders").ResolveNodes(ctx));
    }

}
