using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_domain_list.
/// </summary>
public class AwsRoute53ResolverFirewallDomainListDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallDomainListDataSource(string name) : base("aws_route53_resolver_firewall_domain_list", name)
    {
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    [TerraformPropertyName("firewall_domain_list_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FirewallDomainListId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    [TerraformPropertyName("creator_request_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatorRequestId => new TerraformReference(this, "creator_request_id");

    /// <summary>
    /// The domain_count attribute.
    /// </summary>
    [TerraformPropertyName("domain_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DomainCount => new TerraformReference(this, "domain_count");

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_owner_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedOwnerName => new TerraformReference(this, "managed_owner_name");

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    [TerraformPropertyName("modification_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModificationTime => new TerraformReference(this, "modification_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusMessage => new TerraformReference(this, "status_message");

}
