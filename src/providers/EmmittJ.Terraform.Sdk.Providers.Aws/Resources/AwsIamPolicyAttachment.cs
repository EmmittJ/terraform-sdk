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
        SetOutput("groups");
        SetOutput("id");
        SetOutput("name");
        SetOutput("policy_arn");
        SetOutput("roles");
        SetOutput("users");
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformProperty<string> PolicyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_arn");
        set => SetProperty("policy_arn", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Roles
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("roles");
        set => SetProperty("roles", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Users
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("users");
        set => SetProperty("users", value);
    }

}
