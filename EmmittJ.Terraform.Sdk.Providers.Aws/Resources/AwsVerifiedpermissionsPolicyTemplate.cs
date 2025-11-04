using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedpermissions_policy_template resource.
/// </summary>
public class AwsVerifiedpermissionsPolicyTemplate : TerraformResource
{
    public AwsVerifiedpermissionsPolicyTemplate(string name) : base("aws_verifiedpermissions_policy_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_date");
        this.DeclareOutput("id");
        this.DeclareOutput("policy_template_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    public string? PolicyStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_store_id")?.Value;
        set => this.WithProperty("policy_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statement attribute.
    /// </summary>
    public string? Statement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement")?.Value;
        set => this.WithProperty("statement", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The policy_template_id attribute.
    /// </summary>
    public TerraformExpression PolicyTemplateId => this["policy_template_id"];

}
