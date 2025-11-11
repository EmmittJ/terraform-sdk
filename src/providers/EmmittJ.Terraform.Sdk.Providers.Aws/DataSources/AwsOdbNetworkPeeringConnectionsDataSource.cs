using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for odb_peering_connections in .
/// Nesting mode: list
/// </summary>
public class AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock
{
}

/// <summary>
/// Retrieves information about a aws_odb_network_peering_connections.
/// </summary>
public class AwsOdbNetworkPeeringConnectionsDataSource : TerraformDataSource
{
    public AwsOdbNetworkPeeringConnectionsDataSource(string name) : base("aws_odb_network_peering_connections", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for odb_peering_connections.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("odb_peering_connections")]
    public TerraformList<TerraformBlock<AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock>>? OdbPeeringConnections { get; set; }

}
