using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockProvisionedModelThroughputTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Manages a aws_bedrock_provisioned_model_throughput resource.
/// </summary>
public class AwsBedrockProvisionedModelThroughput : TerraformResource
{
    public AwsBedrockProvisionedModelThroughput(string name) : base("aws_bedrock_provisioned_model_throughput", name)
    {
    }

    /// <summary>
    /// The commitment_duration attribute.
    /// </summary>
    [TerraformPropertyName("commitment_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CommitmentDuration { get; set; }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelArn is required")]
    [TerraformPropertyName("model_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ModelArn { get; set; }

    /// <summary>
    /// The model_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelUnits is required")]
    [TerraformPropertyName("model_units")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ModelUnits { get; set; }

    /// <summary>
    /// The provisioned_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedModelName is required")]
    [TerraformPropertyName("provisioned_model_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProvisionedModelName { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockProvisionedModelThroughputTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The provisioned_model_arn attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_model_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProvisionedModelArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provisioned_model_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
