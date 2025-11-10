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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The private_zone attribute.
    /// </summary>
    [TerraformPropertyName("private_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrivateZone { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpcId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZoneId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CallerReference => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "caller_reference");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Comment => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "comment");

    /// <summary>
    /// The linked_service_description attribute.
    /// </summary>
    [TerraformPropertyName("linked_service_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LinkedServiceDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "linked_service_description");

    /// <summary>
    /// The linked_service_principal attribute.
    /// </summary>
    [TerraformPropertyName("linked_service_principal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LinkedServicePrincipal => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "linked_service_principal");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformPropertyName("name_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NameServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "name_servers");

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    [TerraformPropertyName("primary_name_server")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryNameServer => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_name_server");

    /// <summary>
    /// The resource_record_set_count attribute.
    /// </summary>
    [TerraformPropertyName("resource_record_set_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ResourceRecordSetCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "resource_record_set_count");

}
