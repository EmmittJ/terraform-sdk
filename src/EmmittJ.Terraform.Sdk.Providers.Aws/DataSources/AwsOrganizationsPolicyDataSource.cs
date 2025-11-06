using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_policy.
/// </summary>
public class AwsOrganizationsPolicyDataSource : TerraformDataSource
{
    public AwsOrganizationsPolicyDataSource(string name) : base("aws_organizations_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_managed");
        this.DeclareOutput("content");
        this.DeclareOutput("description");
        this.DeclareOutput("name");
        this.DeclareOutput("type");
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
    /// The policy_id attribute.
    /// </summary>
    public string? PolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_id")?.Value;
        set => this.WithProperty("policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The aws_managed attribute.
    /// </summary>
    public TerraformExpression AwsManaged => this["aws_managed"];

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformExpression Content => this["content"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
