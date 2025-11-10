using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkfirewall_firewall_policy.
/// </summary>
public class AwsNetworkfirewallFirewallPolicyDataSource : TerraformDataSource
{
    public AwsNetworkfirewallFirewallPolicyDataSource(string name) : base("aws_networkfirewall_firewall_policy", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The firewall_policy attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FirewallPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "firewall_policy");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    [TerraformPropertyName("update_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_token");

}
