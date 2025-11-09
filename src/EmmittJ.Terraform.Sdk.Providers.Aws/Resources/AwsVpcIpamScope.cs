using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_scope resource.
/// </summary>
public class AwsVpcIpamScope : TerraformResource
{
    public AwsVpcIpamScope(string name) : base("aws_vpc_ipam_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("ipam_arn");
        this.DeclareOutput("ipam_scope_type");
        this.DeclareOutput("is_default");
        this.DeclareOutput("pool_count");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipam_id attribute.
    /// </summary>
    public TerraformProperty<string>? IpamId
    {
        get => GetProperty<TerraformProperty<string>>("ipam_id");
        set => this.WithProperty("ipam_id", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ipam_arn attribute.
    /// </summary>
    public TerraformExpression IpamArn => this["ipam_arn"];

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    public TerraformExpression IpamScopeType => this["ipam_scope_type"];

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

    /// <summary>
    /// The pool_count attribute.
    /// </summary>
    public TerraformExpression PoolCount => this["pool_count"];

}
