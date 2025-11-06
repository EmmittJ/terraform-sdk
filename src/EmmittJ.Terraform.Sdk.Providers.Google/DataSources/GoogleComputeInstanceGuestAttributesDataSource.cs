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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_path attribute.
    /// </summary>
    public string? QueryPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_path")?.Value;
        set => this.WithProperty("query_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The variable_key attribute.
    /// </summary>
    public string? VariableKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("variable_key")?.Value;
        set => this.WithProperty("variable_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
