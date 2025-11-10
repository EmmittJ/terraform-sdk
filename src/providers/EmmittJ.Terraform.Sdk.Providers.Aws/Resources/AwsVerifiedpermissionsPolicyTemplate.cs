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
        SetOutput("created_date");
        SetOutput("id");
        SetOutput("policy_template_id");
        SetOutput("description");
        SetOutput("policy_store_id");
        SetOutput("region");
        SetOutput("statement");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformProperty<string> PolicyStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_store_id");
        set => SetProperty("policy_store_id", value);
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
    /// The statement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statement is required")]
    public required TerraformProperty<string> Statement
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statement");
        set => SetProperty("statement", value);
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
