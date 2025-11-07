using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_restore_testing_selection resource.
/// </summary>
public class AwsBackupRestoreTestingSelection : TerraformResource
{
    public AwsBackupRestoreTestingSelection(string name) : base("aws_backup_restore_testing_selection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protected_resource_arns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ProtectedResourceArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protected_resource_arns");
        set => this.WithProperty("protected_resource_arns", value);
    }

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProtectedResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protected_resource_type");
        set => this.WithProperty("protected_resource_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The restore_metadata_overrides attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? RestoreMetadataOverrides
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("restore_metadata_overrides");
        set => this.WithProperty("restore_metadata_overrides", value);
    }

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestoreTestingPlanName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_testing_plan_name");
        set => this.WithProperty("restore_testing_plan_name", value);
    }

    /// <summary>
    /// The validation_window_hours attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ValidationWindowHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("validation_window_hours");
        set => this.WithProperty("validation_window_hours", value);
    }

}
