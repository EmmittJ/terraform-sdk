using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_mapping in .
/// Nesting mode: set
/// </summary>
public partial class AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock() : TerraformBlock("availability_zone_mapping")
{
    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    [TerraformProperty("availability_zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AvailabilityZoneId { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkfirewallFirewallEncryptionConfigurationBlock() : TerraformBlock("encryption_configuration")
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformProperty("key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: set
/// </summary>
public partial class AwsNetworkfirewallFirewallSubnetMappingBlock() : TerraformBlock("subnet_mapping")
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkfirewallFirewallTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_networkfirewall_firewall resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNetworkfirewallFirewall : TerraformResource
{
    public AwsNetworkfirewallFirewall(string name) : base("aws_networkfirewall_firewall", name)
    {
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    [TerraformProperty("availability_zone_change_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AvailabilityZoneChangeProtection { get; set; }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    [TerraformProperty("delete_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteProtection { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    [TerraformProperty("enabled_analysis_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EnabledAnalysisTypes { get; set; }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicyArn is required")]
    [TerraformProperty("firewall_policy_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirewallPolicyArn { get; set; }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    [TerraformProperty("firewall_policy_change_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FirewallPolicyChangeProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    [TerraformProperty("subnet_change_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SubnetChangeProtection { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcId { get; set; }

    /// <summary>
    /// Block for availability_zone_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("availability_zone_mapping")]
    public TerraformSet<AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock> AvailabilityZoneMapping { get; set; } = new();

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformProperty("encryption_configuration")]
    public TerraformList<AwsNetworkfirewallFirewallEncryptionConfigurationBlock> EncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("subnet_mapping")]
    public TerraformSet<AwsNetworkfirewallFirewallSubnetMappingBlock> SubnetMapping { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsNetworkfirewallFirewallTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    [TerraformProperty("firewall_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FirewallStatus { get; }

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

}
