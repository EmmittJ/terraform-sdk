using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_record_tables in AwsGlueMlTransform.
/// Nesting mode: list
/// </summary>
public class AwsGlueMlTransformInputRecordTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_record_tables";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionName
    {
        get => new TerraformReference<string>(this, "connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

}


/// <summary>
/// Block type for parameters in AwsGlueMlTransform.
/// Nesting mode: list
/// </summary>
public class AwsGlueMlTransformParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The transform_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformType is required")]
    public required TerraformValue<string> TransformType
    {
        get => new TerraformReference<string>(this, "transform_type");
        set => SetArgument("transform_type", value);
    }

    /// <summary>
    /// FindMatchesParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FindMatchesParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FindMatchesParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FindMatchesParameters block(s) allowed")]
    public required TerraformList<AwsGlueMlTransformParametersBlockFindMatchesParametersBlock> FindMatchesParameters
    {
        get => GetRequiredArgument<TerraformList<AwsGlueMlTransformParametersBlockFindMatchesParametersBlock>>("find_matches_parameters");
        set => SetArgument("find_matches_parameters", value);
    }

}

/// <summary>
/// Block type for find_matches_parameters in AwsGlueMlTransformParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueMlTransformParametersBlockFindMatchesParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "find_matches_parameters";

    /// <summary>
    /// The accuracy_cost_trade_off attribute.
    /// </summary>
    public TerraformValue<double>? AccuracyCostTradeOff
    {
        get => new TerraformReference<double>(this, "accuracy_cost_trade_off");
        set => SetArgument("accuracy_cost_trade_off", value);
    }

    /// <summary>
    /// The enforce_provided_labels attribute.
    /// </summary>
    public TerraformValue<bool>? EnforceProvidedLabels
    {
        get => new TerraformReference<bool>(this, "enforce_provided_labels");
        set => SetArgument("enforce_provided_labels", value);
    }

    /// <summary>
    /// The precision_recall_trade_off attribute.
    /// </summary>
    public TerraformValue<double>? PrecisionRecallTradeOff
    {
        get => new TerraformReference<double>(this, "precision_recall_trade_off");
        set => SetArgument("precision_recall_trade_off", value);
    }

    /// <summary>
    /// The primary_key_column_name attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryKeyColumnName
    {
        get => new TerraformReference<string>(this, "primary_key_column_name");
        set => SetArgument("primary_key_column_name", value);
    }

}


/// <summary>
/// Represents a aws_glue_ml_transform Terraform resource.
/// Manages a aws_glue_ml_transform resource.
/// </summary>
public partial class AwsGlueMlTransform(string name) : TerraformResource("aws_glue_ml_transform", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public TerraformValue<string> GlueVersion
    {
        get => new TerraformReference<string>(this, "glue_version");
        set => SetArgument("glue_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double> MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    public TerraformValue<double>? MaxRetries
    {
        get => new TerraformReference<double>(this, "max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfWorkers
    {
        get => new TerraformReference<double>(this, "number_of_workers");
        set => SetArgument("number_of_workers", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformValue<string>? WorkerType
    {
        get => new TerraformReference<string>(this, "worker_type");
        set => SetArgument("worker_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The label_count attribute.
    /// </summary>
    public TerraformValue<double> LabelCount
    {
        get => new TerraformReference<double>(this, "label_count");
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Schema
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "schema").ResolveNodes(ctx));
    }

    /// <summary>
    /// InputRecordTables block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputRecordTables is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputRecordTables block(s) required")]
    public required TerraformList<AwsGlueMlTransformInputRecordTablesBlock> InputRecordTables
    {
        get => GetRequiredArgument<TerraformList<AwsGlueMlTransformInputRecordTablesBlock>>("input_record_tables");
        set => SetArgument("input_record_tables", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public required TerraformList<AwsGlueMlTransformParametersBlock> Parameters
    {
        get => GetRequiredArgument<TerraformList<AwsGlueMlTransformParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}
