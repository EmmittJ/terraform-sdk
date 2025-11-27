using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_alloydb_supported_database_flags Terraform data source.
/// Retrieves information about a google_alloydb_supported_database_flags.
/// </summary>
public partial class GoogleAlloydbSupportedDatabaseFlagsDataSource(string name) : TerraformDataSource("google_alloydb_supported_database_flags", name)
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
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The supported_database_flags attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SupportedDatabaseFlags
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "supported_database_flags").ResolveNodes(ctx));
    }

}
