using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_records.
/// </summary>
public class AwsRoute53RecordsDataSource : TerraformDataSource
{
    public AwsRoute53RecordsDataSource(string name) : base("aws_route53_records", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("resource_record_sets");
        SetOutput("name_regex");
        SetOutput("zone_id");
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformProperty<string> NameRegex
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_regex");
        set => SetProperty("name_regex", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone_id");
        set => SetProperty("zone_id", value);
    }

    /// <summary>
    /// The resource_record_sets attribute.
    /// </summary>
    public TerraformExpression ResourceRecordSets => this["resource_record_sets"];

}
