using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_event_api_destination resource.
/// </summary>
public class AwsCloudwatchEventApiDestination : TerraformResource
{
    public AwsCloudwatchEventApiDestination(string name) : base("aws_cloudwatch_event_api_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("connection_arn");
        SetOutput("description");
        SetOutput("http_method");
        SetOutput("id");
        SetOutput("invocation_endpoint");
        SetOutput("invocation_rate_limit_per_second");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionArn is required")]
    public required TerraformProperty<string> ConnectionArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_arn");
        set => SetProperty("connection_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformProperty<string> HttpMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_method");
        set => SetProperty("http_method", value);
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
    /// The invocation_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvocationEndpoint is required")]
    public required TerraformProperty<string> InvocationEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("invocation_endpoint");
        set => SetProperty("invocation_endpoint", value);
    }

    /// <summary>
    /// The invocation_rate_limit_per_second attribute.
    /// </summary>
    public TerraformProperty<double> InvocationRateLimitPerSecond
    {
        get => GetRequiredOutput<TerraformProperty<double>>("invocation_rate_limit_per_second");
        set => SetProperty("invocation_rate_limit_per_second", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
