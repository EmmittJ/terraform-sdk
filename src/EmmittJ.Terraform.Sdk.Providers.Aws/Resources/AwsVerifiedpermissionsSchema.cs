using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsSchemaDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_verifiedpermissions_schema resource.
/// </summary>
public class AwsVerifiedpermissionsSchema : TerraformResource
{
    public AwsVerifiedpermissionsSchema(string name) : base("aws_verifiedpermissions_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("namespaces");
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformProperty<string> PolicyStoreId
    {
        get => GetProperty<TerraformProperty<string>>("policy_store_id");
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
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsVerifiedpermissionsSchemaDefinitionBlock>? Definition
    {
        get => GetProperty<List<AwsVerifiedpermissionsSchemaDefinitionBlock>>("definition");
        set => this.WithProperty("definition", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    public TerraformExpression Namespaces => this["namespaces"];

}
