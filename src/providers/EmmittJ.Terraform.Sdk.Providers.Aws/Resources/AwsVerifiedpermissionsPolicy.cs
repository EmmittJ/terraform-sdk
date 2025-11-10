using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_verifiedpermissions_policy resource.
/// </summary>
public class AwsVerifiedpermissionsPolicy : TerraformResource
{
    public AwsVerifiedpermissionsPolicy(string name) : base("aws_verifiedpermissions_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_date");
        SetOutput("id");
        SetOutput("policy_id");
        SetOutput("policy_store_id");
        SetOutput("region");
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
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsVerifiedpermissionsPolicyDefinitionBlock>? Definition
    {
        set => SetProperty("definition", value);
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
    /// The policy_id attribute.
    /// </summary>
    public TerraformExpression PolicyId => this["policy_id"];

}
