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
    public TerraformProperty<string>? AuthorizationType
    {
        get => GetProperty<TerraformProperty<string>>("authorization_type");
        set => this.WithProperty("authorization_type", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public TerraformProperty<string>? FunctionName
    {
        get => GetProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
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
    /// The invoke_mode attribute.
    /// </summary>
    public TerraformProperty<string>? InvokeMode
    {
        get => GetProperty<TerraformProperty<string>>("invoke_mode");
        set => this.WithProperty("invoke_mode", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string>? Qualifier
    {
        get => GetProperty<TerraformProperty<string>>("qualifier");
        set => this.WithProperty("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
