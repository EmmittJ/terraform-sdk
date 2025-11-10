using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_regional_parameters.
/// </summary>
public class GoogleParameterManagerRegionalParametersDataSource : TerraformDataSource
{
    public GoogleParameterManagerRegionalParametersDataSource(string name) : base("google_parameter_manager_regional_parameters", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("parameters");
    }

    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering. List only parameters matching the filter. 
    /// If filter is empty, all regional parameters are listed from specific location.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

}
