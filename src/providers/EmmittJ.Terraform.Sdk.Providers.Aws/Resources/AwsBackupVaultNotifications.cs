using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_backup_vault_notifications Terraform resource.
/// Manages a aws_backup_vault_notifications resource.
/// </summary>
public partial class AwsBackupVaultNotifications(string name) : TerraformResource("aws_backup_vault_notifications", name)
{
    /// <summary>
    /// The backup_vault_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultEvents is required")]
    public required TerraformSet<string> BackupVaultEvents
    {
        get => GetRequiredArgument<TerraformSet<string>>("backup_vault_events");
        set => SetArgument("backup_vault_events", value);
    }

    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    public required TerraformValue<string> BackupVaultName
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_vault_name");
        set => SetArgument("backup_vault_name", value);
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
    /// The sns_topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsTopicArn is required")]
    public required TerraformValue<string> SnsTopicArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("sns_topic_arn");
        set => SetArgument("sns_topic_arn", value);
    }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformValue<string> BackupVaultArn
        => AsReference("backup_vault_arn");

}
