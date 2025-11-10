using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_interconnect_locations.
/// </summary>
public class GoogleComputeInterconnectLocationsDataSource : TerraformDataSource
{
    public GoogleComputeInterconnectLocationsDataSource(string name) : base("google_compute_interconnect_locations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("locations");
        SetOutput("id");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformExpression Locations => this["locations"];

}
