using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_outposts.
/// </summary>
public class AwsOutpostsOutpostsDataSource : TerraformDataSource
{
    public AwsOutpostsOutpostsDataSource(string name) : base("aws_outposts_outposts", name)
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OwnerId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    [TerraformPropertyName("site_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SiteId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "site_id");

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Arns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "arns");

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformPropertyName("ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Ids => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ids");

}
