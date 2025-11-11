using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_delegation_set resource.
/// </summary>
public partial class AwsRoute53DelegationSet : TerraformResource
{
    public AwsRoute53DelegationSet(string name) : base("aws_route53_delegation_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    [TerraformProperty("reference_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReferenceName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformProperty("name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NameServers { get; }

}
