using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for partition_index in AwsGluePartitionIndex.
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionIndexPartitionIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partition_index";

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    public TerraformValue<string>? IndexName
    {
        get => GetArgument<TerraformValue<string>>("index_name");
        set => SetArgument("index_name", value);
    }

    /// <summary>
    /// The index_status attribute.
    /// </summary>
    public TerraformValue<string> IndexStatus
        => AsReference("index_status");

    /// <summary>
    /// The keys attribute.
    /// </summary>
    public TerraformList<string>? KeysAttribute
    {
        get => GetArgument<TerraformList<string>>("keys");
        set => SetArgument("keys", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGluePartitionIndex.
/// Nesting mode: single
/// </summary>
public class AwsGluePartitionIndexTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_glue_partition_index Terraform resource.
/// Manages a aws_glue_partition_index resource.
/// </summary>
public partial class AwsGluePartitionIndex(string name) : TerraformResource("aws_glue_partition_index", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// PartitionIndex block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionIndex is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PartitionIndex block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionIndex block(s) allowed")]
    public required TerraformList<AwsGluePartitionIndexPartitionIndexBlock> PartitionIndex
    {
        get => GetRequiredArgument<TerraformList<AwsGluePartitionIndexPartitionIndexBlock>>("partition_index");
        set => SetArgument("partition_index", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGluePartitionIndexTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGluePartitionIndexTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
