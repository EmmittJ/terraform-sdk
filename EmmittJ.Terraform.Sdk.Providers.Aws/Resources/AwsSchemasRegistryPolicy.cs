using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_schemas_registry_policy resource.
/// </summary>
public class AwsSchemasRegistryPolicy : TerraformResource
{
    public AwsSchemasRegistryPolicy(string name) : base("aws_schemas_registry_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public string? RegistryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_name")?.Value;
        set => this.WithProperty("registry_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
