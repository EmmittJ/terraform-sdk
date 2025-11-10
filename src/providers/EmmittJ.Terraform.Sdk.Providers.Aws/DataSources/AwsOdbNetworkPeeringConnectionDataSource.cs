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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// Created time of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// Display name of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("odb_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OdbNetworkArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_network_arn");

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    [TerraformPropertyName("odb_peering_connection_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OdbPeeringConnectionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_peering_connection_type");

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    [TerraformPropertyName("peer_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerNetworkArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_network_arn");

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
