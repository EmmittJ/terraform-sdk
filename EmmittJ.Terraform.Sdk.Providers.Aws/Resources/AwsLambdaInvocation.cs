using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_invocation resource.
/// </summary>
public class AwsLambdaInvocation : TerraformResource
{
    public AwsLambdaInvocation(string name) : base("aws_lambda_invocation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("result");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public string? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name")?.Value;
        set => this.WithProperty("function_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The input attribute.
    /// </summary>
    public string? Input
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input")?.Value;
        set => this.WithProperty("input", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lifecycle_scope attribute.
    /// </summary>
    public string? LifecycleScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifecycle_scope")?.Value;
        set => this.WithProperty("lifecycle_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public string? Qualifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qualifier")?.Value;
        set => this.WithProperty("qualifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The terraform_key attribute.
    /// </summary>
    public string? TerraformKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terraform_key")?.Value;
        set => this.WithProperty("terraform_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}
