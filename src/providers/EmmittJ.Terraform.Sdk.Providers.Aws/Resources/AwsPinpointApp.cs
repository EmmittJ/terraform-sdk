using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for campaign_hook in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppCampaignHookBlock : TerraformBlock
{
    /// <summary>
    /// The lambda_function_name attribute.
    /// </summary>
    public TerraformProperty<string>? LambdaFunctionName
    {
        set => SetProperty("lambda_function_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The web_url attribute.
    /// </summary>
    public TerraformProperty<string>? WebUrl
    {
        set => SetProperty("web_url", value);
    }

}

/// <summary>
/// Block type for limits in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppLimitsBlock : TerraformBlock
{
    /// <summary>
    /// The daily attribute.
    /// </summary>
    public TerraformProperty<double>? Daily
    {
        set => SetProperty("daily", value);
    }

    /// <summary>
    /// The maximum_duration attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumDuration
    {
        set => SetProperty("maximum_duration", value);
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? MessagesPerSecond
    {
        set => SetProperty("messages_per_second", value);
    }

    /// <summary>
    /// The total attribute.
    /// </summary>
    public TerraformProperty<double>? Total
    {
        set => SetProperty("total", value);
    }

}

/// <summary>
/// Block type for quiet_time in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppQuietTimeBlock : TerraformBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformProperty<string>? End
    {
        set => SetProperty("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformProperty<string>? Start
    {
        set => SetProperty("start", value);
    }

}

/// <summary>
/// Manages a aws_pinpoint_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsPinpointApp : TerraformResource
{
    public AwsPinpointApp(string name) : base("aws_pinpoint_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_id");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for campaign_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CampaignHook block(s) allowed")]
    public List<AwsPinpointAppCampaignHookBlock>? CampaignHook
    {
        set => SetProperty("campaign_hook", value);
    }

    /// <summary>
    /// Block for limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    public List<AwsPinpointAppLimitsBlock>? Limits
    {
        set => SetProperty("limits", value);
    }

    /// <summary>
    /// Block for quiet_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuietTime block(s) allowed")]
    public List<AwsPinpointAppQuietTimeBlock>? QuietTime
    {
        set => SetProperty("quiet_time", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformExpression ApplicationId => this["application_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
