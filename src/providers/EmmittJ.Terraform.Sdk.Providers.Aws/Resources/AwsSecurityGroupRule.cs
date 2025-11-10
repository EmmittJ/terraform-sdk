using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSecurityGroupRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_security_group_rule resource.
/// </summary>
public class AwsSecurityGroupRule : TerraformResource
{
    public AwsSecurityGroupRule(string name) : base("aws_security_group_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("security_group_rule_id");
        SetOutput("cidr_blocks");
        SetOutput("description");
        SetOutput("from_port");
        SetOutput("id");
        SetOutput("ipv6_cidr_blocks");
        SetOutput("prefix_list_ids");
        SetOutput("protocol");
        SetOutput("region");
        SetOutput("security_group_id");
        SetOutput("self");
        SetOutput("source_security_group_id");
        SetOutput("to_port");
        SetOutput("type");
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public List<TerraformProperty<string>> CidrBlocks
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("cidr_blocks");
        set => SetProperty("cidr_blocks", value);
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
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformProperty<double> FromPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("from_port");
        set => SetProperty("from_port", value);
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
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public List<TerraformProperty<string>> Ipv6CidrBlocks
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ipv6_cidr_blocks");
        set => SetProperty("ipv6_cidr_blocks", value);
    }

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> PrefixListIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("prefix_list_ids");
        set => SetProperty("prefix_list_ids", value);
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
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformProperty<string> SecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_group_id");
        set => SetProperty("security_group_id", value);
    }

    /// <summary>
    /// The self attribute.
    /// </summary>
    public TerraformProperty<bool> Self
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("self");
        set => SetProperty("self", value);
    }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceSecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_security_group_id");
        set => SetProperty("source_security_group_id", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("to_port");
        set => SetProperty("to_port", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSecurityGroupRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupRuleId => this["security_group_rule_id"];

}
