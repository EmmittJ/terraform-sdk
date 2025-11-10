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
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("display_name");
        SetOutput("odb_network_arn");
        SetOutput("odb_peering_connection_type");
        SetOutput("peer_network_arn");
        SetOutput("percent_progress");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("tags");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// Network Peering Connection identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
