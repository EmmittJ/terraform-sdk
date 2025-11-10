using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_workgroup.
/// </summary>
public class AwsRedshiftserverlessWorkgroupDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessWorkgroupDataSource(string name) : base("aws_redshiftserverless_workgroup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("enhanced_vpc_routing");
        this.DeclareOutput("namespace_name");
        this.DeclareOutput("publicly_accessible");
        this.DeclareOutput("security_group_ids");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("track_name");
        this.DeclareOutput("workgroup_id");
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
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformProperty<string> WorkgroupName
    {
        get => GetProperty<TerraformProperty<string>>("workgroup_name");
        set => this.WithProperty("workgroup_name", value);
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
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformExpression EnhancedVpcRouting => this["enhanced_vpc_routing"];

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    public TerraformExpression NamespaceName => this["namespace_name"];

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformExpression PubliclyAccessible => this["publicly_accessible"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    public TerraformExpression TrackName => this["track_name"];

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    public TerraformExpression WorkgroupId => this["workgroup_id"];

}
