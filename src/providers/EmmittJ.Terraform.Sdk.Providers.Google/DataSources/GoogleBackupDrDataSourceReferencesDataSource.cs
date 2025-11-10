using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_data_source_references.
/// </summary>
public class GoogleBackupDrDataSourceReferencesDataSource : TerraformDataSource
{
    public GoogleBackupDrDataSourceReferencesDataSource(string name) : base("google_backup_dr_data_source_references", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("data_source_references");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("resource_type");
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
    /// The location to list the data source references from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The resource type to get the data source references for. Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// A list of the data source references found.
    /// </summary>
    public TerraformExpression DataSourceReferences => this["data_source_references"];

}
