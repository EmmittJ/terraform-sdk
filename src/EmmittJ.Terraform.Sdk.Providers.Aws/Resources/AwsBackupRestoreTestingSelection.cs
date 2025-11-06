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
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protected_resource_arns attribute.
    /// </summary>
    public HashSet<string>? ProtectedResourceArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protected_resource_arns")?.Value;
        set => this.WithProperty("protected_resource_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    public string? ProtectedResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protected_resource_type")?.Value;
        set => this.WithProperty("protected_resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The restore_metadata_overrides attribute.
    /// </summary>
    public Dictionary<string, string>? RestoreMetadataOverrides
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("restore_metadata_overrides")?.Value;
        set => this.WithProperty("restore_metadata_overrides", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    public string? RestoreTestingPlanName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_testing_plan_name")?.Value;
        set => this.WithProperty("restore_testing_plan_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The validation_window_hours attribute.
    /// </summary>
    public double? ValidationWindowHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("validation_window_hours")?.Value;
        set => this.WithProperty("validation_window_hours", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
