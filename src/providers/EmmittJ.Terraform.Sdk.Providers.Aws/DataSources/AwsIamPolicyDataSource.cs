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
        this.WithOutput("attachment_count");
        this.WithOutput("description");
        this.WithOutput("path");
        this.WithOutput("policy");
        this.WithOutput("policy_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? PathPrefix
    {
        get => GetProperty<TerraformProperty<string>>("path_prefix");
        set => this.WithProperty("path_prefix", value);
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
