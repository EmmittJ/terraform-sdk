using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_regions.
/// </summary>
public class GoogleComputeRegionsDataSource : TerraformDataSource
{
    public GoogleComputeRegionsDataSource(string name) : base("google_compute_regions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("names");
        SetOutput("id");
        SetOutput("project");
        SetOutput("status");
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

}
