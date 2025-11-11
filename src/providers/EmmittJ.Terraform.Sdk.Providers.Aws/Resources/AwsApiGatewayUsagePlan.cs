using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for api_stages in .
/// Nesting mode: set
/// </summary>
public partial class AwsApiGatewayUsagePlanApiStagesBlock : TerraformBlockBase
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    [TerraformProperty("stage")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Stage { get; set; }

}

/// <summary>
/// Block type for quota_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayUsagePlanQuotaSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Limit is required")]
    [TerraformProperty("limit")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Limit { get; set; }

    /// <summary>
    /// The offset attribute.
    /// </summary>
    [TerraformProperty("offset")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Offset { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Period is required")]
    [TerraformProperty("period")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Period { get; set; }

}

/// <summary>
/// Block type for throttle_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayUsagePlanThrottleSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The burst_limit attribute.
    /// </summary>
    [TerraformProperty("burst_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BurstLimit { get; set; }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    [TerraformProperty("rate_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RateLimit { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_usage_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApiGatewayUsagePlan : TerraformResource
{
    public AwsApiGatewayUsagePlan(string name) : base("aws_api_gateway_usage_plan", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product_code attribute.
    /// </summary>
    [TerraformProperty("product_code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProductCode { get; set; }

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
    /// Block for api_stages.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("api_stages")]
    public TerraformSet<TerraformBlock<AwsApiGatewayUsagePlanApiStagesBlock>>? ApiStages { get; set; }

    /// <summary>
    /// Block for quota_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaSettings block(s) allowed")]
    [TerraformProperty("quota_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayUsagePlanQuotaSettingsBlock>>? QuotaSettings { get; set; }

    /// <summary>
    /// Block for throttle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThrottleSettings block(s) allowed")]
    [TerraformProperty("throttle_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayUsagePlanThrottleSettingsBlock>>? ThrottleSettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
