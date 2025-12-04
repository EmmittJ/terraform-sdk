using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_network_peering_connection Terraform data source.
/// Retrieves information about a aws_odb_network_peering_connection.
/// </summary>
public partial class AwsOdbNetworkPeeringConnectionDataSource(string name) : TerraformDataSource("aws_odb_network_peering_connection", name)
{
    /// <summary>
    /// Network Peering Connection identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Created time of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// Display name of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> OdbNetworkArn
        => AsReference("odb_network_arn");

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    public TerraformValue<string> OdbPeeringConnectionType
        => AsReference("odb_peering_connection_type");

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    public TerraformValue<string> PeerNetworkArn
        => AsReference("peer_network_arn");

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => AsReference("percent_progress");

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

}
