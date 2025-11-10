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
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotResources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("not_resources");
        set => this.WithProperty("not_resources", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlanId is required")]
    public required TerraformProperty<string> PlanId
    {
        get => GetProperty<TerraformProperty<string>>("plan_id");
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
    /// The resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Resources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resources");
        set => this.WithProperty("resources", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBackupSelectionConditionBlock>? Condition
    {
        get => GetProperty<HashSet<AwsBackupSelectionConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// Block for selection_tag.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsBackupSelectionSelectionTagBlock>? SelectionTag
    {
        get => GetProperty<HashSet<AwsBackupSelectionSelectionTagBlock>>("selection_tag");
        set => this.WithProperty("selection_tag", value);
    }

}
