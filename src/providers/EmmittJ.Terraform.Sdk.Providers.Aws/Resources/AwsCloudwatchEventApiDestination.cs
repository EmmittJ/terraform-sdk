using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_event_api_destination Terraform resource.
/// Manages a aws_cloudwatch_event_api_destination resource.
/// </summary>
public partial class AwsCloudwatchEventApiDestination(string name) : TerraformResource("aws_cloudwatch_event_api_destination", name)
{
    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionArn is required")]
    public required TerraformValue<string> ConnectionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_arn");
        set => SetArgument("connection_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformValue<string> HttpMethod
    {
        get => GetRequiredArgument<TerraformValue<string>>("http_method");
        set => SetArgument("http_method", value);
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
    /// The invocation_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvocationEndpoint is required")]
    public required TerraformValue<string> InvocationEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("invocation_endpoint");
        set => SetArgument("invocation_endpoint", value);
    }

    /// <summary>
    /// The invocation_rate_limit_per_second attribute.
    /// </summary>
    public TerraformValue<double>? InvocationRateLimitPerSecond
    {
        get => GetArgument<TerraformValue<double>>("invocation_rate_limit_per_second");
        set => SetArgument("invocation_rate_limit_per_second", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
