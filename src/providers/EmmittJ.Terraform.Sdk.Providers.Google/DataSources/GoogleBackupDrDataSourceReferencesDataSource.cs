using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_backup_dr_data_source_references Terraform data source.
/// Retrieves information about a google_backup_dr_data_source_references.
/// </summary>
public partial class GoogleBackupDrDataSourceReferencesDataSource(string name) : TerraformDataSource("google_backup_dr_data_source_references", name)
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
    /// The location to list the data source references from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The resource type to get the data source references for. Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// A list of the data source references found.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataSourceReferences
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_source_references").ResolveNodes(ctx));
    }

}
