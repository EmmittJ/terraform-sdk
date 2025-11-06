using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_inspector2_member_association resource.
/// </summary>
public class AwsInspector2MemberAssociation : TerraformResource
{
    public AwsInspector2MemberAssociation(string name) : base("aws_inspector2_member_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("delegated_admin_account_id");
        this.DeclareOutput("relationship_status");
        this.DeclareOutput("updated_at");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delegated_admin_account_id attribute.
    /// </summary>
    public TerraformExpression DelegatedAdminAccountId => this["delegated_admin_account_id"];

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformExpression RelationshipStatus => this["relationship_status"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
