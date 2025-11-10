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
        get => GetProperty<TerraformProperty<bool>>("allow_credentials");
        set => WithProperty("allow_credentials", value);
    }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allow_headers");
        set => WithProperty("allow_headers", value);
    }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allow_methods");
        set => WithProperty("allow_methods", value);
    }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowOrigins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allow_origins");
        set => WithProperty("allow_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExposeHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("expose_headers");
        set => WithProperty("expose_headers", value);
    }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAge
    {
        get => GetProperty<TerraformProperty<double>>("max_age");
        set => WithProperty("max_age", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
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
        this.WithOutput("function_arn");
        this.WithOutput("function_url");
        this.WithOutput("url_id");
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    public required TerraformProperty<string> AuthorizationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authorization_type");
        set => this.WithProperty("authorization_type", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_name");
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
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public List<AwsLambdaFunctionUrlCorsBlock>? Cors
    {
        get => GetProperty<List<AwsLambdaFunctionUrlCorsBlock>>("cors");
        set => this.WithProperty("cors", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLambdaFunctionUrlTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLambdaFunctionUrlTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
