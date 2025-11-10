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
        SetOutput("arn");
        SetOutput("description");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("owner_id");
        SetOutput("egress");
        SetOutput("id");
        SetOutput("ingress");
        SetOutput("region");
        SetOutput("revoke_rules_on_delete");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> Egress
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("egress");
        set => SetProperty("egress", value);
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
    /// The ingress attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> Ingress
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("ingress");
        set => SetProperty("ingress", value);
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
    /// The revoke_rules_on_delete attribute.
    /// </summary>
    public TerraformProperty<bool> RevokeRulesOnDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("revoke_rules_on_delete");
        set => SetProperty("revoke_rules_on_delete", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
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
