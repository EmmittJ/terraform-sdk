using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_records.
/// </summary>
public partial class AwsRoute53RecordsDataSource : TerraformDataSource
{
    public AwsRoute53RecordsDataSource(string name) : base("aws_route53_records", name)
    {
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformProperty("name_regex")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformProperty("zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// The resource_record_sets attribute.
    /// </summary>
    [TerraformProperty("resource_record_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ResourceRecordSets { get; }

}
