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
        SetOutput("arn");
        SetOutput("aws_managed");
        SetOutput("content");
        SetOutput("description");
        SetOutput("name");
        SetOutput("type");
        SetOutput("id");
        SetOutput("policy_id");
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
    /// The policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformProperty<string> PolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_id");
        set => SetProperty("policy_id", value);
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
