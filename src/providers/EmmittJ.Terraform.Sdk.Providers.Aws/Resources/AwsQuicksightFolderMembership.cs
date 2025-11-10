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
        SetOutput("id");
        SetOutput("aws_account_id");
        SetOutput("folder_id");
        SetOutput("member_id");
        SetOutput("member_type");
        SetOutput("region");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The folder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformProperty<string> FolderId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("folder_id");
        set => SetProperty("folder_id", value);
    }

    /// <summary>
    /// The member_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberId is required")]
    public required TerraformProperty<string> MemberId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_id");
        set => SetProperty("member_id", value);
    }

    /// <summary>
    /// The member_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberType is required")]
    public required TerraformProperty<string> MemberType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_type");
        set => SetProperty("member_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
