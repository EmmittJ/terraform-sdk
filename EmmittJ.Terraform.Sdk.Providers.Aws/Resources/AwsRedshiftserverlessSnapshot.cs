using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_snapshot resource.
/// </summary>
public class AwsRedshiftserverlessSnapshot : TerraformResource
{
    public AwsRedshiftserverlessSnapshot(string name) : base("aws_redshiftserverless_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accounts_with_provisioned_restore_access");
        this.DeclareOutput("accounts_with_restore_access");
        this.DeclareOutput("admin_username");
        this.DeclareOutput("arn");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("namespace_arn");
        this.DeclareOutput("owner_account");
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
    /// The namespace_name attribute.
    /// </summary>
    public string? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name")?.Value;
        set => this.WithProperty("namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The retention_period attribute.
    /// </summary>
    public double? RetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period")?.Value;
        set => this.WithProperty("retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public string? SnapshotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_name")?.Value;
        set => this.WithProperty("snapshot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The accounts_with_provisioned_restore_access attribute.
    /// </summary>
    public TerraformExpression AccountsWithProvisionedRestoreAccess => this["accounts_with_provisioned_restore_access"];

    /// <summary>
    /// The accounts_with_restore_access attribute.
    /// </summary>
    public TerraformExpression AccountsWithRestoreAccess => this["accounts_with_restore_access"];

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformExpression AdminUsername => this["admin_username"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The namespace_arn attribute.
    /// </summary>
    public TerraformExpression NamespaceArn => this["namespace_arn"];

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformExpression OwnerAccount => this["owner_account"];

}
