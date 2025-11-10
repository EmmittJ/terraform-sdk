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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
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
        this.DeclareOutput("security_group_rule_id");
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CidrBlocks
    {
        get => GetProperty<List<TerraformProperty<string>>>("cidr_blocks");
        set => this.WithProperty("cidr_blocks", value);
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
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformProperty<double> FromPort
    {
        get => GetProperty<TerraformProperty<double>>("from_port");
        set => this.WithProperty("from_port", value);
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
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Ipv6CidrBlocks
    {
        get => GetProperty<List<TerraformProperty<string>>>("ipv6_cidr_blocks");
        set => this.WithProperty("ipv6_cidr_blocks", value);
    }

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PrefixListIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("prefix_list_ids");
        set => this.WithProperty("prefix_list_ids", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformProperty<string> SecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("security_group_id");
        set => this.WithProperty("security_group_id", value);
    }

    /// <summary>
    /// The self attribute.
    /// </summary>
    public TerraformProperty<bool>? Self
    {
        get => GetProperty<TerraformProperty<bool>>("self");
        set => this.WithProperty("self", value);
    }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("source_security_group_id");
        set => this.WithProperty("source_security_group_id", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        get => GetProperty<TerraformProperty<double>>("to_port");
        set => this.WithProperty("to_port", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSecurityGroupRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsSecurityGroupRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupRuleId => this["security_group_rule_id"];

}
