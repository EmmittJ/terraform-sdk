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
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protected_resource_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ProtectedResourceArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("protected_resource_arns");
        set => this.WithProperty("protected_resource_arns", value);
    }

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectedResourceType
    {
        get => GetProperty<TerraformProperty<string>>("protected_resource_type");
        set => this.WithProperty("protected_resource_type", value);
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
    /// The restore_metadata_overrides attribute.
    /// </summary>
    public TerraformMapProperty<string>? RestoreMetadataOverrides
    {
        get => GetProperty<TerraformMapProperty<string>>("restore_metadata_overrides");
        set => this.WithProperty("restore_metadata_overrides", value);
    }

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreTestingPlanName
    {
        get => GetProperty<TerraformProperty<string>>("restore_testing_plan_name");
        set => this.WithProperty("restore_testing_plan_name", value);
    }

    /// <summary>
    /// The validation_window_hours attribute.
    /// </summary>
    public TerraformProperty<double>? ValidationWindowHours
    {
        get => GetProperty<TerraformProperty<double>>("validation_window_hours");
        set => this.WithProperty("validation_window_hours", value);
    }

}
