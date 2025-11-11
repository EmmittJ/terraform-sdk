using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_outposts.
/// </summary>
public partial class AwsOutpostsOutpostsDataSource : TerraformDataSource
{
    public AwsOutpostsOutpostsDataSource(string name) : base("aws_outposts_outposts", name)
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZoneId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OwnerId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformProperty("site_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SiteId { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformProperty("arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Arns { get; }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformProperty("ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Ids { get; }

}
