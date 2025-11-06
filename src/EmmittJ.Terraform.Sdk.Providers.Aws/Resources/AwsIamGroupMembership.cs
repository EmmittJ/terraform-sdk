using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_group_membership resource.
/// </summary>
public class AwsIamGroupMembership : TerraformResource
{
    public AwsIamGroupMembership(string name) : base("aws_iam_group_membership", name)
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public HashSet<string>? Users
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("users")?.Value;
        set => this.WithProperty("users", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
