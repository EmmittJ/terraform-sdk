using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_delegation_set resource.
/// </summary>
public class AwsRoute53DelegationSet : TerraformResource
{
    public AwsRoute53DelegationSet(string name) : base("aws_route53_delegation_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    [TerraformPropertyName("reference_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReferenceName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformPropertyName("name_servers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NameServers => new TerraformReference(this, "name_servers");

}
