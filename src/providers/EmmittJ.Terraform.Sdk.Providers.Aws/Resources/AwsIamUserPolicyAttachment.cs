using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_policy_attachment resource.
/// </summary>
public class AwsIamUserPolicyAttachment : TerraformResource
{
    public AwsIamUserPolicyAttachment(string name) : base("aws_iam_user_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("policy_arn");
        SetOutput("user");
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
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformProperty<string> PolicyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_arn");
        set => SetProperty("policy_arn", value);
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
