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
        this.DeclareOutput("arn");
        this.DeclareOutput("assume_role_policy");
        this.DeclareOutput("create_date");
        this.DeclareOutput("description");
        this.DeclareOutput("max_session_duration");
        this.DeclareOutput("path");
        this.DeclareOutput("permissions_boundary");
        this.DeclareOutput("role_last_used");
        this.DeclareOutput("unique_id");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
