using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_group_membership resource.
/// </summary>
public class AwsIamUserGroupMembership : TerraformResource
{
    public AwsIamUserGroupMembership(string name) : base("aws_iam_user_group_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Groups is required")]
    public HashSet<TerraformProperty<string>>? Groups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("groups");
        set => this.WithProperty("groups", value);
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
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformProperty<string> User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

}
