using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameters.
/// </summary>
public class GoogleParameterManagerParametersDataSource : TerraformDataSource
{
    public GoogleParameterManagerParametersDataSource(string name) : base("google_parameter_manager_parameters", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("parameters");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering. List only parameters matching the filter. 
    /// If filter is empty, all parameters are listed.
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
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

}
