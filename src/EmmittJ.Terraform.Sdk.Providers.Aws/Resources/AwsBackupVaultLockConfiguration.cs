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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    public required TerraformProperty<string> BackupVaultName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backup_vault_name");
        set => this.WithProperty("backup_vault_name", value);
    }

    /// <summary>
    /// The changeable_for_days attribute.
    /// </summary>
    public TerraformProperty<double>? ChangeableForDays
    {
        get => GetProperty<TerraformProperty<double>>("changeable_for_days");
        set => this.WithProperty("changeable_for_days", value);
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
    /// The max_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("max_retention_days");
        set => this.WithProperty("max_retention_days", value);
    }

    /// <summary>
    /// The min_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? MinRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("min_retention_days");
        set => this.WithProperty("min_retention_days", value);
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
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformExpression BackupVaultArn => this["backup_vault_arn"];

}
