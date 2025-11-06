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
    public bool? Cascade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cascade")?.Value;
        set => this.WithProperty("cascade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The enable_private_gua attribute.
    /// </summary>
    public bool? EnablePrivateGua
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_private_gua")?.Value;
        set => this.WithProperty("enable_private_gua", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The metered_account attribute.
    /// </summary>
    public string? MeteredAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metered_account")?.Value;
        set => this.WithProperty("metered_account", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tier attribute.
    /// </summary>
    public string? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier")?.Value;
        set => this.WithProperty("tier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
