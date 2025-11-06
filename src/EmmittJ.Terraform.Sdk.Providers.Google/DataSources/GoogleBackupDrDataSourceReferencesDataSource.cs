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
        this.DeclareOutput("data_source_references");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location to list the data source references from.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource type to get the data source references for. Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot;.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A list of the data source references found.
    /// </summary>
    public TerraformExpression DataSourceReferences => this["data_source_references"];

}
