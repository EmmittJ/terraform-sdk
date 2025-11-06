using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_locations.
/// </summary>
public class GoogleAlloydbLocationsDataSource : TerraformDataSource
{
    public GoogleAlloydbLocationsDataSource(string name) : base("google_alloydb_locations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("locations");
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
    /// Project ID of the project.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformExpression Locations => this["locations"];

}
