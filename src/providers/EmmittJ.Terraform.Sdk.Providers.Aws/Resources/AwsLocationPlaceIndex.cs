using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_source_configuration in AwsLocationPlaceIndex.
/// Nesting mode: list
/// </summary>
public class AwsLocationPlaceIndexDataSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_source_configuration";

    /// <summary>
    /// The intended_use attribute.
    /// </summary>
    public TerraformValue<string>? IntendedUse
    {
        get => GetArgument<TerraformValue<string>>("intended_use");
        set => SetArgument("intended_use", value);
    }

}


/// <summary>
/// Represents a aws_location_place_index Terraform resource.
/// Manages a aws_location_place_index resource.
/// </summary>
public partial class AwsLocationPlaceIndex(string name) : TerraformResource("aws_location_place_index", name)
{
    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    public required TerraformValue<string> DataSource
    {
        get => GetArgument<TerraformValue<string>>("data_source");
        set => SetArgument("data_source", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformValue<string> IndexName
    {
        get => GetArgument<TerraformValue<string>>("index_name");
        set => SetArgument("index_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The index_arn attribute.
    /// </summary>
    public TerraformValue<string> IndexArn
        => AsReference("index_arn");

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// DataSourceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSourceConfiguration block(s) allowed")]
    public TerraformList<AwsLocationPlaceIndexDataSourceConfigurationBlock>? DataSourceConfiguration
    {
        get => GetArgument<TerraformList<AwsLocationPlaceIndexDataSourceConfigurationBlock>>("data_source_configuration");
        set => SetArgument("data_source_configuration", value);
    }

}
