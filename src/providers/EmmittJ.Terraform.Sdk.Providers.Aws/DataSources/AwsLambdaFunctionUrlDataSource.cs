using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_function_url.
/// </summary>
public class AwsLambdaFunctionUrlDataSource : TerraformDataSource
{
    public AwsLambdaFunctionUrlDataSource(string name) : base("aws_lambda_function_url", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authorization_type");
        SetOutput("cors");
        SetOutput("creation_time");
        SetOutput("function_arn");
        SetOutput("function_url");
        SetOutput("invoke_mode");
        SetOutput("last_modified_time");
        SetOutput("url_id");
        SetOutput("function_name");
        SetOutput("id");
        SetOutput("qualifier");
        SetOutput("region");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_name");
        set => SetProperty("function_name", value);
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
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string> Qualifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qualifier");
        set => SetProperty("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformExpression AuthorizationType => this["authorization_type"];

    /// <summary>
    /// The cors attribute.
    /// </summary>
    public TerraformExpression Cors => this["cors"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformExpression FunctionArn => this["function_arn"];

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    public TerraformExpression FunctionUrl => this["function_url"];

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    public TerraformExpression InvokeMode => this["invoke_mode"];

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    public TerraformExpression UrlId => this["url_id"];

}
