using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_opensearchserverless_vpc_endpoint.
/// </summary>
public partial class AwsOpensearchserverlessVpcEndpointDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessVpcEndpointDataSource(string name) : base("aws_opensearchserverless_vpc_endpoint", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The unique identifier of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    [TerraformProperty("vpc_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcEndpointId { get; set; }

    /// <summary>
    /// The date the endpoint was created.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The name of the endpoint.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The IDs of the security groups that define the ports, protocols, and sources for inbound traffic that you are authorizing into your endpoint.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SecurityGroupIds { get; }

    /// <summary>
    /// The IDs of the subnets from which you access OpenSearch Serverless.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SubnetIds { get; }

    /// <summary>
    /// The ID of the VPC from which you access OpenSearch Serverless.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

}
