using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_identitystore_group_membership resource.
/// </summary>
public class AwsIdentitystoreGroupMembership : TerraformResource
{
    public AwsIdentitystoreGroupMembership(string name) : base("aws_identitystore_group_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("membership_id");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_store_id");
        set => this.WithProperty("identity_store_id", value);
    }

    /// <summary>
    /// The member_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MemberId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_id");
        set => this.WithProperty("member_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The membership_id attribute.
    /// </summary>
    public TerraformExpression MembershipId => this["membership_id"];

}
