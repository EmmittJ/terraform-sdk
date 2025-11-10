using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_lambda_function_event_invoke_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaFunctionEventInvokeConfig : TerraformResource
{
    public AwsLambdaFunctionEventInvokeConfig(string name) : base("aws_lambda_function_event_invoke_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("function_name");
        SetOutput("id");
        SetOutput("maximum_event_age_in_seconds");
        SetOutput("maximum_retry_attempts");
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
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> MaximumEventAgeInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_event_age_in_seconds");
        set => SetProperty("maximum_event_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double> MaximumRetryAttempts
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_retry_attempts");
        set => SetProperty("maximum_retry_attempts", value);
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
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public List<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock>? DestinationConfig
    {
        set => SetProperty("destination_config", value);
    }

}
