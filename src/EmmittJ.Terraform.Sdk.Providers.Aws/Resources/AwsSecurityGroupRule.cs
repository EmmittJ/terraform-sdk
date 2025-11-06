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
    public List<string>? CidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cidr_blocks")?.Value;
        set => this.WithProperty("cidr_blocks", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public double? FromPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("from_port")?.Value;
        set => this.WithProperty("from_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public List<string>? Ipv6CidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipv6_cidr_blocks")?.Value;
        set => this.WithProperty("ipv6_cidr_blocks", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    public List<string>? PrefixListIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("prefix_list_ids")?.Value;
        set => this.WithProperty("prefix_list_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public string? SecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_id")?.Value;
        set => this.WithProperty("security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The self attribute.
    /// </summary>
    public bool? Self
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("self")?.Value;
        set => this.WithProperty("self", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public string? SourceSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_security_group_id")?.Value;
        set => this.WithProperty("source_security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public double? ToPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("to_port")?.Value;
        set => this.WithProperty("to_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupRuleId => this["security_group_rule_id"];

}
