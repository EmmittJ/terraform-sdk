using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for export_config in AwsCodebuildReportGroup.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildReportGroupExportConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_config";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// S3Destination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Destination block(s) allowed")]
    public TerraformList<AwsCodebuildReportGroupExportConfigBlockS3DestinationBlock>? S3Destination
    {
        get => GetArgument<TerraformList<AwsCodebuildReportGroupExportConfigBlockS3DestinationBlock>>("s3_destination");
        set => SetArgument("s3_destination", value);
    }

}

/// <summary>
/// Block type for s3_destination in AwsCodebuildReportGroupExportConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildReportGroupExportConfigBlockS3DestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_destination";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionDisabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_disabled");
        set => SetArgument("encryption_disabled", value);
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    public required TerraformValue<string> EncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("encryption_key");
        set => SetArgument("encryption_key", value);
    }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    public TerraformValue<string>? Packaging
    {
        get => GetArgument<TerraformValue<string>>("packaging");
        set => SetArgument("packaging", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Represents a aws_codebuild_report_group Terraform resource.
/// Manages a aws_codebuild_report_group resource.
/// </summary>
public partial class AwsCodebuildReportGroup(string name) : TerraformResource("aws_codebuild_report_group", name)
{
    /// <summary>
    /// The delete_reports attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteReports
    {
        get => GetArgument<TerraformValue<bool>>("delete_reports");
        set => SetArgument("delete_reports", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformValue<string> Created
        => AsReference("created");

    /// <summary>
    /// ExportConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportConfig block(s) allowed")]
    public required TerraformList<AwsCodebuildReportGroupExportConfigBlock> ExportConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCodebuildReportGroupExportConfigBlock>>("export_config");
        set => SetArgument("export_config", value);
    }

}
