using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_locations.
/// </summary>
public class AwsDxLocationsDataSource : TerraformDataSource
{
    public AwsDxLocationsDataSource(string name) : base("aws_dx_locations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location_codes");
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
    /// The location_codes attribute.
    /// </summary>
    public TerraformExpression LocationCodes => this["location_codes"];

}
