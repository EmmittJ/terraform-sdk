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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriod
    {
        get => new TerraformReference<double>(this, "retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotName is required")]
    public required TerraformValue<string> SnapshotName
    {
        get => new TerraformReference<string>(this, "snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

    /// <summary>
    /// The accounts_with_provisioned_restore_access attribute.
    /// </summary>
    public TerraformSet<string> AccountsWithProvisionedRestoreAccess
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accounts_with_provisioned_restore_access").ResolveNodes(ctx));
    }

    /// <summary>
    /// The accounts_with_restore_access attribute.
    /// </summary>
    public TerraformSet<string> AccountsWithRestoreAccess
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accounts_with_restore_access").ResolveNodes(ctx));
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The namespace_arn attribute.
    /// </summary>
    public TerraformValue<string> NamespaceArn
    {
        get => new TerraformReference<string>(this, "namespace_arn");
    }

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccount
    {
        get => new TerraformReference<string>(this, "owner_account");
    }

}
