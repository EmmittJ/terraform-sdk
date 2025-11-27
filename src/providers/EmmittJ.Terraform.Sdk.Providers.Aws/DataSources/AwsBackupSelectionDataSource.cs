using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_backup_selection Terraform data source.
/// Retrieves information about a aws_backup_selection.
/// </summary>
public partial class AwsBackupSelectionDataSource(string name) : TerraformDataSource("aws_backup_selection", name)
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
    /// The plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlanId is required")]
    public required TerraformValue<string> PlanId
    {
        get => new TerraformReference<string>(this, "plan_id");
        set => SetArgument("plan_id", value);
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
    /// The selection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectionId is required")]
    public required TerraformValue<string> SelectionId
    {
        get => new TerraformReference<string>(this, "selection_id");
        set => SetArgument("selection_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformSet<string> Resources
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resources").ResolveNodes(ctx));
    }

}
