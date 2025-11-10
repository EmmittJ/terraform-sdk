using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tag_filter in .
/// Nesting mode: list
/// </summary>
public class AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_resourcegroupstaggingapi_resources.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public HashSet<TerraformProperty<string>>? ResourceArnList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_arn_list");
        set => this.WithProperty("resource_arn_list", value);
    }

    /// <summary>
    /// The resource_type_filters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceTypeFilters
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_type_filters");
        set => this.WithProperty("resource_type_filters", value);
    }

    /// <summary>
    /// Block for tag_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 TagFilter block(s) allowed")]
    public List<AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock>? TagFilter
    {
        get => GetProperty<List<AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock>>("tag_filter");
        set => this.WithProperty("tag_filter", value);
    }

    /// <summary>
    /// The resource_tag_mapping_list attribute.
    /// </summary>
    public TerraformExpression ResourceTagMappingList => this["resource_tag_mapping_list"];

}
