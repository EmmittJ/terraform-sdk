using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_forwarding_rules.
/// </summary>
public class GoogleComputeForwardingRulesDataSource : TerraformDataSource
{
    public GoogleComputeForwardingRulesDataSource(string name) : base("google_compute_forwarding_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("rules");
        SetOutput("id");
        SetOutput("project");
        SetOutput("region");
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
    /// The rules attribute.
    /// </summary>
    public TerraformExpression Rules => this["rules"];

}
