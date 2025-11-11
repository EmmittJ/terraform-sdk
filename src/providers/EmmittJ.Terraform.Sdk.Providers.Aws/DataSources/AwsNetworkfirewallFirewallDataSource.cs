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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_change_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AvailabilityZoneChangeProtection => new TerraformReference(this, "availability_zone_change_protection");

    /// <summary>
    /// The availability_zone_mapping attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_mapping")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> AvailabilityZoneMapping => new TerraformReference(this, "availability_zone_mapping");

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    [TerraformPropertyName("delete_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeleteProtection => new TerraformReference(this, "delete_protection");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_analysis_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> EnabledAnalysisTypes => new TerraformReference(this, "enabled_analysis_types");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> EncryptionConfiguration => new TerraformReference(this, "encryption_configuration");

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FirewallPolicyArn => new TerraformReference(this, "firewall_policy_arn");

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_change_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FirewallPolicyChangeProtection => new TerraformReference(this, "firewall_policy_change_protection");

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    [TerraformPropertyName("firewall_status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FirewallStatus => new TerraformReference(this, "firewall_status");

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("subnet_change_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SubnetChangeProtection => new TerraformReference(this, "subnet_change_protection");

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> SubnetMapping => new TerraformReference(this, "subnet_mapping");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayId => new TerraformReference(this, "transit_gateway_id");

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransitGatewayOwnerAccountId => new TerraformReference(this, "transit_gateway_owner_account_id");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    [TerraformPropertyName("update_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateToken => new TerraformReference(this, "update_token");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}
