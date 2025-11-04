using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_selection resource.
/// </summary>
public class AwsBackupSelection : TerraformResource
{
    public AwsBackupSelection(string name) : base("aws_backup_selection", name)
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The not_resources attribute.
    /// </summary>
    public HashSet<string>? NotResources
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("not_resources")?.Value;
        set => this.WithProperty("not_resources", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    public string? PlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan_id")?.Value;
        set => this.WithProperty("plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public HashSet<string>? Resources
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resources")?.Value;
        set => this.WithProperty("resources", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
