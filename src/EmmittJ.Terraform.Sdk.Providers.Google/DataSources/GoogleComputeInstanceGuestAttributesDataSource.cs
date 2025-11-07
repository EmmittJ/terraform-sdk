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
        this.DeclareOutput("query_value");
        this.DeclareOutput("variable_value");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The query_path attribute.
    /// </summary>
    public TerraformProperty<string>? QueryPath
    {
        get => GetProperty<TerraformProperty<string>>("query_path");
        set => this.WithProperty("query_path", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The variable_key attribute.
    /// </summary>
    public TerraformProperty<string>? VariableKey
    {
        get => GetProperty<TerraformProperty<string>>("variable_key");
        set => this.WithProperty("variable_key", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
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
