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
        SetOutput("groups");
        SetOutput("id");
        SetOutput("user");
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Groups is required")]
    public HashSet<TerraformProperty<string>> Groups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("groups");
        set => SetProperty("groups", value);
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
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformProperty<string> User
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user");
        set => SetProperty("user", value);
    }

}
