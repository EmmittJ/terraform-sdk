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
    public string? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group")?.Value;
        set => this.WithProperty("group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public string? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn")?.Value;
        set => this.WithProperty("policy_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
