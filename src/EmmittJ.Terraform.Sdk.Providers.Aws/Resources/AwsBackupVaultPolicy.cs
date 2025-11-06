using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_vault_policy resource.
/// </summary>
public class AwsBackupVaultPolicy : TerraformResource
{
    public AwsBackupVaultPolicy(string name) : base("aws_backup_vault_policy", name)
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The backup_vault_arn attribute.
    /// </summary>
    public TerraformExpression BackupVaultArn => this["backup_vault_arn"];

}
