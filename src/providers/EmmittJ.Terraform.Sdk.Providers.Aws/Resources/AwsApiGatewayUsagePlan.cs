using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for api_stages in .
/// Nesting mode: set
/// </summary>
public class AwsApiGatewayUsagePlanApiStagesBlock : ITerraformBlock
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiId { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    [TerraformPropertyName("stage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Stage { get; set; }

}

/// <summary>
/// Block type for quota_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayUsagePlanQuotaSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Limit is required")]
    [TerraformPropertyName("limit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Limit { get; set; }

    /// <summary>
    /// The offset attribute.
    /// </summary>
    [TerraformPropertyName("offset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Offset { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Period is required")]
    [TerraformPropertyName("period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Period { get; set; }

}

/// <summary>
/// Block type for throttle_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayUsagePlanThrottleSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The burst_limit attribute.
    /// </summary>
    [TerraformPropertyName("burst_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BurstLimit { get; set; }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    [TerraformPropertyName("rate_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RateLimit { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_usage_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayUsagePlan : TerraformResource
{
    public AwsApiGatewayUsagePlan(string name) : base("aws_api_gateway_usage_plan", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The product_code attribute.
    /// </summary>
    [TerraformPropertyName("product_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProductCode { get; set; }

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
    /// Block for api_stages.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("api_stages")]
    public TerraformSet<TerraformBlock<AwsApiGatewayUsagePlanApiStagesBlock>>? ApiStages { get; set; } = new();

    /// <summary>
    /// Block for quota_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaSettings block(s) allowed")]
    [TerraformPropertyName("quota_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayUsagePlanQuotaSettingsBlock>>? QuotaSettings { get; set; } = new();

    /// <summary>
    /// Block for throttle_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThrottleSettings block(s) allowed")]
    [TerraformPropertyName("throttle_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayUsagePlanThrottleSettingsBlock>>? ThrottleSettings { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
