using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tag_filter in AwsResourcegroupstaggingapiResourcesDataSource.
/// Nesting mode: list
/// </summary>
public class AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_resourcegroupstaggingapi_resources Terraform data source.
/// Retrieves information about a aws_resourcegroupstaggingapi_resources.
/// </summary>
public partial class AwsResourcegroupstaggingapiResourcesDataSource(string name) : TerraformDataSource("aws_resourcegroupstaggingapi_resources", name)
{
    /// <summary>
    /// The exclude_compliant_resources attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeCompliantResources
    {
        get => GetArgument<TerraformValue<bool>>("exclude_compliant_resources");
        set => SetArgument("exclude_compliant_resources", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_compliance_details attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeComplianceDetails
    {
        get => GetArgument<TerraformValue<bool>>("include_compliance_details");
        set => SetArgument("include_compliance_details", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_arn_list attribute.
    /// </summary>
    public TerraformSet<string>? ResourceArnList
    {
        get => GetArgument<TerraformSet<string>>("resource_arn_list");
        set => SetArgument("resource_arn_list", value);
    }

    /// <summary>
    /// The resource_type_filters attribute.
    /// </summary>
    public TerraformSet<string>? ResourceTypeFilters
    {
        get => GetArgument<TerraformSet<string>>("resource_type_filters");
        set => SetArgument("resource_type_filters", value);
    }

    /// <summary>
    /// The resource_tag_mapping_list attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceTagMappingList
        => CreateReference("resource_tag_mapping_list");

    /// <summary>
    /// TagFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 TagFilter block(s) allowed")]
    public TerraformList<AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock>? TagFilter
    {
        get => GetArgument<TerraformList<AwsResourcegroupstaggingapiResourcesDataSourceTagFilterBlock>>("tag_filter");
        set => SetArgument("tag_filter", value);
    }

}
