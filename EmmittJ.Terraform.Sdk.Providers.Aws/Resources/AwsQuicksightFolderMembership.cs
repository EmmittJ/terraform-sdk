using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_folder_membership resource.
/// </summary>
public class AwsQuicksightFolderMembership : TerraformResource
{
    public AwsQuicksightFolderMembership(string name) : base("aws_quicksight_folder_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    public string? FolderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder_id")?.Value;
        set => this.WithProperty("folder_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The member_id attribute.
    /// </summary>
    public string? MemberId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_id")?.Value;
        set => this.WithProperty("member_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The member_type attribute.
    /// </summary>
    public string? MemberType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_type")?.Value;
        set => this.WithProperty("member_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
