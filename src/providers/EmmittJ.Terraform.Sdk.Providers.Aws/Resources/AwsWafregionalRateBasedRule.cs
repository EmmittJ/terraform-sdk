using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for predicate in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafregionalRateBasedRulePredicateBlock() : TerraformBlock("predicate")
{
    /// <summary>
    /// The data_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataId is required")]
    [TerraformProperty("data_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataId { get; set; }

    /// <summary>
    /// The negated attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Negated is required")]
    [TerraformProperty("negated")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Negated { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_wafregional_rate_based_rule resource.
/// </summary>
public partial class AwsWafregionalRateBasedRule : TerraformResource
{
    public AwsWafregionalRateBasedRule(string name) : base("aws_wafregional_rate_based_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The rate_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RateKey is required")]
    [TerraformProperty("rate_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RateKey { get; set; }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RateLimit is required")]
    [TerraformProperty("rate_limit")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RateLimit { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for predicate.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("predicate")]
    public TerraformSet<AwsWafregionalRateBasedRulePredicateBlock> Predicate { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
