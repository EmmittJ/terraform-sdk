using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for campaign_hook in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppCampaignHookBlock : ITerraformBlock
{
    /// <summary>
    /// The lambda_function_name attribute.
    /// </summary>
    [TerraformPropertyName("lambda_function_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LambdaFunctionName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The web_url attribute.
    /// </summary>
    [TerraformPropertyName("web_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WebUrl { get; set; }

}

/// <summary>
/// Block type for limits in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppLimitsBlock : ITerraformBlock
{
    /// <summary>
    /// The daily attribute.
    /// </summary>
    [TerraformPropertyName("daily")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Daily { get; set; }

    /// <summary>
    /// The maximum_duration attribute.
    /// </summary>
    [TerraformPropertyName("maximum_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumDuration { get; set; }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    [TerraformPropertyName("messages_per_second")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MessagesPerSecond { get; set; }

    /// <summary>
    /// The total attribute.
    /// </summary>
    [TerraformPropertyName("total")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Total { get; set; }

}

/// <summary>
/// Block type for quiet_time in .
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppQuietTimeBlock : ITerraformBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [TerraformPropertyName("end")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [TerraformPropertyName("start")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Start { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for campaign_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CampaignHook block(s) allowed")]
    [TerraformPropertyName("campaign_hook")]
    public TerraformList<TerraformBlock<AwsPinpointAppCampaignHookBlock>>? CampaignHook { get; set; } = new();

    /// <summary>
    /// Block for limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    [TerraformPropertyName("limits")]
    public TerraformList<TerraformBlock<AwsPinpointAppLimitsBlock>>? Limits { get; set; } = new();

    /// <summary>
    /// Block for quiet_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuietTime block(s) allowed")]
    [TerraformPropertyName("quiet_time")]
    public TerraformList<TerraformBlock<AwsPinpointAppQuietTimeBlock>>? QuietTime { get; set; } = new();

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformPropertyName("application_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
