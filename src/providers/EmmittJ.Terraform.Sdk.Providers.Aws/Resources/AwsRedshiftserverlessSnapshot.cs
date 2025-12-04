using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_snapshot Terraform resource.
/// Manages a aws_redshiftserverless_snapshot resource.
/// </summary>
public partial class AwsRedshiftserverlessSnapshot(string name) : TerraformResource("aws_redshiftserverless_snapshot", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    public required TerraformValue<string> SnapshotName
    {
        get => GetRequiredArgument<TerraformValue<string>>("snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

    /// <summary>
    /// The accounts_with_provisioned_restore_access attribute.
    /// </summary>
    public TerraformSet<string> AccountsWithProvisionedRestoreAccess
        => AsReference("accounts_with_provisioned_restore_access");

    /// <summary>
    /// The accounts_with_restore_access attribute.
    /// </summary>
    public TerraformSet<string> AccountsWithRestoreAccess
        => AsReference("accounts_with_restore_access");

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
        => AsReference("admin_username");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The namespace_arn attribute.
    /// </summary>
    public TerraformValue<string> NamespaceArn
        => AsReference("namespace_arn");

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccount
        => AsReference("owner_account");

}
