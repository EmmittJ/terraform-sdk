using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_subnetworks.
/// </summary>
public class GoogleComputeSubnetworksDataSource : TerraformDataSource
{
    public GoogleComputeSubnetworksDataSource(string name) : base("google_compute_subnetworks", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("subnetworks");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
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
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The subnetworks attribute.
    /// </summary>
    public TerraformExpression Subnetworks => this["subnetworks"];

}
