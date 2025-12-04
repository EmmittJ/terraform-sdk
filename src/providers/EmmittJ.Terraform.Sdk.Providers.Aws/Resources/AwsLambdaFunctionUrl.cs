using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors in AwsLambdaFunctionUrl.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionUrlCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? AllowCredentials
    {
        get => GetArgument<TerraformValue<bool>>("allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    public TerraformSet<string>? AllowHeaders
    {
        get => GetArgument<TerraformSet<string>>("allow_headers");
        set => SetArgument("allow_headers", value);
    }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    public TerraformSet<string>? AllowMethods
    {
        get => GetArgument<TerraformSet<string>>("allow_methods");
        set => SetArgument("allow_methods", value);
    }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    public TerraformSet<string>? AllowOrigins
    {
        get => GetArgument<TerraformSet<string>>("allow_origins");
        set => SetArgument("allow_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public TerraformSet<string>? ExposeHeaders
    {
        get => GetArgument<TerraformSet<string>>("expose_headers");
        set => SetArgument("expose_headers", value);
    }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    public TerraformValue<double>? MaxAge
    {
        get => GetArgument<TerraformValue<double>>("max_age");
        set => SetArgument("max_age", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLambdaFunctionUrl.
/// Nesting mode: single
/// </summary>
public class AwsLambdaFunctionUrlTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_lambda_function_url Terraform resource.
/// Manages a aws_lambda_function_url resource.
/// </summary>
public partial class AwsLambdaFunctionUrl(string name) : TerraformResource("aws_lambda_function_url", name)
{
    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    public required TerraformValue<string> AuthorizationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("authorization_type");
        set => SetArgument("authorization_type", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    public TerraformValue<string>? InvokeMode
    {
        get => GetArgument<TerraformValue<string>>("invoke_mode");
        set => SetArgument("invoke_mode", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformValue<string>? Qualifier
    {
        get => GetArgument<TerraformValue<string>>("qualifier");
        set => SetArgument("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformValue<string> FunctionArn
        => AsReference("function_arn");

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    public TerraformValue<string> FunctionUrl
        => AsReference("function_url");

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    public TerraformValue<string> UrlId
        => AsReference("url_id");

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AwsLambdaFunctionUrlCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionUrlCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLambdaFunctionUrlTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLambdaFunctionUrlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
