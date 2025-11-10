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
    public required TerraformProperty<TerraformProperty<string>> FirewallDomainListId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    [TerraformPropertyName("creator_request_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatorRequestId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creator_request_id");

    /// <summary>
    /// The domain_count attribute.
    /// </summary>
    [TerraformPropertyName("domain_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DomainCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "domain_count");

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_owner_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagedOwnerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_owner_name");

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    [TerraformPropertyName("modification_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModificationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "modification_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_message");

}
