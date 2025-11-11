using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_zone.
/// </summary>
public partial class AwsRoute53ZoneDataSource : TerraformDataSource
{
    public AwsRoute53ZoneDataSource(string name) : base("aws_route53_zone", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_zone attribute.
    /// </summary>
    [TerraformProperty("private_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PrivateZone { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformProperty("caller_reference")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CallerReference { get; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Comment { get; }

    /// <summary>
    /// The linked_service_description attribute.
    /// </summary>
    [TerraformProperty("linked_service_description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LinkedServiceDescription { get; }

    /// <summary>
    /// The linked_service_principal attribute.
    /// </summary>
    [TerraformProperty("linked_service_principal")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LinkedServicePrincipal { get; }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformProperty("name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NameServers { get; }

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    [TerraformProperty("primary_name_server")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryNameServer { get; }

    /// <summary>
    /// The resource_record_set_count attribute.
    /// </summary>
    [TerraformProperty("resource_record_set_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ResourceRecordSetCount { get; }

}
