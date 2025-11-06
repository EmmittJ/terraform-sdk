using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_vpc_connection.
/// </summary>
public class AwsMskVpcConnectionDataSource : TerraformDataSource
{
    public AwsMskVpcConnectionDataSource(string name) : base("aws_msk_vpc_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authentication");
        this.DeclareOutput("client_subnets");
        this.DeclareOutput("security_groups");
        this.DeclareOutput("target_cluster_arn");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The authentication attribute.
    /// </summary>
    public TerraformExpression Authentication => this["authentication"];

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    public TerraformExpression ClientSubnets => this["client_subnets"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The target_cluster_arn attribute.
    /// </summary>
    public TerraformExpression TargetClusterArn => this["target_cluster_arn"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
