using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkfirewall_firewall.
/// </summary>
public partial class AwsNetworkfirewallFirewallDataSource : TerraformDataSource
{
    public AwsNetworkfirewallFirewallDataSource(string name) : base("aws_networkfirewall_firewall", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    [TerraformProperty("availability_zone_change_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AvailabilityZoneChangeProtection { get; }

    /// <summary>
    /// The availability_zone_mapping attribute.
    /// </summary>
    [TerraformProperty("availability_zone_mapping")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> AvailabilityZoneMapping { get; }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    [TerraformProperty("delete_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeleteProtection { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    [TerraformProperty("enabled_analysis_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> EnabledAnalysisTypes { get; }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> EncryptionConfiguration { get; }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [TerraformProperty("firewall_policy_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FirewallPolicyArn { get; }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    [TerraformProperty("firewall_policy_change_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> FirewallPolicyChangeProtection { get; }

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    [TerraformProperty("firewall_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FirewallStatus { get; }

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    [TerraformProperty("subnet_change_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SubnetChangeProtection { get; }

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    [TerraformProperty("subnet_mapping")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> SubnetMapping { get; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitGatewayId { get; }

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransitGatewayOwnerAccountId { get; }

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    [TerraformProperty("update_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateToken { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}
