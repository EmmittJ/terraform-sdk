using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam resource.
/// </summary>
public class AwsVpcIpam : TerraformResource
{
    public AwsVpcIpam(string name) : base("aws_vpc_ipam", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_resource_discovery_association_id");
        this.DeclareOutput("default_resource_discovery_id");
        this.DeclareOutput("private_default_scope_id");
        this.DeclareOutput("public_default_scope_id");
        this.DeclareOutput("scope_count");
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    public TerraformProperty<bool>? Cascade
    {
        get => GetProperty<TerraformProperty<bool>>("cascade");
        set => this.WithProperty("cascade", value);
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
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePrivateGua
    {
        get => GetProperty<TerraformProperty<bool>>("enable_private_gua");
        set => this.WithProperty("enable_private_gua", value);
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
    /// The metered_account attribute.
    /// </summary>
    public TerraformProperty<string>? MeteredAccount
    {
        get => GetProperty<TerraformProperty<string>>("metered_account");
        set => this.WithProperty("metered_account", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    public TerraformExpression DefaultResourceDiscoveryAssociationId => this["default_resource_discovery_association_id"];

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    public TerraformExpression DefaultResourceDiscoveryId => this["default_resource_discovery_id"];

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    public TerraformExpression PrivateDefaultScopeId => this["private_default_scope_id"];

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    public TerraformExpression PublicDefaultScopeId => this["public_default_scope_id"];

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    public TerraformExpression ScopeCount => this["scope_count"];

}
