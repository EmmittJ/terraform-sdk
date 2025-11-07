using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_proxy_endpoint resource.
/// </summary>
public class AwsDbProxyEndpoint : TerraformResource
{
    public AwsDbProxyEndpoint(string name) : base("aws_db_proxy_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("is_default");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The db_proxy_endpoint_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbProxyEndpointName
    {
        get => GetProperty<TerraformProperty<string>>("db_proxy_endpoint_name");
        set => this.WithProperty("db_proxy_endpoint_name", value);
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbProxyName
    {
        get => GetProperty<TerraformProperty<string>>("db_proxy_name");
        set => this.WithProperty("db_proxy_name", value);
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
    /// The target_role attribute.
    /// </summary>
    public TerraformProperty<string>? TargetRole
    {
        get => GetProperty<TerraformProperty<string>>("target_role");
        set => this.WithProperty("target_role", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_subnet_ids");
        set => this.WithProperty("vpc_subnet_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
