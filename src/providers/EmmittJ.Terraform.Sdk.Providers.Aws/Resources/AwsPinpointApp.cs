using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for campaign_hook in .
/// Nesting mode: list
/// </summary>
public partial class AwsPinpointAppCampaignHookBlock : TerraformBlockBase
{
    /// <summary>
    /// The lambda_function_name attribute.
    /// </summary>
    [TerraformProperty("lambda_function_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LambdaFunctionName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The web_url attribute.
    /// </summary>
    [TerraformProperty("web_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WebUrl { get; set; }

}

/// <summary>
/// Block type for limits in .
/// Nesting mode: list
/// </summary>
public partial class AwsPinpointAppLimitsBlock : TerraformBlockBase
{
    /// <summary>
    /// The daily attribute.
    /// </summary>
    [TerraformProperty("daily")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Daily { get; set; }

    /// <summary>
    /// The maximum_duration attribute.
    /// </summary>
    [TerraformProperty("maximum_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumDuration { get; set; }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    [TerraformProperty("messages_per_second")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MessagesPerSecond { get; set; }

    /// <summary>
    /// The total attribute.
    /// </summary>
    [TerraformProperty("total")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Total { get; set; }

}

/// <summary>
/// Block type for quiet_time in .
/// Nesting mode: list
/// </summary>
public partial class AwsPinpointAppQuietTimeBlock : TerraformBlockBase
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [TerraformProperty("end")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [TerraformProperty("start")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Start { get; set; }

}

/// <summary>
/// Manages a aws_pinpoint_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsPinpointApp : TerraformResource
{
    public AwsPinpointApp(string name) : base("aws_pinpoint_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for campaign_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CampaignHook block(s) allowed")]
    [TerraformProperty("campaign_hook")]
    public TerraformList<TerraformBlock<AwsPinpointAppCampaignHookBlock>>? CampaignHook { get; set; }

    /// <summary>
    /// Block for limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    [TerraformProperty("limits")]
    public TerraformList<TerraformBlock<AwsPinpointAppLimitsBlock>>? Limits { get; set; }

    /// <summary>
    /// Block for quiet_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuietTime block(s) allowed")]
    [TerraformProperty("quiet_time")]
    public TerraformList<TerraformBlock<AwsPinpointAppQuietTimeBlock>>? QuietTime { get; set; }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformProperty("application_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApplicationId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
