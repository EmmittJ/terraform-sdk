using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_networks.
/// </summary>
public class GoogleComputeNetworksDataSource : TerraformDataSource
{
    public GoogleComputeNetworksDataSource(string name) : base("google_compute_networks", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("networks");
        SetOutput("self_link");
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
    /// The networks attribute.
    /// </summary>
    public TerraformExpression Networks => this["networks"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
