using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_notifications resource.
/// </summary>
public class AwsBackupVaultNotifications : TerraformResource
{
    public AwsBackupVaultNotifications(string name) : base("aws_backup_vault_notifications", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_vault_arn");
    }

    /// <summary>
    /// The backup_vault_events attribute.
    /// </summary>
    public HashSet<string>? BackupVaultEvents
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("backup_vault_events")?.Value;
        set => this.WithProperty("backup_vault_events", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    public string? BackupVaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_vault_name")?.Value;
        set => this.WithProperty("backup_vault_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public string? SnsTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sns_topic_arn")?.Value;
        set => this.WithProperty("sns_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformExpression BackupVaultArn => this["backup_vault_arn"];

}
