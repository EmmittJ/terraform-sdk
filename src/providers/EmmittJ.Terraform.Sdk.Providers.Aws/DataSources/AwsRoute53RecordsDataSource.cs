using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_records.
/// </summary>
public class AwsRoute53RecordsDataSource : TerraformDataSource
{
    public AwsRoute53RecordsDataSource(string name) : base("aws_route53_records", name)
    {
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NameRegex { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformPropertyName("zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ZoneId { get; set; }

    /// <summary>
    /// The resource_record_sets attribute.
    /// </summary>
    [TerraformPropertyName("resource_record_sets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ResourceRecordSets => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resource_record_sets");

}
