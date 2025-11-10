using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_invocation ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsLambdaInvocationEphemeralResource : TerraformEphemeralResource
{
    public AwsLambdaInvocationEphemeralResource(string name) : base("aws_lambda_invocation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("executed_version");
        SetOutput("function_error");
        SetOutput("log_result");
        SetOutput("result");
        SetOutput("status_code");
        SetOutput("client_context");
        SetOutput("function_name");
        SetOutput("log_type");
        SetOutput("payload");
        SetOutput("qualifier");
        SetOutput("region");
    }

    /// <summary>
    /// The client_context attribute.
    /// </summary>
    public TerraformProperty<string> ClientContext
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_context");
        set => SetProperty("client_context", value);
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
    /// The log_type attribute.
    /// </summary>
    public TerraformProperty<string> LogType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_type");
        set => SetProperty("log_type", value);
    }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformProperty<string> Payload
    {
        get => GetRequiredOutput<TerraformProperty<string>>("payload");
        set => SetProperty("payload", value);
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
    /// The executed_version attribute.
    /// </summary>
    public TerraformExpression ExecutedVersion => this["executed_version"];

    /// <summary>
    /// The function_error attribute.
    /// </summary>
    public TerraformExpression FunctionError => this["function_error"];

    /// <summary>
    /// The log_result attribute.
    /// </summary>
    public TerraformExpression LogResult => this["log_result"];

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformExpression StatusCode => this["status_code"];

}
