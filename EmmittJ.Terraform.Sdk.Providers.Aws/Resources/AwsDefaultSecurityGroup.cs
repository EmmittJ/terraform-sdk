using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_security_group resource.
/// </summary>
public class AwsDefaultSecurityGroup : TerraformResource
{
    public AwsDefaultSecurityGroup(string name) : base("aws_default_security_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("description");
        this.DeclareOutput("name");
        this.DeclareOutput("name_prefix");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public HashSet<object>? Egress
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("egress")?.Value;
        set => this.WithProperty("egress", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
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
    /// The ingress attribute.
    /// </summary>
    public HashSet<object>? Ingress
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("ingress")?.Value;
        set => this.WithProperty("ingress", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
    }

    /// <summary>
    /// The revoke_rules_on_delete attribute.
    /// </summary>
    public bool? RevokeRulesOnDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("revoke_rules_on_delete")?.Value;
        set => this.WithProperty("revoke_rules_on_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformExpression NamePrefix => this["name_prefix"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
