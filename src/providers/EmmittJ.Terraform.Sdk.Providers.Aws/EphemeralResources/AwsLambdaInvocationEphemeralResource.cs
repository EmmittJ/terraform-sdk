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
        this.WithOutput("executed_version");
        this.WithOutput("function_error");
        this.WithOutput("log_result");
        this.WithOutput("result");
        this.WithOutput("status_code");
    }

    /// <summary>
    /// The client_context attribute.
    /// </summary>
    public TerraformProperty<string>? ClientContext
    {
        get => GetProperty<TerraformProperty<string>>("client_context");
        set => this.WithProperty("client_context", value);
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
    /// The log_type attribute.
    /// </summary>
    public TerraformProperty<string>? LogType
    {
        get => GetProperty<TerraformProperty<string>>("log_type");
        set => this.WithProperty("log_type", value);
    }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformProperty<string> Payload
    {
        get => GetRequiredProperty<TerraformProperty<string>>("payload");
        set => this.WithProperty("payload", value);
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
