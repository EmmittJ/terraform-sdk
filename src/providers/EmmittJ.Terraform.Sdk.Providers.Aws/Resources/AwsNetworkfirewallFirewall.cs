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
        set => SetProperty("availability_zone_id", value);
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
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_networkfirewall_firewall resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkfirewallFirewall : TerraformResource
{
    public AwsNetworkfirewallFirewall(string name) : base("aws_networkfirewall_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("firewall_status");
        SetOutput("transit_gateway_owner_account_id");
        SetOutput("update_token");
        SetOutput("availability_zone_change_protection");
        SetOutput("delete_protection");
        SetOutput("description");
        SetOutput("enabled_analysis_types");
        SetOutput("firewall_policy_arn");
        SetOutput("firewall_policy_change_protection");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("subnet_change_protection");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_gateway_id");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool> AvailabilityZoneChangeProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("availability_zone_change_protection");
        set => SetProperty("availability_zone_change_protection", value);
    }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_protection");
        set => SetProperty("delete_protection", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EnabledAnalysisTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("enabled_analysis_types");
        set => SetProperty("enabled_analysis_types", value);
    }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicyArn is required")]
    public required TerraformProperty<string> FirewallPolicyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_policy_arn");
        set => SetProperty("firewall_policy_arn", value);
    }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool> FirewallPolicyChangeProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("firewall_policy_change_protection");
        set => SetProperty("firewall_policy_change_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool> SubnetChangeProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("subnet_change_protection");
        set => SetProperty("subnet_change_protection", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> TransitGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_id");
        set => SetProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for availability_zone_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock>? AvailabilityZoneMapping
    {
        set => SetProperty("availability_zone_mapping", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsNetworkfirewallFirewallEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        set => SetProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsNetworkfirewallFirewallSubnetMappingBlock>? SubnetMapping
    {
        set => SetProperty("subnet_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkfirewallFirewallTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
