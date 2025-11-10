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
        get => GetProperty<TerraformProperty<string>>("lambda_function_name");
        set => WithProperty("lambda_function_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The web_url attribute.
    /// </summary>
    public TerraformProperty<string>? WebUrl
    {
        get => GetProperty<TerraformProperty<string>>("web_url");
        set => WithProperty("web_url", value);
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
        get => GetProperty<TerraformProperty<double>>("daily");
        set => WithProperty("daily", value);
    }

    /// <summary>
    /// The maximum_duration attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumDuration
    {
        get => GetProperty<TerraformProperty<double>>("maximum_duration");
        set => WithProperty("maximum_duration", value);
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? MessagesPerSecond
    {
        get => GetProperty<TerraformProperty<double>>("messages_per_second");
        set => WithProperty("messages_per_second", value);
    }

    /// <summary>
    /// The total attribute.
    /// </summary>
    public TerraformProperty<double>? Total
    {
        get => GetProperty<TerraformProperty<double>>("total");
        set => WithProperty("total", value);
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
        get => GetProperty<TerraformProperty<string>>("end");
        set => WithProperty("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformProperty<string>? Start
    {
        get => GetProperty<TerraformProperty<string>>("start");
        set => WithProperty("start", value);
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
        this.WithOutput("application_id");
        this.WithOutput("arn");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for campaign_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CampaignHook block(s) allowed")]
    public List<AwsPinpointAppCampaignHookBlock>? CampaignHook
    {
        get => GetProperty<List<AwsPinpointAppCampaignHookBlock>>("campaign_hook");
        set => this.WithProperty("campaign_hook", value);
    }

    /// <summary>
    /// Block for limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    public List<AwsPinpointAppLimitsBlock>? Limits
    {
        get => GetProperty<List<AwsPinpointAppLimitsBlock>>("limits");
        set => this.WithProperty("limits", value);
    }

    /// <summary>
    /// Block for quiet_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuietTime block(s) allowed")]
    public List<AwsPinpointAppQuietTimeBlock>? QuietTime
    {
        get => GetProperty<List<AwsPinpointAppQuietTimeBlock>>("quiet_time");
        set => this.WithProperty("quiet_time", value);
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
