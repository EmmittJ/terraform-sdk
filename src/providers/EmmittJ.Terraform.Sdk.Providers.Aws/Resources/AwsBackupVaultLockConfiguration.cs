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
        SetOutput("backup_vault_arn");
        SetOutput("backup_vault_name");
        SetOutput("changeable_for_days");
        SetOutput("id");
        SetOutput("max_retention_days");
        SetOutput("min_retention_days");
        SetOutput("region");
    }

    /// <summary>
    /// The backup_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultName is required")]
    public required TerraformProperty<string> BackupVaultName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_vault_name");
        set => SetProperty("backup_vault_name", value);
    }

    /// <summary>
    /// The changeable_for_days attribute.
    /// </summary>
    public TerraformProperty<double> ChangeableForDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("changeable_for_days");
        set => SetProperty("changeable_for_days", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> MaxRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_retention_days");
        set => SetProperty("max_retention_days", value);
    }

    /// <summary>
    /// The min_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> MinRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_retention_days");
        set => SetProperty("min_retention_days", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformExpression BackupVaultArn => this["backup_vault_arn"];

}
