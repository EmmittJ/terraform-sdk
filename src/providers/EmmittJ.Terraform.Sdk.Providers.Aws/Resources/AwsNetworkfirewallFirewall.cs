using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    [TerraformPropertyName("availability_zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AvailabilityZoneId { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallEncryptionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallSubnetMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_address_type");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallFirewallTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_networkfirewall_firewall resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkfirewallFirewall : TerraformResource
{
    public AwsNetworkfirewallFirewall(string name) : base("aws_networkfirewall_firewall", name)
    {
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_change_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AvailabilityZoneChangeProtection { get; set; }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    [TerraformPropertyName("delete_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteProtection { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    [TerraformPropertyName("enabled_analysis_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EnabledAnalysisTypes { get; set; }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicyArn is required")]
    [TerraformPropertyName("firewall_policy_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallPolicyArn { get; set; }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_change_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FirewallPolicyChangeProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    [TerraformPropertyName("subnet_change_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SubnetChangeProtection { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcId { get; set; }

    /// <summary>
    /// Block for availability_zone_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("availability_zone_mapping")]
    public TerraformSet<TerraformBlock<AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock>>? AvailabilityZoneMapping { get; set; } = new();

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformPropertyName("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsNetworkfirewallFirewallEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    public TerraformSet<TerraformBlock<AwsNetworkfirewallFirewallSubnetMappingBlock>>? SubnetMapping { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNetworkfirewallFirewallTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    [TerraformPropertyName("firewall_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FirewallStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "firewall_status");

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

}
