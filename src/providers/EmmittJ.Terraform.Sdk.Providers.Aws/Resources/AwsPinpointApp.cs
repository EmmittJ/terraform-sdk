using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for campaign_hook in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppCampaignHookBlock
{
    /// <summary>
    /// The lambda_function_name attribute.
    /// </summary>
    [TerraformPropertyName("lambda_function_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LambdaFunctionName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The web_url attribute.
    /// </summary>
    [TerraformPropertyName("web_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WebUrl { get; set; }

}

/// <summary>
/// Block type for limits in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppLimitsBlock
{
    /// <summary>
    /// The daily attribute.
    /// </summary>
    [TerraformPropertyName("daily")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Daily { get; set; }

    /// <summary>
    /// The maximum_duration attribute.
    /// </summary>
    [TerraformPropertyName("maximum_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaximumDuration { get; set; }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    [TerraformPropertyName("messages_per_second")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MessagesPerSecond { get; set; }

    /// <summary>
    /// The total attribute.
    /// </summary>
    [TerraformPropertyName("total")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Total { get; set; }

}

/// <summary>
/// Block type for quiet_time in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppQuietTimeBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [TerraformPropertyName("end")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [TerraformPropertyName("start")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Start { get; set; }

}

/// <summary>
/// Manages a aws_pinpoint_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsPinpointApp : TerraformResource
{
    public AwsPinpointApp(string name) : base("aws_pinpoint_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for campaign_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CampaignHook block(s) allowed")]
    [TerraformPropertyName("campaign_hook")]
    public TerraformList<TerraformBlock<AwsPinpointAppCampaignHookBlock>>? CampaignHook { get; set; }

    /// <summary>
    /// Block for limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    [TerraformPropertyName("limits")]
    public TerraformList<TerraformBlock<AwsPinpointAppLimitsBlock>>? Limits { get; set; }

    /// <summary>
    /// Block for quiet_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuietTime block(s) allowed")]
    [TerraformPropertyName("quiet_time")]
    public TerraformList<TerraformBlock<AwsPinpointAppQuietTimeBlock>>? QuietTime { get; set; }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformPropertyName("application_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationId => new TerraformReference(this, "application_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
