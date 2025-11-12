using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for odb_peering_connections in .
/// Nesting mode: list
/// </summary>
public partial class AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock() : TerraformBlock("odb_peering_connections")
{
}

/// <summary>
/// Retrieves information about a aws_odb_network_peering_connections.
/// </summary>
public partial class AwsOdbNetworkPeeringConnectionsDataSource : TerraformDataSource
{
    public AwsOdbNetworkPeeringConnectionsDataSource(string name) : base("aws_odb_network_peering_connections", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for odb_peering_connections.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("odb_peering_connections")]
    public TerraformList<AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock> OdbPeeringConnections { get; set; } = new();

}
