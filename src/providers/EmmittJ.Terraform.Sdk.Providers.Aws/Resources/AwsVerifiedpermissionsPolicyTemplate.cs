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
        this.WithOutput("created_date");
        this.WithOutput("id");
        this.WithOutput("policy_template_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformProperty<string> PolicyStoreId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("policy_store_id");
        set => this.WithProperty("policy_store_id", value);
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
    /// The statement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statement is required")]
    public required TerraformProperty<string> Statement
    {
        get => GetRequiredProperty<TerraformProperty<string>>("statement");
        set => this.WithProperty("statement", value);
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
