using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionUrlCorsBlock : TerraformBlock
{
    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowCredentials
    {
        set => SetProperty("allow_credentials", value);
    }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowHeaders
    {
        set => SetProperty("allow_headers", value);
    }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowMethods
    {
        set => SetProperty("allow_methods", value);
    }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowOrigins
    {
        set => SetProperty("allow_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExposeHeaders
    {
        set => SetProperty("expose_headers", value);
    }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAge
    {
        set => SetProperty("max_age", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLambdaFunctionUrlTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_lambda_function_url resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaFunctionUrl : TerraformResource
{
    public AwsLambdaFunctionUrl(string name) : base("aws_lambda_function_url", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("function_arn");
        SetOutput("function_url");
        SetOutput("url_id");
        SetOutput("authorization_type");
        SetOutput("function_name");
        SetOutput("id");
        SetOutput("invoke_mode");
        SetOutput("qualifier");
        SetOutput("region");
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    public required TerraformProperty<string> AuthorizationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_type");
        set => SetProperty("authorization_type", value);
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
    /// The invoke_mode attribute.
    /// </summary>
    public TerraformProperty<string> InvokeMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("invoke_mode");
        set => SetProperty("invoke_mode", value);
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
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public List<AwsLambdaFunctionUrlCorsBlock>? Cors
    {
        set => SetProperty("cors", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLambdaFunctionUrlTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
