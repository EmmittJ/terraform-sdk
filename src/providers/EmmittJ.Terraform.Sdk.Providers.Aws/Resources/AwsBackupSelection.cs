using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in .
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionConditionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for selection_tag in .
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionSelectionTagBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

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
        SetOutput("iam_role_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("not_resources");
        SetOutput("plan_id");
        SetOutput("region");
        SetOutput("resources");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The not_resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> NotResources
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("not_resources");
        set => SetProperty("not_resources", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlanId is required")]
    public required TerraformProperty<string> PlanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plan_id");
        set => SetProperty("plan_id", value);
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
    /// The resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Resources
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("resources");
        set => SetProperty("resources", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBackupSelectionConditionBlock>? Condition
    {
        set => SetProperty("condition", value);
    }

    /// <summary>
    /// Block for selection_tag.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBackupSelectionSelectionTagBlock>? SelectionTag
    {
        set => SetProperty("selection_tag", value);
    }

}
