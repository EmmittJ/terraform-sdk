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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Created time of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// Display name of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> OdbNetworkArn
    {
        get => new TerraformReference<string>(this, "odb_network_arn");
    }

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    public TerraformValue<string> OdbPeeringConnectionType
    {
        get => new TerraformReference<string>(this, "odb_peering_connection_type");
    }

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    public TerraformValue<string> PeerNetworkArn
    {
        get => new TerraformReference<string>(this, "peer_network_arn");
    }

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
