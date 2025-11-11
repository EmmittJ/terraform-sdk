using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_datazone_domain.
/// </summary>
public class AwsDatazoneDomainDataSource : TerraformDataSource
{
    public AwsDatazoneDomainDataSource(string name) : base("aws_datazone_domain", name)
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
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The domain_version attribute.
    /// </summary>
    [TerraformPropertyName("domain_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainVersion => new TerraformReference(this, "domain_version");

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedAt => new TerraformReference(this, "last_updated_at");

    /// <summary>
    /// The managed_account_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedAccountId => new TerraformReference(this, "managed_account_id");

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformPropertyName("portal_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortalUrl => new TerraformReference(this, "portal_url");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
