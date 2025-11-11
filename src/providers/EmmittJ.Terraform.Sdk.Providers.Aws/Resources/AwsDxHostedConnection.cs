using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_hosted_connection resource.
/// </summary>
public partial class AwsDxHostedConnection : TerraformResource
{
    public AwsDxHostedConnection(string name) : base("aws_dx_hosted_connection", name)
    {
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    [TerraformProperty("bandwidth")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bandwidth { get; set; }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    [TerraformProperty("owner_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OwnerAccountId { get; set; }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    [TerraformProperty("vlan")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Vlan { get; set; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformProperty("aws_device")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AwsDevice { get; }

    /// <summary>
    /// The connection_region attribute.
    /// </summary>
    [TerraformProperty("connection_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConnectionRegion { get; }

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    [TerraformProperty("has_logical_redundancy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HasLogicalRedundancy { get; }

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformProperty("jumbo_frame_capable")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> JumboFrameCapable { get; }

    /// <summary>
    /// The lag_id attribute.
    /// </summary>
    [TerraformProperty("lag_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LagId { get; }

    /// <summary>
    /// The loa_issue_time attribute.
    /// </summary>
    [TerraformProperty("loa_issue_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LoaIssueTime { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [TerraformProperty("partner_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PartnerName { get; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProviderName { get; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Region { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
