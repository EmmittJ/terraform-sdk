using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_zone.
/// </summary>
public class AwsRoute53ZoneDataSource : TerraformDataSource
{
    public AwsRoute53ZoneDataSource(string name) : base("aws_route53_zone", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The private_zone attribute.
    /// </summary>
    [TerraformPropertyName("private_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateZone { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VpcId { get; set; } = default!;

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ZoneId { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CallerReference => new TerraformReference(this, "caller_reference");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Comment => new TerraformReference(this, "comment");

    /// <summary>
    /// The linked_service_description attribute.
    /// </summary>
    [TerraformPropertyName("linked_service_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LinkedServiceDescription => new TerraformReference(this, "linked_service_description");

    /// <summary>
    /// The linked_service_principal attribute.
    /// </summary>
    [TerraformPropertyName("linked_service_principal")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LinkedServicePrincipal => new TerraformReference(this, "linked_service_principal");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformPropertyName("name_servers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NameServers => new TerraformReference(this, "name_servers");

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    [TerraformPropertyName("primary_name_server")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryNameServer => new TerraformReference(this, "primary_name_server");

    /// <summary>
    /// The resource_record_set_count attribute.
    /// </summary>
    [TerraformPropertyName("resource_record_set_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ResourceRecordSetCount => new TerraformReference(this, "resource_record_set_count");

}
