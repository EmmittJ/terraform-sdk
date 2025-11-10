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
        this.WithOutput("arn");
        this.WithOutput("description");
        this.WithOutput("name");
        this.WithOutput("name_prefix");
        this.WithOutput("owner_id");
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? Egress
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("egress");
        set => this.WithProperty("egress", value);
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
    /// The ingress attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>>? Ingress
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("ingress");
        set => this.WithProperty("ingress", value);
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
    /// The revoke_rules_on_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? RevokeRulesOnDelete
    {
        get => GetProperty<TerraformProperty<bool>>("revoke_rules_on_delete");
        set => this.WithProperty("revoke_rules_on_delete", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
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
