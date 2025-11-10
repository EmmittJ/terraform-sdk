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
        this.WithOutput("accounts_with_provisioned_restore_access");
        this.WithOutput("accounts_with_restore_access");
        this.WithOutput("admin_username");
        this.WithOutput("arn");
        this.WithOutput("kms_key_id");
        this.WithOutput("namespace_arn");
        this.WithOutput("owner_account");
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
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformProperty<string> NamespaceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("retention_period");
        set => this.WithProperty("retention_period", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    public required TerraformProperty<string> SnapshotName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("snapshot_name");
        set => this.WithProperty("snapshot_name", value);
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
