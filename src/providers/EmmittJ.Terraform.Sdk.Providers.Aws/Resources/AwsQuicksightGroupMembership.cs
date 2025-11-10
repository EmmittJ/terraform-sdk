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
        this.WithOutput("arn");
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
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformProperty<string> GroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
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
    /// The member_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberName is required")]
    public required TerraformProperty<string> MemberName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("member_name");
        set => this.WithProperty("member_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
