using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_opensearchserverless_vpc_endpoint.
/// </summary>
public class AwsOpensearchserverlessVpcEndpointDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessVpcEndpointDataSource(string name) : base("aws_opensearchserverless_vpc_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_date");
        this.DeclareOutput("name");
        this.DeclareOutput("security_group_ids");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("vpc_id");
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
    /// The unique identifier of the endpoint.
    /// </summary>
    public string? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id")?.Value;
        set => this.WithProperty("vpc_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The date the endpoint was created.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The name of the endpoint.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The IDs of the security groups that define the ports, protocols, and sources for inbound traffic that you are authorizing into your endpoint.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The IDs of the subnets from which you access OpenSearch Serverless.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The ID of the VPC from which you access OpenSearch Serverless.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
