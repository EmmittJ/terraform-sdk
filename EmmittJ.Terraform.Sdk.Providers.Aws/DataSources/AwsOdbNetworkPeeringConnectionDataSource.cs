using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_network_peering_connection.
/// </summary>
public class AwsOdbNetworkPeeringConnectionDataSource : TerraformDataSource
{
    public AwsOdbNetworkPeeringConnectionDataSource(string name) : base("aws_odb_network_peering_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("display_name");
        this.DeclareOutput("odb_network_arn");
        this.DeclareOutput("odb_peering_connection_type");
        this.DeclareOutput("peer_network_arn");
        this.DeclareOutput("percent_progress");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// Network Peering Connection identifier.
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// Created time of the odb network peering connection.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// Display name of the odb network peering connection.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    public TerraformExpression OdbNetworkArn => this["odb_network_arn"];

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    public TerraformExpression OdbPeeringConnectionType => this["odb_peering_connection_type"];

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    public TerraformExpression PeerNetworkArn => this["peer_network_arn"];

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
