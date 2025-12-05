using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for odb_peering_connections in AwsOdbNetworkPeeringConnectionsDataSource.
/// Nesting mode: list
/// </summary>
public class AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "odb_peering_connections";

}


/// <summary>
/// Represents a aws_odb_network_peering_connections Terraform data source.
/// Retrieves information about a aws_odb_network_peering_connections.
/// </summary>
public partial class AwsOdbNetworkPeeringConnectionsDataSource(string name) : TerraformDataSource("aws_odb_network_peering_connections", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// OdbPeeringConnections block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock>? OdbPeeringConnections
    {
        get => GetArgument<TerraformList<AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock>>("odb_peering_connections");
        set => SetArgument("odb_peering_connections", value);
    }

}
