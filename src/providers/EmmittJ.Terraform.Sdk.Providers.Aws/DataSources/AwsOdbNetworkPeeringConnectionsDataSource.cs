using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for odb_peering_connections in .
/// Nesting mode: list
/// </summary>
public class AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock : TerraformBlock
{
}

/// <summary>
/// Retrieves information about a aws_odb_network_peering_connections.
/// </summary>
public class AwsOdbNetworkPeeringConnectionsDataSource : TerraformDataSource
{
    public AwsOdbNetworkPeeringConnectionsDataSource(string name) : base("aws_odb_network_peering_connections", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("region");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for odb_peering_connections.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOdbNetworkPeeringConnectionsDataSourceOdbPeeringConnectionsBlock>? OdbPeeringConnections
    {
        set => SetProperty("odb_peering_connections", value);
    }

}
