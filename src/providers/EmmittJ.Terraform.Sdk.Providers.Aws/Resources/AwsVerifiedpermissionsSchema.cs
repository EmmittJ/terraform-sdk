using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedpermissionsSchemaDefinitionBlock : TerraformBlockBase
{
    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_verifiedpermissions_schema resource.
/// </summary>
public partial class AwsVerifiedpermissionsSchema : TerraformResource
{
    public AwsVerifiedpermissionsSchema(string name) : base("aws_verifiedpermissions_schema", name)
    {
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    [TerraformProperty("policy_store_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("definition")]
    public TerraformList<TerraformBlock<AwsVerifiedpermissionsSchemaDefinitionBlock>>? Definition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    [TerraformProperty("namespaces")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Namespaces { get; }

}
