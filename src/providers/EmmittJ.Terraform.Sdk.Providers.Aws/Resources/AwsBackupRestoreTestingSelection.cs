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
        SetOutput("iam_role_arn");
        SetOutput("name");
        SetOutput("protected_resource_arns");
        SetOutput("protected_resource_type");
        SetOutput("region");
        SetOutput("restore_metadata_overrides");
        SetOutput("restore_testing_plan_name");
        SetOutput("validation_window_hours");
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protected_resource_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ProtectedResourceArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("protected_resource_arns");
        set => SetProperty("protected_resource_arns", value);
    }

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedResourceType is required")]
    public required TerraformProperty<string> ProtectedResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protected_resource_type");
        set => SetProperty("protected_resource_type", value);
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
    /// The restore_metadata_overrides attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> RestoreMetadataOverrides
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("restore_metadata_overrides");
        set => SetProperty("restore_metadata_overrides", value);
    }

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTestingPlanName is required")]
    public required TerraformProperty<string> RestoreTestingPlanName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restore_testing_plan_name");
        set => SetProperty("restore_testing_plan_name", value);
    }

    /// <summary>
    /// The validation_window_hours attribute.
    /// </summary>
    public TerraformProperty<double> ValidationWindowHours
    {
        get => GetRequiredOutput<TerraformProperty<double>>("validation_window_hours");
        set => SetProperty("validation_window_hours", value);
    }

    /// <summary>
    /// Block for protected_resource_conditions.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock>? ProtectedResourceConditions
    {
        set => SetProperty("protected_resource_conditions", value);
    }

}
