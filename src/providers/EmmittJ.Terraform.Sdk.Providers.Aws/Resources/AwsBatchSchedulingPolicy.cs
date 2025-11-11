using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fair_share_policy in .
/// Nesting mode: list
/// </summary>
public class AwsBatchSchedulingPolicyFairSharePolicyBlock
{
    /// <summary>
    /// The compute_reservation attribute.
    /// </summary>
    [TerraformPropertyName("compute_reservation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ComputeReservation { get; set; }

    /// <summary>
    /// The share_decay_seconds attribute.
    /// </summary>
    [TerraformPropertyName("share_decay_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ShareDecaySeconds { get; set; }

}

/// <summary>
/// Manages a aws_batch_scheduling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBatchSchedulingPolicy : TerraformResource
{
    public AwsBatchSchedulingPolicy(string name) : base("aws_batch_scheduling_policy", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

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
    /// Block for fair_share_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FairSharePolicy block(s) allowed")]
    [TerraformPropertyName("fair_share_policy")]
    public TerraformList<TerraformBlock<AwsBatchSchedulingPolicyFairSharePolicyBlock>>? FairSharePolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
