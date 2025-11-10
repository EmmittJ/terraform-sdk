using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    public required TerraformProperty<string> AvailabilityZoneId
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_id");
        set => WithProperty("availability_zone_id", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => WithProperty("key_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallSubnetMappingBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallFirewallTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_networkfirewall_firewall resource.
/// </summary>
public class AwsNetworkfirewallFirewall : TerraformResource
{
    public AwsNetworkfirewallFirewall(string name) : base("aws_networkfirewall_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("firewall_status");
        this.DeclareOutput("transit_gateway_owner_account_id");
        this.DeclareOutput("update_token");
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? AvailabilityZoneChangeProtection
    {
        get => GetProperty<TerraformProperty<bool>>("availability_zone_change_protection");
        set => this.WithProperty("availability_zone_change_protection", value);
    }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteProtection
    {
        get => GetProperty<TerraformProperty<bool>>("delete_protection");
        set => this.WithProperty("delete_protection", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EnabledAnalysisTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("enabled_analysis_types");
        set => this.WithProperty("enabled_analysis_types", value);
    }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicyArn is required")]
    public required TerraformProperty<string> FirewallPolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy_arn");
        set => this.WithProperty("firewall_policy_arn", value);
    }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? FirewallPolicyChangeProtection
    {
        get => GetProperty<TerraformProperty<bool>>("firewall_policy_change_protection");
        set => this.WithProperty("firewall_policy_change_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? SubnetChangeProtection
    {
        get => GetProperty<TerraformProperty<bool>>("subnet_change_protection");
        set => this.WithProperty("subnet_change_protection", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for availability_zone_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock>? AvailabilityZoneMapping
    {
        get => GetProperty<HashSet<AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock>>("availability_zone_mapping");
        set => this.WithProperty("availability_zone_mapping", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsNetworkfirewallFirewallEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsNetworkfirewallFirewallEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsNetworkfirewallFirewallSubnetMappingBlock>? SubnetMapping
    {
        get => GetProperty<HashSet<AwsNetworkfirewallFirewallSubnetMappingBlock>>("subnet_mapping");
        set => this.WithProperty("subnet_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkfirewallFirewallTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkfirewallFirewallTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    public TerraformExpression FirewallStatus => this["firewall_status"];

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayOwnerAccountId => this["transit_gateway_owner_account_id"];

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformExpression UpdateToken => this["update_token"];

}
