using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fair_share_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchSchedulingPolicyFairSharePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The compute_reservation attribute.
    /// </summary>
    [TerraformProperty("compute_reservation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ComputeReservation { get; set; }

    /// <summary>
    /// The share_decay_seconds attribute.
    /// </summary>
    [TerraformProperty("share_decay_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ShareDecaySeconds { get; set; }

}

/// <summary>
/// Manages a aws_batch_scheduling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsBatchSchedulingPolicy : TerraformResource
{
    public AwsBatchSchedulingPolicy(string name) : base("aws_batch_scheduling_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    /// Block for fair_share_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FairSharePolicy block(s) allowed")]
    [TerraformProperty("fair_share_policy")]
    public partial TerraformList<TerraformBlock<AwsBatchSchedulingPolicyFairSharePolicyBlock>>? FairSharePolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
