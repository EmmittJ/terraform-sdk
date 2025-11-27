using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in AwsVerifiedpermissionsSchema.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsSchemaDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "definition";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_verifiedpermissions_schema Terraform resource.
/// Manages a aws_verifiedpermissions_schema resource.
/// </summary>
public partial class AwsVerifiedpermissionsSchema(string name) : TerraformResource("aws_verifiedpermissions_schema", name)
{
    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformValue<string> PolicyStoreId
    {
        get => new TerraformReference<string>(this, "policy_store_id");
        set => SetArgument("policy_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    public TerraformSet<string> Namespaces
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "namespaces").ResolveNodes(ctx));
    }

    /// <summary>
    /// Definition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsSchemaDefinitionBlock>? Definition
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsSchemaDefinitionBlock>>("definition");
        set => SetArgument("definition", value);
    }

}
