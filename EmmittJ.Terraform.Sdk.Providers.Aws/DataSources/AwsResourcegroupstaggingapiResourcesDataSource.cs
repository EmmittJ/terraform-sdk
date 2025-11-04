using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_resourcegroupstaggingapi_resources.
/// </summary>
public class AwsResourcegroupstaggingapiResourcesDataSource : TerraformDataSource
{
    public AwsResourcegroupstaggingapiResourcesDataSource(string name) : base("aws_resourcegroupstaggingapi_resources", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_tag_mapping_list");
    }

    /// <summary>
    /// The exclude_compliant_resources attribute.
    /// </summary>
    public bool? ExcludeCompliantResources
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_compliant_resources")?.Value;
        set => this.WithProperty("exclude_compliant_resources", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The include_compliance_details attribute.
    /// </summary>
    public bool? IncludeComplianceDetails
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_compliance_details")?.Value;
        set => this.WithProperty("include_compliance_details", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_arn_list attribute.
    /// </summary>
    public HashSet<string>? ResourceArnList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_arn_list")?.Value;
        set => this.WithProperty("resource_arn_list", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The resource_type_filters attribute.
    /// </summary>
    public HashSet<string>? ResourceTypeFilters
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_type_filters")?.Value;
        set => this.WithProperty("resource_type_filters", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The resource_tag_mapping_list attribute.
    /// </summary>
    public TerraformExpression ResourceTagMappingList => this["resource_tag_mapping_list"];

}
