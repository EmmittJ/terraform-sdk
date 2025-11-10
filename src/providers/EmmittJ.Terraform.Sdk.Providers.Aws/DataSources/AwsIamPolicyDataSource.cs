using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_policy.
/// </summary>
public class AwsIamPolicyDataSource : TerraformDataSource
{
    public AwsIamPolicyDataSource(string name) : base("aws_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("attachment_count");
        SetOutput("description");
        SetOutput("path");
        SetOutput("policy");
        SetOutput("policy_id");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("path_prefix");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformProperty<string> PathPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path_prefix");
        set => SetProperty("path_prefix", value);
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
    /// The attachment_count attribute.
    /// </summary>
    public TerraformExpression AttachmentCount => this["attachment_count"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformExpression PolicyId => this["policy_id"];

}
