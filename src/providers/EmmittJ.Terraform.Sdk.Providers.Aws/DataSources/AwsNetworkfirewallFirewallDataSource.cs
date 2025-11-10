using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkfirewall_firewall.
/// </summary>
public class AwsNetworkfirewallFirewallDataSource : TerraformDataSource
{
    public AwsNetworkfirewallFirewallDataSource(string name) : base("aws_networkfirewall_firewall", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// The availability_zone_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_change_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AvailabilityZoneChangeProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "availability_zone_change_protection");

    /// <summary>
    /// The availability_zone_mapping attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_mapping")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> AvailabilityZoneMapping => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "availability_zone_mapping");

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    [TerraformPropertyName("delete_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeleteProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "delete_protection");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_analysis_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> EnabledAnalysisTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "enabled_analysis_types");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> EncryptionConfiguration => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "encryption_configuration");

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FirewallPolicyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "firewall_policy_arn");

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_change_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FirewallPolicyChangeProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "firewall_policy_change_protection");

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    [TerraformPropertyName("firewall_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FirewallStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "firewall_status");

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("subnet_change_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SubnetChangeProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "subnet_change_protection");

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> SubnetMapping => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "subnet_mapping");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_id");

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransitGatewayOwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transit_gateway_owner_account_id");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    [TerraformPropertyName("update_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_token");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
