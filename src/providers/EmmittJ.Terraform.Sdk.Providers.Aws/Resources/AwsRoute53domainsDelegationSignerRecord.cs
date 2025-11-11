using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for signing_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsDelegationSignerRecordSigningAttributesBlock : TerraformBlockBase
{
    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    [TerraformProperty("algorithm")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Algorithm { get; set; }

    /// <summary>
    /// The flags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Flags is required")]
    [TerraformProperty("flags")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Flags { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformProperty("public_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PublicKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53domainsDelegationSignerRecordTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_route53domains_delegation_signer_record resource.
/// </summary>
public partial class AwsRoute53domainsDelegationSignerRecord : TerraformResource
{
    public AwsRoute53domainsDelegationSignerRecord(string name) : base("aws_route53domains_delegation_signer_record", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// Block for signing_attributes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("signing_attributes")]
    public TerraformList<TerraformBlock<AwsRoute53domainsDelegationSignerRecordSigningAttributesBlock>>? SigningAttributes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRoute53domainsDelegationSignerRecordTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dnssec_key_id attribute.
    /// </summary>
    [TerraformProperty("dnssec_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnssecKeyId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
