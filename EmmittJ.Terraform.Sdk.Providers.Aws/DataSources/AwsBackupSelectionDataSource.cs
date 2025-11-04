using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_backup_selection.
/// </summary>
public class AwsBackupSelectionDataSource : TerraformDataSource
{
    public AwsBackupSelectionDataSource(string name) : base("aws_backup_selection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("iam_role_arn");
        this.DeclareOutput("name");
        this.DeclareOutput("resources");
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
    /// The plan_id attribute.
    /// </summary>
    public string? PlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan_id")?.Value;
        set => this.WithProperty("plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The selection_id attribute.
    /// </summary>
    public string? SelectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("selection_id")?.Value;
        set => this.WithProperty("selection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformExpression IamRoleArn => this["iam_role_arn"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformExpression Resources => this["resources"];

}
