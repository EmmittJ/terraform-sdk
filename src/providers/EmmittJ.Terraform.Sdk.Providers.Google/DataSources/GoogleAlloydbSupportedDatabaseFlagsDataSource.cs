using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_supported_database_flags.
/// </summary>
public class GoogleAlloydbSupportedDatabaseFlagsDataSource : TerraformDataSource
{
    public GoogleAlloydbSupportedDatabaseFlagsDataSource(string name) : base("google_alloydb_supported_database_flags", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("supported_database_flags");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
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
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The supported_database_flags attribute.
    /// </summary>
    public TerraformExpression SupportedDatabaseFlags => this["supported_database_flags"];

}
