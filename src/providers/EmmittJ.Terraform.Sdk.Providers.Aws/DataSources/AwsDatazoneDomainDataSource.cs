using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_datazone_domain.
/// </summary>
public partial class AwsDatazoneDomainDataSource : TerraformDataSource
{
    public AwsDatazoneDomainDataSource(string name) : base("aws_datazone_domain", name)
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
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The domain_version attribute.
    /// </summary>
    [TerraformProperty("domain_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainVersion { get; }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    [TerraformProperty("last_updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedAt { get; }

    /// <summary>
    /// The managed_account_id attribute.
    /// </summary>
    [TerraformProperty("managed_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagedAccountId { get; }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformProperty("portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PortalUrl { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
