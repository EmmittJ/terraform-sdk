using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_lock_configuration resource.
/// </summary>
public class AwsBackupVaultLockConfiguration : TerraformResource
{
    public AwsBackupVaultLockConfiguration(string name) : base("aws_backup_vault_lock_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_vault_arn");
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
    /// The changeable_for_days attribute.
    /// </summary>
    public double? ChangeableForDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("changeable_for_days")?.Value;
        set => this.WithProperty("changeable_for_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The max_retention_days attribute.
    /// </summary>
    public double? MaxRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_retention_days")?.Value;
        set => this.WithProperty("max_retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_retention_days attribute.
    /// </summary>
    public double? MinRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_retention_days")?.Value;
        set => this.WithProperty("min_retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformExpression BackupVaultArn => this["backup_vault_arn"];

}
