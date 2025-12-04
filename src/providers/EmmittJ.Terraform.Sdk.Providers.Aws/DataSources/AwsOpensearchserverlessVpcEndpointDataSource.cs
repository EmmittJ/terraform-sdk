using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_opensearchserverless_vpc_endpoint Terraform data source.
/// Retrieves information about a aws_opensearchserverless_vpc_endpoint.
/// </summary>
public partial class AwsOpensearchserverlessVpcEndpointDataSource(string name) : TerraformDataSource("aws_opensearchserverless_vpc_endpoint", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The unique identifier of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    public required TerraformValue<string> VpcEndpointId
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The date the endpoint was created.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The name of the endpoint.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The IDs of the security groups that define the ports, protocols, and sources for inbound traffic that you are authorizing into your endpoint.
    /// </summary>
    public TerraformList<string> SecurityGroupIds
        => AsReference("security_group_ids");

    /// <summary>
    /// The IDs of the subnets from which you access OpenSearch Serverless.
    /// </summary>
    public TerraformList<string> SubnetIds
        => AsReference("subnet_ids");

    /// <summary>
    /// The ID of the VPC from which you access OpenSearch Serverless.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}
