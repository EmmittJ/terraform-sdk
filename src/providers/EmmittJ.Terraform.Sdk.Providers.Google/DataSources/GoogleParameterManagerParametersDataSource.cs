using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameters.
/// </summary>
public class GoogleParameterManagerParametersDataSource : TerraformDataSource
{
    public GoogleParameterManagerParametersDataSource(string name) : base("google_parameter_manager_parameters", name)
    {
    }

    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering. List only parameters matching the filter. 
    /// If filter is empty, all parameters are listed.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Parameters => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "parameters");

}
