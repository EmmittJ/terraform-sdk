using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_data_share_consumer_association resource.
/// </summary>
public partial class AwsRedshiftDataShareConsumerAssociation : TerraformResource
{
    public AwsRedshiftDataShareConsumerAssociation(string name) : base("aws_redshift_data_share_consumer_association", name)
    {
    }

    /// <summary>
    /// The allow_writes attribute.
    /// </summary>
    [TerraformProperty("allow_writes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowWrites { get; set; }

    /// <summary>
    /// The associate_entire_account attribute.
    /// </summary>
    [TerraformProperty("associate_entire_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AssociateEntireAccount { get; set; }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    [TerraformProperty("consumer_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConsumerArn { get; set; }

    /// <summary>
    /// The consumer_region attribute.
    /// </summary>
    [TerraformProperty("consumer_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConsumerRegion { get; set; }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareArn is required")]
    [TerraformProperty("data_share_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataShareArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The managed_by attribute.
    /// </summary>
    [TerraformProperty("managed_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagedBy { get; }

    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    [TerraformProperty("producer_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProducerArn { get; }

}
