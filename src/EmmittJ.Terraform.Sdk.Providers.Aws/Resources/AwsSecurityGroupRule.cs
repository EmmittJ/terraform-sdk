using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformLiteralProperty<List<string>>? CidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cidr_blocks");
        set => this.WithProperty("cidr_blocks", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? FromPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("from_port");
        set => this.WithProperty("from_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Ipv6CidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipv6_cidr_blocks");
        set => this.WithProperty("ipv6_cidr_blocks", value);
    }

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PrefixListIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("prefix_list_ids");
        set => this.WithProperty("prefix_list_ids", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_id");
        set => this.WithProperty("security_group_id", value);
    }

    /// <summary>
    /// The self attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Self
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("self");
        set => this.WithProperty("self", value);
    }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_security_group_id");
        set => this.WithProperty("source_security_group_id", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ToPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("to_port");
        set => this.WithProperty("to_port", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupRuleId => this["security_group_rule_id"];

}
