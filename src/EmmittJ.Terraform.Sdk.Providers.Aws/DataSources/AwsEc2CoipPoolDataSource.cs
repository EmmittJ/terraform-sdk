using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_coip_pool.
/// </summary>
public class AwsEc2CoipPoolDataSource : TerraformDataSource
{
    public AwsEc2CoipPoolDataSource(string name) : base("aws_ec2_coip_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("pool_cidrs");
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
    /// The local_gateway_route_table_id attribute.
    /// </summary>
    public TerraformProperty<string>? LocalGatewayRouteTableId
    {
        get => GetProperty<TerraformProperty<string>>("local_gateway_route_table_id");
        set => this.WithProperty("local_gateway_route_table_id", value);
    }

    /// <summary>
    /// The pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? PoolId
    {
        get => GetProperty<TerraformProperty<string>>("pool_id");
        set => this.WithProperty("pool_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The pool_cidrs attribute.
    /// </summary>
    public TerraformExpression PoolCidrs => this["pool_cidrs"];

}
