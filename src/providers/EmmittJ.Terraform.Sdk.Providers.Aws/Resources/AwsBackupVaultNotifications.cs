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
        this.WithOutput("backup_vault_arn");
    }

    /// <summary>
    /// The backup_vault_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultEvents is required")]
    public HashSet<TerraformProperty<string>>? BackupVaultEvents
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("backup_vault_events");
        set => this.WithProperty("backup_vault_events", value);
    }

    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    public required TerraformProperty<string> BackupVaultName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backup_vault_name");
        set => this.WithProperty("backup_vault_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsTopicArn is required")]
    public required TerraformProperty<string> SnsTopicArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sns_topic_arn");
        set => this.WithProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformExpression BackupVaultArn => this["backup_vault_arn"];

}
