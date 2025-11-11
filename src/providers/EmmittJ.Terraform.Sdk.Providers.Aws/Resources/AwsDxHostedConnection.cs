using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_hosted_connection resource.
/// </summary>
public class AwsDxHostedConnection : TerraformResource
{
    public AwsDxHostedConnection(string name) : base("aws_dx_hosted_connection", name)
    {
    }

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    [TerraformPropertyName("bandwidth")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bandwidth { get; set; }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    [TerraformPropertyName("owner_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OwnerAccountId { get; set; }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    [TerraformPropertyName("vlan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Vlan { get; set; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformPropertyName("aws_device")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsDevice => new TerraformReference(this, "aws_device");

    /// <summary>
    /// The connection_region attribute.
    /// </summary>
    [TerraformPropertyName("connection_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionRegion => new TerraformReference(this, "connection_region");

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    [TerraformPropertyName("has_logical_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HasLogicalRedundancy => new TerraformReference(this, "has_logical_redundancy");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformPropertyName("jumbo_frame_capable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> JumboFrameCapable => new TerraformReference(this, "jumbo_frame_capable");

    /// <summary>
    /// The lag_id attribute.
    /// </summary>
    [TerraformPropertyName("lag_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LagId => new TerraformReference(this, "lag_id");

    /// <summary>
    /// The loa_issue_time attribute.
    /// </summary>
    [TerraformPropertyName("loa_issue_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoaIssueTime => new TerraformReference(this, "loa_issue_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [TerraformPropertyName("partner_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PartnerName => new TerraformReference(this, "partner_name");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProviderName => new TerraformReference(this, "provider_name");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Region => new TerraformReference(this, "region");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
