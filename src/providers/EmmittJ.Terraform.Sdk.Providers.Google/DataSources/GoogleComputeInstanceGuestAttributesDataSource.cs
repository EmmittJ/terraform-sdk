using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_guest_attributes.
/// </summary>
public class GoogleComputeInstanceGuestAttributesDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGuestAttributesDataSource(string name) : base("google_compute_instance_guest_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("query_value");
        SetOutput("variable_value");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("query_path");
        SetOutput("region");
        SetOutput("variable_key");
        SetOutput("zone");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The query_path attribute.
    /// </summary>
    public TerraformProperty<string> QueryPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_path");
        set => SetProperty("query_path", value);
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
    /// The variable_key attribute.
    /// </summary>
    public TerraformProperty<string> VariableKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("variable_key");
        set => SetProperty("variable_key", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// The query_value attribute.
    /// </summary>
    public TerraformExpression QueryValue => this["query_value"];

    /// <summary>
    /// The variable_value attribute.
    /// </summary>
    public TerraformExpression VariableValue => this["variable_value"];

}
