using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_policy_attachment resource.
/// </summary>
public class AwsIamGroupPolicyAttachment : TerraformResource
{
    public AwsIamGroupPolicyAttachment(string name) : base("aws_iam_group_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
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
    /// The policy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("policy_arn");
        set => this.WithProperty("policy_arn", value);
    }

}
