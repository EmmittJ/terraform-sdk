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
    public TerraformProperty<bool>? ExcludeCompliantResources
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_compliant_resources");
        set => this.WithProperty("exclude_compliant_resources", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The include_compliance_details attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeComplianceDetails
    {
        get => GetProperty<TerraformProperty<bool>>("include_compliance_details");
        set => this.WithProperty("include_compliance_details", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_arn_list attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ResourceArnList
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resource_arn_list");
        set => this.WithProperty("resource_arn_list", value);
    }

    /// <summary>
    /// The resource_type_filters attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ResourceTypeFilters
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resource_type_filters");
        set => this.WithProperty("resource_type_filters", value);
    }

    /// <summary>
    /// The resource_tag_mapping_list attribute.
    /// </summary>
    public TerraformExpression ResourceTagMappingList => this["resource_tag_mapping_list"];

}
