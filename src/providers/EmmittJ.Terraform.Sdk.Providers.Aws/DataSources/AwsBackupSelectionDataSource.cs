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
        this.WithOutput("iam_role_arn");
        this.WithOutput("name");
        this.WithOutput("resources");
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
    /// The plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlanId is required")]
    public required TerraformProperty<string> PlanId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("plan_id");
        set => this.WithProperty("plan_id", value);
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
    /// The selection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionId is required")]
    public required TerraformProperty<string> SelectionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("selection_id");
        set => this.WithProperty("selection_id", value);
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
