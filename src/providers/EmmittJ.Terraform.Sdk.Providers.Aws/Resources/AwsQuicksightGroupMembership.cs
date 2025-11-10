using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_group_membership resource.
/// </summary>
public class AwsQuicksightGroupMembership : TerraformResource
{
    public AwsQuicksightGroupMembership(string name) : base("aws_quicksight_group_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("aws_account_id");
        SetOutput("group_name");
        SetOutput("id");
        SetOutput("member_name");
        SetOutput("namespace");
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
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformProperty<string> GroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_name");
        set => SetProperty("group_name", value);
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
    /// The member_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberName is required")]
    public required TerraformProperty<string> MemberName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_name");
        set => SetProperty("member_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
