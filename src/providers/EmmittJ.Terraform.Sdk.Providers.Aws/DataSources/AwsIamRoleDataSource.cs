using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_role.
/// </summary>
public class AwsIamRoleDataSource : TerraformDataSource
{
    public AwsIamRoleDataSource(string name) : base("aws_iam_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("assume_role_policy");
        SetOutput("create_date");
        SetOutput("description");
        SetOutput("max_session_duration");
        SetOutput("path");
        SetOutput("permissions_boundary");
        SetOutput("role_last_used");
        SetOutput("unique_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("tags");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    public TerraformExpression AssumeRolePolicy => this["assume_role_policy"];

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformExpression CreateDate => this["create_date"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    public TerraformExpression MaxSessionDuration => this["max_session_duration"];

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    public TerraformExpression PermissionsBoundary => this["permissions_boundary"];

    /// <summary>
    /// The role_last_used attribute.
    /// </summary>
    public TerraformExpression RoleLastUsed => this["role_last_used"];

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
