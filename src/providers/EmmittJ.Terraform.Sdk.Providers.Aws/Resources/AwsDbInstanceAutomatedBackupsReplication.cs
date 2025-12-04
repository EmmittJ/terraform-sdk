using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDbInstanceAutomatedBackupsReplication.
/// Nesting mode: single
/// </summary>
public class AwsDbInstanceAutomatedBackupsReplicationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_db_instance_automated_backups_replication Terraform resource.
/// Manages a aws_db_instance_automated_backups_replication resource.
/// </summary>
public partial class AwsDbInstanceAutomatedBackupsReplication(string name) : TerraformResource("aws_db_instance_automated_backups_replication", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The pre_signed_url attribute.
    /// </summary>
    public TerraformValue<string>? PreSignedUrl
    {
        get => GetArgument<TerraformValue<string>>("pre_signed_url");
        set => SetArgument("pre_signed_url", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The source_db_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbInstanceArn is required")]
    public required TerraformValue<string> SourceDbInstanceArn
    {
        get => GetArgument<TerraformValue<string>>("source_db_instance_arn");
        set => SetArgument("source_db_instance_arn", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbInstanceAutomatedBackupsReplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbInstanceAutomatedBackupsReplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
