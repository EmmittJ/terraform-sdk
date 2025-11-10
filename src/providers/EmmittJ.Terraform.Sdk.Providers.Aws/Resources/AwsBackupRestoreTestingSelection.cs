using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protected_resource_conditions in .
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock : TerraformBlock
{
}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protected_resource_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProtectedResourceArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("protected_resource_arns");
        set => this.WithProperty("protected_resource_arns", value);
    }

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedResourceType is required")]
    public required TerraformProperty<string> ProtectedResourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("protected_resource_type");
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
    public Dictionary<string, TerraformProperty<string>>? RestoreMetadataOverrides
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("restore_metadata_overrides");
        set => this.WithProperty("restore_metadata_overrides", value);
    }

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTestingPlanName is required")]
    public required TerraformProperty<string> RestoreTestingPlanName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("restore_testing_plan_name");
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

    /// <summary>
    /// Block for protected_resource_conditions.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock>? ProtectedResourceConditions
    {
        get => GetProperty<List<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock>>("protected_resource_conditions");
        set => this.WithProperty("protected_resource_conditions", value);
    }

}
