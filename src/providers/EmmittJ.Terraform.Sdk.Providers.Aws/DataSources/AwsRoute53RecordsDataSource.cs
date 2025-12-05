using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_records Terraform data source.
/// Retrieves information about a aws_route53_records.
/// </summary>
public partial class AwsRoute53RecordsDataSource(string name) : TerraformDataSource("aws_route53_records", name)
{
    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => GetArgument<TerraformValue<string>>("name_regex");
        set => SetArgument("name_regex", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformValue<string> ZoneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The resource_record_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceRecordSets
        => CreateReference("resource_record_sets");

}
