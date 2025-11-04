using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_function_event_invoke_config resource.
/// </summary>
public class AwsLambdaFunctionEventInvokeConfig : TerraformResource
{
    public AwsLambdaFunctionEventInvokeConfig(string name) : base("aws_lambda_function_event_invoke_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    public double? MaximumEventAgeInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_event_age_in_seconds")?.Value;
        set => this.WithProperty("maximum_event_age_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public double? MaximumRetryAttempts
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_retry_attempts")?.Value;
        set => this.WithProperty("maximum_retry_attempts", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public string? Qualifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qualifier")?.Value;
        set => this.WithProperty("qualifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
