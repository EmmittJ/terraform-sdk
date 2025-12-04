using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsKinesisanalyticsv2ApplicationSnapshot.
/// Nesting mode: single
/// </summary>
public class AwsKinesisanalyticsv2ApplicationSnapshotTimeoutsBlock : TerraformBlock
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
/// Represents a aws_kinesisanalyticsv2_application_snapshot Terraform resource.
/// Manages a aws_kinesisanalyticsv2_application_snapshot resource.
/// </summary>
public partial class AwsKinesisanalyticsv2ApplicationSnapshot(string name) : TerraformResource("aws_kinesisanalyticsv2_application_snapshot", name)
{
    /// <summary>
    /// The application_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationName is required")]
    public required TerraformValue<string> ApplicationName
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_name");
        set => SetArgument("application_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    public required TerraformValue<string> SnapshotName
    {
        get => GetRequiredArgument<TerraformValue<string>>("snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

    /// <summary>
    /// The application_version_id attribute.
    /// </summary>
    public TerraformValue<double> ApplicationVersionId
        => AsReference("application_version_id");

    /// <summary>
    /// The snapshot_creation_timestamp attribute.
    /// </summary>
    public TerraformValue<string> SnapshotCreationTimestamp
        => AsReference("snapshot_creation_timestamp");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKinesisanalyticsv2ApplicationSnapshotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKinesisanalyticsv2ApplicationSnapshotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
