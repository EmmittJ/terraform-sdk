using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_function_url resource.
/// </summary>
public class AwsLambdaFunctionUrl : TerraformResource
{
    public AwsLambdaFunctionUrl(string name) : base("aws_lambda_function_url", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("function_arn");
        this.DeclareOutput("function_url");
        this.DeclareOutput("url_id");
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public string? AuthorizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_type")?.Value;
        set => this.WithProperty("authorization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The invoke_mode attribute.
    /// </summary>
    public string? InvokeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("invoke_mode")?.Value;
        set => this.WithProperty("invoke_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The function_arn attribute.
    /// </summary>
    public TerraformExpression FunctionArn => this["function_arn"];

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    public TerraformExpression FunctionUrl => this["function_url"];

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    public TerraformExpression UrlId => this["url_id"];

}
