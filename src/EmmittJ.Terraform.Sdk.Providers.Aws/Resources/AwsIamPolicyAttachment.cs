using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_policy_attachment resource.
/// </summary>
public class AwsIamPolicyAttachment : TerraformResource
{
    public AwsIamPolicyAttachment(string name) : base("aws_iam_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformProperty<string> PolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("policy_arn");
        set => this.WithProperty("policy_arn", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Roles
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("roles");
        set => this.WithProperty("roles", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Users
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("users");
        set => this.WithProperty("users", value);
    }

}
