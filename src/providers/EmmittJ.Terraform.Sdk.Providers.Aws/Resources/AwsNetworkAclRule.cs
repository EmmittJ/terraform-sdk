using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_network_acl_rule resource.
/// </summary>
public class AwsNetworkAclRule : TerraformResource
{
    public AwsNetworkAclRule(string name) : base("aws_network_acl_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cidr_block");
        SetOutput("egress");
        SetOutput("from_port");
        SetOutput("icmp_code");
        SetOutput("icmp_type");
        SetOutput("id");
        SetOutput("ipv6_cidr_block");
        SetOutput("network_acl_id");
        SetOutput("protocol");
        SetOutput("region");
        SetOutput("rule_action");
        SetOutput("rule_number");
        SetOutput("to_port");
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr_block");
        set => SetProperty("cidr_block", value);
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public TerraformProperty<bool> Egress
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("egress");
        set => SetProperty("egress", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformProperty<double> FromPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("from_port");
        set => SetProperty("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformProperty<double> IcmpCode
    {
        get => GetRequiredOutput<TerraformProperty<double>>("icmp_code");
        set => SetProperty("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformProperty<double> IcmpType
    {
        get => GetRequiredOutput<TerraformProperty<double>>("icmp_type");
        set => SetProperty("icmp_type", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_cidr_block");
        set => SetProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAclId is required")]
    public required TerraformProperty<string> NetworkAclId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_acl_id");
        set => SetProperty("network_acl_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
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
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformProperty<string> RuleAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_action");
        set => SetProperty("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformProperty<double> RuleNumber
    {
        get => GetRequiredOutput<TerraformProperty<double>>("rule_number");
        set => SetProperty("rule_number", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformProperty<double> ToPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("to_port");
        set => SetProperty("to_port", value);
    }

}
