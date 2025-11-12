using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOdbNetworkPeeringConnectionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// A peering connection between an ODB network and either another ODB network or a customer-owned VPC.
/// </summary>
public partial class AwsOdbNetworkPeeringConnection : TerraformResource
{
    public AwsOdbNetworkPeeringConnection(string name) : base("aws_odb_network_peering_connection", name)
    {
    }

    /// <summary>
    /// Display name of the odb network peering connection. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Required field. The unique identifier of the ODB network that initiates the peering connection. A sample ID is odbpcx-abcdefgh12345678. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    [TerraformProperty("odb_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OdbNetworkId { get; set; }

    /// <summary>
    /// Required field. The unique identifier of the ODB peering connection. Changing this will force terraform to create new resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerNetworkId is required")]
    [TerraformProperty("peer_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeerNetworkId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsOdbNetworkPeeringConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// Created time of the odb network peering connection.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// ARN of the odb network peering connection.
    /// </summary>
    [TerraformProperty("odb_network_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OdbNetworkArn { get; }

    /// <summary>
    /// Type of the odb peering connection.
    /// </summary>
    [TerraformProperty("odb_peering_connection_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OdbPeeringConnectionType { get; }

    /// <summary>
    /// ARN of the peer network peering connection.
    /// </summary>
    [TerraformProperty("peer_network_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PeerNetworkArn { get; }

    /// <summary>
    /// Progress of the odb network peering connection.
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// Status of the odb network peering connection.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The reason for the current status of the ODB peering connection..
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
