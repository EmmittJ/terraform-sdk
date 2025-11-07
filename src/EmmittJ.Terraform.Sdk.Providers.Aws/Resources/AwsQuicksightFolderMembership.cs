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
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    public TerraformProperty<string>? FolderId
    {
        get => GetProperty<TerraformProperty<string>>("folder_id");
        set => this.WithProperty("folder_id", value);
    }

    /// <summary>
    /// The member_id attribute.
    /// </summary>
    public TerraformProperty<string>? MemberId
    {
        get => GetProperty<TerraformProperty<string>>("member_id");
        set => this.WithProperty("member_id", value);
    }

    /// <summary>
    /// The member_type attribute.
    /// </summary>
    public TerraformProperty<string>? MemberType
    {
        get => GetProperty<TerraformProperty<string>>("member_type");
        set => this.WithProperty("member_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
