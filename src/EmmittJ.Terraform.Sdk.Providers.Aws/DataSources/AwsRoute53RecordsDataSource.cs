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
        this.DeclareOutput("resource_record_sets");
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_regex");
        set => this.WithProperty("name_regex", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// The resource_record_sets attribute.
    /// </summary>
    public TerraformExpression ResourceRecordSets => this["resource_record_sets"];

}
