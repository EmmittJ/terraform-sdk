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
    public required TerraformProperty<TerraformProperty<string>> Bandwidth { get; set; }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    [TerraformPropertyName("owner_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OwnerAccountId { get; set; }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    [TerraformPropertyName("vlan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Vlan { get; set; }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    [TerraformPropertyName("aws_device")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AwsDevice => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_device");

    /// <summary>
    /// The connection_region attribute.
    /// </summary>
    [TerraformPropertyName("connection_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_region");

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    [TerraformPropertyName("has_logical_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HasLogicalRedundancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "has_logical_redundancy");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    [TerraformPropertyName("jumbo_frame_capable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> JumboFrameCapable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "jumbo_frame_capable");

    /// <summary>
    /// The lag_id attribute.
    /// </summary>
    [TerraformPropertyName("lag_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LagId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lag_id");

    /// <summary>
    /// The loa_issue_time attribute.
    /// </summary>
    [TerraformPropertyName("loa_issue_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoaIssueTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "loa_issue_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [TerraformPropertyName("partner_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PartnerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "partner_name");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProviderName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provider_name");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Region => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
