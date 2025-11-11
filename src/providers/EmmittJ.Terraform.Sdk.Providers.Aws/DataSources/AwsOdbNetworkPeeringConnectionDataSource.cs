using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_network_peering_connection.
/// </summary>
public class AwsOdbNetworkPeeringConnectionDataSource : TerraformDataSource
{
    public AwsOdbNetworkPeeringConnectionDataSource(string name) : base("aws_odb_network_peering_connection", name)
    {
    }

    /// <summary>
    /// Network Peering Connection identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// Created time of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// Display name of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("odb_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OdbNetworkArn => new TerraformReference(this, "odb_network_arn");

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    [TerraformPropertyName("odb_peering_connection_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OdbPeeringConnectionType => new TerraformReference(this, "odb_peering_connection_type");

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    [TerraformPropertyName("peer_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerNetworkArn => new TerraformReference(this, "peer_network_arn");

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PercentProgress => new TerraformReference(this, "percent_progress");

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
