using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_account resource.
/// </summary>
public partial class AwsMacie2Account : TerraformResource
{
    public AwsMacie2Account(string name) : base("aws_macie2_account", name)
    {
    }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    [TerraformProperty("finding_publishing_frequency")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> FindingPublishingFrequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Status { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformProperty("service_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceRole { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdatedAt { get; }

}
